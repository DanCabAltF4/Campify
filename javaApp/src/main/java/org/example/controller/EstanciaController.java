package org.example.controller;

import org.example.model.Estancia;
import org.example.service.ServiceEstancia;
import org.springframework.http.ContentDisposition;
import org.springframework.http.HttpHeaders;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.time.LocalDate;
import java.util.Date;
import java.util.List;

@RestController
@RequestMapping("/api/estancias")
public class EstanciaController {

    private final ServiceEstancia service;

    public EstanciaController(ServiceEstancia service) {
        this.service = service;
    }

    @PostMapping
    public Estancia insert (@RequestBody Estancia estancia){
        return service.insert(estancia);
    }

    @DeleteMapping("/{id}")
    public void delete (@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Estancia update (@PathVariable int id, @RequestBody Estancia estancia){
        return service.update(id, estancia);
    }

    @GetMapping("/{id}")
    public Estancia findById(@PathVariable  int id){
        return service.findById(id);
    }

    @GetMapping
    public List<Estancia> findAll(){
        return service.findAll();
    }


    @GetMapping("/{id}/clientes/pdf")
    public ResponseEntity<byte[]> descargarClientesPdf(@PathVariable int id) {
        byte[] pdf = service.generarPdfClientes(id);

        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_PDF);
        headers.setContentDisposition(ContentDisposition.attachment().filename(LocalDate.now()+"_estancia_" + id + "_clientes.pdf").build());
        return ResponseEntity.ok().headers(headers).body(pdf);
    }

}
