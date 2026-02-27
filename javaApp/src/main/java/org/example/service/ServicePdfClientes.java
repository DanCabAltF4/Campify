package org.example.service;

import com.lowagie.text.*;
import com.lowagie.text.pdf.PdfPCell;
import com.lowagie.text.pdf.PdfPTable;
import com.lowagie.text.pdf.PdfWriter;
import org.example.model.Cliente;
import org.example.model.Estancia;
import org.springframework.stereotype.Service;


import java.io.ByteArrayOutputStream;
import java.io.InputStream;

@Service
public class ServicePdfClientes {

    public byte[] buildClientesPdf(Estancia estancia) {
        try (ByteArrayOutputStream out = new ByteArrayOutputStream()) {

            Document document = new Document(PageSize.A4, 48, 48, 48, 48);
            PdfWriter.getInstance(document, out);

            // Fuentes
            Font titleFont = FontFactory.getFont(FontFactory.HELVETICA_BOLD, 15);
            Font subtitleFont = FontFactory.getFont(FontFactory.HELVETICA, 11);
            Font sectionFont = FontFactory.getFont(FontFactory.HELVETICA_BOLD, 12);
            Font labelFont = FontFactory.getFont(FontFactory.HELVETICA_BOLD, 10);
            Font valueFont = FontFactory.getFont(FontFactory.HELVETICA, 10);

            document.open();


            // CABECERA (parcela+estancia   --   datos empresa)
            String parcelaId = (estancia.getParcela() != null) ? String.valueOf(estancia.getParcela().getId()) : "—";

            PdfPTable header = new PdfPTable(2);
            header.setWidthPercentage(100);
            header.setWidths(new float[]{3.5f, 2.5f}); // izq / der

            // izquierda: datos estancia
            Paragraph left = new Paragraph();
            left.add(new Chunk("Parcela " + parcelaId + "\n", titleFont));
            left.add(new Chunk("Estancia Nº " + estancia.getId() + "\n\n", titleFont));
            left.add(new Chunk("Check-in: " + safeDate(estancia.getCheckIn()) + "\n", subtitleFont));
            left.add(new Chunk("Check-out: " + safeDate(estancia.getCheckOut()), subtitleFont));

            PdfPCell leftCell = new PdfPCell(left);
            leftCell.setBorder(Rectangle.NO_BORDER);
            leftCell.setVerticalAlignment(Element.ALIGN_TOP);
            leftCell.setPadding(0);

            // derecha: logo + datos empresa
            PdfPCell rightCell = new PdfPCell();
            rightCell.setBorder(Rectangle.NO_BORDER);
            rightCell.setVerticalAlignment(Element.ALIGN_TOP);
            rightCell.setPadding(0);

            // Tabla interna para texto + logo
            PdfPTable empresaTable = new PdfPTable(2);
            empresaTable.setWidthPercentage(100);
            empresaTable.setWidths(new float[]{3f, 2f}); // texto más ancho que logo

            // Columna izquierda: datos empresa
            Paragraph empresa = new Paragraph();
            empresa.setLeading(0, 1.2f);

            empresa.add(new Chunk("Campify\n", FontFactory.getFont(FontFactory.HELVETICA_BOLD, 11)));
            empresa.add(new Chunk("Av. de la Costa, 15\n", valueFont));
            empresa.add(new Chunk("39300 Torrelavega\n", valueFont));
            empresa.add(new Chunk("Tel: 600 123 456\n", valueFont));
            empresa.add(new Chunk("info@campify.com", valueFont));

            PdfPCell empresaCell = new PdfPCell(empresa);
            empresaCell.setBorder(Rectangle.NO_BORDER);
            empresaCell.setVerticalAlignment(Element.ALIGN_MIDDLE);

            // Columna derecha: logo
            PdfPCell logoCell = new PdfPCell();
            logoCell.setBorder(Rectangle.NO_BORDER);
            logoCell.setHorizontalAlignment(Element.ALIGN_RIGHT);
            logoCell.setVerticalAlignment(Element.ALIGN_MIDDLE);

            Image logo = cargarLogoDeResources("/logo.png");
            if (logo != null) {
                logo.scaleToFit(160, 80);
                logo.setAlignment(Image.ALIGN_RIGHT);
                logoCell.addElement(logo);
            }

            empresaTable.addCell(empresaCell);
            empresaTable.addCell(logoCell);

            rightCell.addElement(empresaTable);

            header.addCell(leftCell);
            header.addCell(rightCell);

            document.add(header);

            // espacio entre cabecera y clientes
            document.add(new Paragraph(" "));


            // SIN CLIENTES
            if (estancia.getClientes() == null || estancia.getClientes().isEmpty()) {
                Paragraph empty = new Paragraph("No hay clientes asociados a esta estancia.", valueFont);
                empty.setSpacingBefore(10);
                document.add(empty);
                document.close();
                return out.toByteArray();
            }


            // BLOQUES POR CLIENTE
            int idx = 1;
            for (Cliente c : estancia.getClientes()) {

                Paragraph clienteTitle = new Paragraph("Cliente " + idx + " (ID: " + safe(c.getId()) + ")", sectionFont);
                clienteTitle.setSpacingBefore(10);
                clienteTitle.setSpacingAfter(6);
                document.add(clienteTitle);

                float indent = 25f;

                document.add(sangriarLinea(labelFont, valueFont, "Nombre", c.getNombre(), indent));
                document.add(sangriarLinea(labelFont, valueFont, "Apellidos", c.getApellidos(), indent));
                document.add(sangriarLinea(labelFont, valueFont, "DNI", c.getDni(), indent));
                document.add(sangriarLinea(labelFont, valueFont, "Fecha nacimiento", safeDate(c.getFechaNacimiento()), indent));
                document.add(sangriarLinea(labelFont, valueFont, "Teléfono", c.getTelefono(), indent));
                document.add(sangriarLinea(labelFont, valueFont, "Email", c.getEmail(), indent));
                document.add(sangriarLinea(labelFont, valueFont, "Dirección", c.getDireccion(), indent));

                Paragraph sep = new Paragraph(" ");
                sep.setSpacingAfter(3);
                document.add(sep);

                idx++;
            }

            document.close();
            return out.toByteArray();

        } catch (Exception e) {
            throw new RuntimeException("Error generando PDF de clientes", e);
        }
    }

    // Aplica sangría para mejorar visualmente el formato del pdf
    private Paragraph sangriarLinea(Font labelFont, Font valueFont, String label, Object value, float indentLeft) {
        Paragraph p = new Paragraph();
        p.setLeading(0, 1.20f);
        p.setSpacingAfter(2);
        p.setIndentationLeft(indentLeft);

        Chunk cLabel = new Chunk(label + ": ", labelFont);
        Chunk cValue = new Chunk(value == null ? "" : String.valueOf(value), valueFont);

        p.add(cLabel);
        p.add(cValue);
        return p;
    }

    private Image cargarLogoDeResources(String resourcePath) {
        try (InputStream is = getClass().getResourceAsStream(resourcePath)) {
            if (is == null) return null;

            ByteArrayOutputStream buffer = new ByteArrayOutputStream();
            byte[] data = new byte[4096];
            int nRead;
            while ((nRead = is.read(data, 0, data.length)) != -1) {
                buffer.write(data, 0, nRead);
            }
            buffer.flush();

            return Image.getInstance(buffer.toByteArray());
        } catch (Exception e) {
            return null;
        }
    }

    private String safe(Object o) {
        return o == null ? "" : String.valueOf(o);
    }

    private String safeDate(Object date) {
        return date == null ? "" : String.valueOf(date);
    }

}
