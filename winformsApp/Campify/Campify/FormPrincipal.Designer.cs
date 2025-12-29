namespace Campify
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            pbLogo = new PictureBox();
            btnEmpleados = new Button();
            btnParcelas = new Button();
            pbAjustes = new PictureBox();
            btnServicios = new Button();
            pnlServicios = new Panel();
            btnEliminarServicio = new Button();
            btnEditarServicio = new Button();
            btnNuevoServicio = new Button();
            ucServicioDatos1 = new Controles.ucServicioDatos();
            flpServicios = new FlowLayoutPanel();
            btnDatos = new Button();
            btnReservar = new Button();
            btLista = new Button();
            btnHistorial = new Button();
            panelMapaLista = new Panel();
            flpParcelas = new FlowLayoutPanel();
            pbMapa = new PictureBox();
            btnEstanciaActual = new Button();
            panelDatos = new Panel();
            ucParcelaDatos = new Controles.ucParcelaDatos();
            ucEstanciaActual1 = new Controles.ucEstanciaActual();
            ucHistorial1 = new Controles.ucHistorial();
            btMapa = new Button();
            pnlParcelas = new Panel();
            btnMantenimiento = new Button();
            btnClientesEstancia = new Button();
            btnServiciosEstancia = new Button();
            pnlEmpleados = new Panel();
            btnEliminarEmpleado = new Button();
            btnEditarEmpleado = new Button();
            btnNuevoEmpleado = new Button();
            ucEmpleadoDatos1 = new Controles.ucEmpleadoDatos();
            flpEmpleados = new FlowLayoutPanel();
            btnEstancias = new Button();
            pnlEstancias = new Panel();
            ucEstanciaActual2 = new Controles.ucEstanciaActual();
            flpEstancias = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAjustes).BeginInit();
            pnlServicios.SuspendLayout();
            panelMapaLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMapa).BeginInit();
            panelDatos.SuspendLayout();
            pnlParcelas.SuspendLayout();
            pnlEmpleados.SuspendLayout();
            pnlEstancias.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(0, 0);
            pbLogo.Margin = new Padding(3, 4, 3, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(106, 116);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEmpleados.ForeColor = Color.FromArgb(44, 79, 29);
            btnEmpleados.Location = new Point(427, 16);
            btnEmpleados.Margin = new Padding(3, 4, 3, 4);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(137, 59);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnParcelas
            // 
            btnParcelas.FlatAppearance.BorderSize = 0;
            btnParcelas.FlatStyle = FlatStyle.Flat;
            btnParcelas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnParcelas.ForeColor = Color.FromArgb(44, 79, 29);
            btnParcelas.Location = new Point(121, 16);
            btnParcelas.Margin = new Padding(3, 4, 3, 4);
            btnParcelas.Name = "btnParcelas";
            btnParcelas.Size = new Size(137, 59);
            btnParcelas.TabIndex = 2;
            btnParcelas.Text = "Parcelas";
            btnParcelas.UseVisualStyleBackColor = true;
            btnParcelas.Click += btnParcelas_Click;
            // 
            // pbAjustes
            // 
            pbAjustes.Image = (Image)resources.GetObject("pbAjustes.Image");
            pbAjustes.Location = new Point(846, 16);
            pbAjustes.Margin = new Padding(3, 4, 3, 4);
            pbAjustes.Name = "pbAjustes";
            pbAjustes.Size = new Size(50, 56);
            pbAjustes.SizeMode = PictureBoxSizeMode.Zoom;
            pbAjustes.TabIndex = 3;
            pbAjustes.TabStop = false;
            // 
            // btnServicios
            // 
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnServicios.ForeColor = Color.FromArgb(44, 79, 29);
            btnServicios.Location = new Point(265, 16);
            btnServicios.Margin = new Padding(3, 4, 3, 4);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(137, 59);
            btnServicios.TabIndex = 10;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // pnlServicios
            // 
            pnlServicios.Controls.Add(btnEliminarServicio);
            pnlServicios.Controls.Add(btnEditarServicio);
            pnlServicios.Controls.Add(btnNuevoServicio);
            pnlServicios.Controls.Add(ucServicioDatos1);
            pnlServicios.Controls.Add(flpServicios);
            pnlServicios.Location = new Point(0, 115);
            pnlServicios.Name = "pnlServicios";
            pnlServicios.Size = new Size(913, 483);
            pnlServicios.TabIndex = 19;
            pnlServicios.Visible = false;
            // 
            // btnEliminarServicio
            // 
            btnEliminarServicio.BackColor = Color.Peru;
            btnEliminarServicio.FlatAppearance.BorderSize = 0;
            btnEliminarServicio.FlatStyle = FlatStyle.Flat;
            btnEliminarServicio.Font = new Font("Segoe UI", 12F);
            btnEliminarServicio.ForeColor = Color.Moccasin;
            btnEliminarServicio.Location = new Point(774, 435);
            btnEliminarServicio.Margin = new Padding(0);
            btnEliminarServicio.Name = "btnEliminarServicio";
            btnEliminarServicio.Size = new Size(140, 45);
            btnEliminarServicio.TabIndex = 5;
            btnEliminarServicio.Text = "Eliminar";
            btnEliminarServicio.UseVisualStyleBackColor = false;
            btnEliminarServicio.Click += btnEliminarServicio_Click;
            // 
            // btnEditarServicio
            // 
            btnEditarServicio.BackColor = Color.Peru;
            btnEditarServicio.FlatAppearance.BorderSize = 0;
            btnEditarServicio.FlatStyle = FlatStyle.Flat;
            btnEditarServicio.Font = new Font("Segoe UI", 12F);
            btnEditarServicio.ForeColor = Color.Moccasin;
            btnEditarServicio.Location = new Point(629, 435);
            btnEditarServicio.Margin = new Padding(0);
            btnEditarServicio.Name = "btnEditarServicio";
            btnEditarServicio.Size = new Size(145, 45);
            btnEditarServicio.TabIndex = 4;
            btnEditarServicio.Text = "Editar";
            btnEditarServicio.UseVisualStyleBackColor = false;
            btnEditarServicio.Click += btnEditarServicio_Click;
            // 
            // btnNuevoServicio
            // 
            btnNuevoServicio.BackColor = Color.Peru;
            btnNuevoServicio.FlatAppearance.BorderSize = 0;
            btnNuevoServicio.FlatStyle = FlatStyle.Flat;
            btnNuevoServicio.Font = new Font("Segoe UI", 12F);
            btnNuevoServicio.ForeColor = Color.Moccasin;
            btnNuevoServicio.Location = new Point(489, 435);
            btnNuevoServicio.Margin = new Padding(0);
            btnNuevoServicio.Name = "btnNuevoServicio";
            btnNuevoServicio.Size = new Size(140, 45);
            btnNuevoServicio.TabIndex = 3;
            btnNuevoServicio.Text = "Nuevo";
            btnNuevoServicio.UseVisualStyleBackColor = false;
            btnNuevoServicio.Click += btnNuevoServicio_Click;
            // 
            // ucServicioDatos1
            // 
            ucServicioDatos1.Location = new Point(489, -1);
            ucServicioDatos1.Name = "ucServicioDatos1";
            ucServicioDatos1.ServicioActual = null;
            ucServicioDatos1.Size = new Size(422, 433);
            ucServicioDatos1.TabIndex = 2;
            // 
            // flpServicios
            // 
            flpServicios.AutoScroll = true;
            flpServicios.Location = new Point(1, 47);
            flpServicios.Margin = new Padding(0);
            flpServicios.Name = "flpServicios";
            flpServicios.Size = new Size(488, 435);
            flpServicios.TabIndex = 1;
            // 
            // btnDatos
            // 
            btnDatos.BackColor = Color.FromArgb(255, 222, 171);
            btnDatos.FlatAppearance.BorderSize = 0;
            btnDatos.FlatStyle = FlatStyle.Flat;
            btnDatos.Font = new Font("Segoe UI", 12F);
            btnDatos.ForeColor = Color.FromArgb(95, 65, 0);
            btnDatos.Location = new Point(489, -3);
            btnDatos.Margin = new Padding(0);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(131, 48);
            btnDatos.TabIndex = 11;
            btnDatos.Text = "Datos";
            btnDatos.UseVisualStyleBackColor = false;
            btnDatos.Click += btnDatos_Click;
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.Peru;
            btnReservar.FlatAppearance.BorderSize = 0;
            btnReservar.FlatStyle = FlatStyle.Flat;
            btnReservar.Font = new Font("Segoe UI", 12F);
            btnReservar.ForeColor = Color.FromArgb(255, 222, 171);
            btnReservar.Location = new Point(489, 433);
            btnReservar.Margin = new Padding(0);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(226, 45);
            btnReservar.TabIndex = 9;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // btLista
            // 
            btLista.BackColor = Color.Peru;
            btLista.FlatAppearance.BorderSize = 0;
            btLista.FlatStyle = FlatStyle.Flat;
            btLista.Font = new Font("Segoe UI", 12F);
            btLista.ForeColor = Color.FromArgb(255, 222, 171);
            btLista.Location = new Point(241, 0);
            btLista.Margin = new Padding(0);
            btLista.Name = "btLista";
            btLista.Size = new Size(248, 45);
            btLista.TabIndex = 13;
            btLista.Text = "Lista";
            btLista.UseVisualStyleBackColor = false;
            btLista.Click += btLista_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(255, 222, 171);
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 12F);
            btnHistorial.ForeColor = Color.FromArgb(95, 65, 0);
            btnHistorial.Location = new Point(773, -3);
            btnHistorial.Margin = new Padding(0);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(137, 48);
            btnHistorial.TabIndex = 6;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // panelMapaLista
            // 
            panelMapaLista.Controls.Add(flpParcelas);
            panelMapaLista.Controls.Add(pbMapa);
            panelMapaLista.Location = new Point(1, 45);
            panelMapaLista.Margin = new Padding(0);
            panelMapaLista.Name = "panelMapaLista";
            panelMapaLista.Size = new Size(488, 433);
            panelMapaLista.TabIndex = 16;
            // 
            // flpParcelas
            // 
            flpParcelas.AutoScroll = true;
            flpParcelas.Dock = DockStyle.Fill;
            flpParcelas.Location = new Point(0, 0);
            flpParcelas.Margin = new Padding(0);
            flpParcelas.Name = "flpParcelas";
            flpParcelas.Size = new Size(488, 433);
            flpParcelas.TabIndex = 15;
            flpParcelas.Visible = false;
            // 
            // pbMapa
            // 
            pbMapa.Dock = DockStyle.Fill;
            pbMapa.Image = (Image)resources.GetObject("pbMapa.Image");
            pbMapa.Location = new Point(0, 0);
            pbMapa.Margin = new Padding(0);
            pbMapa.Name = "pbMapa";
            pbMapa.Size = new Size(488, 433);
            pbMapa.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMapa.TabIndex = 15;
            pbMapa.TabStop = false;
            // 
            // btnEstanciaActual
            // 
            btnEstanciaActual.BackColor = Color.FromArgb(255, 222, 171);
            btnEstanciaActual.FlatAppearance.BorderSize = 0;
            btnEstanciaActual.FlatStyle = FlatStyle.Flat;
            btnEstanciaActual.Font = new Font("Segoe UI", 12F);
            btnEstanciaActual.ForeColor = Color.FromArgb(95, 65, 0);
            btnEstanciaActual.Location = new Point(619, -3);
            btnEstanciaActual.Margin = new Padding(0);
            btnEstanciaActual.Name = "btnEstanciaActual";
            btnEstanciaActual.Size = new Size(154, 48);
            btnEstanciaActual.TabIndex = 5;
            btnEstanciaActual.Text = "Estancia actual";
            btnEstanciaActual.UseVisualStyleBackColor = false;
            btnEstanciaActual.Click += btnEstanciaActual_Click;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(ucParcelaDatos);
            panelDatos.Controls.Add(ucEstanciaActual1);
            panelDatos.Controls.Add(ucHistorial1);
            panelDatos.Location = new Point(489, 45);
            panelDatos.Margin = new Padding(0);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(421, 388);
            panelDatos.TabIndex = 17;
            // 
            // ucParcelaDatos
            // 
            ucParcelaDatos.Location = new Point(0, 0);
            ucParcelaDatos.Margin = new Padding(0);
            ucParcelaDatos.Name = "ucParcelaDatos";
            ucParcelaDatos.Size = new Size(421, 388);
            ucParcelaDatos.TabIndex = 0;
            // 
            // ucEstanciaActual1
            // 
            ucEstanciaActual1.EstanciaActual = null;
            ucEstanciaActual1.Location = new Point(0, 0);
            ucEstanciaActual1.Name = "ucEstanciaActual1";
            ucEstanciaActual1.Size = new Size(422, 388);
            ucEstanciaActual1.TabIndex = 21;
            // 
            // ucHistorial1
            // 
            ucHistorial1.Location = new Point(0, 0);
            ucHistorial1.Name = "ucHistorial1";
            ucHistorial1.Size = new Size(422, 388);
            ucHistorial1.TabIndex = 21;
            // 
            // btMapa
            // 
            btMapa.BackColor = Color.Peru;
            btMapa.FlatAppearance.BorderSize = 0;
            btMapa.FlatStyle = FlatStyle.Flat;
            btMapa.Font = new Font("Segoe UI", 12F);
            btMapa.ForeColor = Color.FromArgb(255, 222, 171);
            btMapa.Location = new Point(1, 0);
            btMapa.Margin = new Padding(0);
            btMapa.Name = "btMapa";
            btMapa.Size = new Size(240, 45);
            btMapa.TabIndex = 12;
            btMapa.Text = "Mapa";
            btMapa.UseVisualStyleBackColor = false;
            btMapa.Click += btMapa_Click;
            // 
            // pnlParcelas
            // 
            pnlParcelas.Controls.Add(btMapa);
            pnlParcelas.Controls.Add(btLista);
            pnlParcelas.Controls.Add(panelMapaLista);
            pnlParcelas.Controls.Add(btnDatos);
            pnlParcelas.Controls.Add(btnEstanciaActual);
            pnlParcelas.Controls.Add(btnHistorial);
            pnlParcelas.Controls.Add(panelDatos);
            pnlParcelas.Controls.Add(btnReservar);
            pnlParcelas.Controls.Add(btnMantenimiento);
            pnlParcelas.Controls.Add(btnClientesEstancia);
            pnlParcelas.Controls.Add(btnServiciosEstancia);
            pnlParcelas.Location = new Point(0, 117);
            pnlParcelas.Name = "pnlParcelas";
            pnlParcelas.Size = new Size(913, 480);
            pnlParcelas.TabIndex = 18;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.BackColor = Color.Peru;
            btnMantenimiento.FlatAppearance.BorderSize = 0;
            btnMantenimiento.FlatStyle = FlatStyle.Flat;
            btnMantenimiento.Font = new Font("Segoe UI", 12F);
            btnMantenimiento.ForeColor = Color.FromArgb(255, 222, 171);
            btnMantenimiento.Location = new Point(715, 433);
            btnMantenimiento.Margin = new Padding(0);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(195, 45);
            btnMantenimiento.TabIndex = 18;
            btnMantenimiento.Text = "Mantenimiento";
            btnMantenimiento.UseVisualStyleBackColor = false;
            btnMantenimiento.Click += btnMantenimiento_Click;
            // 
            // btnClientesEstancia
            // 
            btnClientesEstancia.BackColor = Color.Peru;
            btnClientesEstancia.FlatAppearance.BorderSize = 0;
            btnClientesEstancia.FlatStyle = FlatStyle.Flat;
            btnClientesEstancia.Font = new Font("Segoe UI", 12F);
            btnClientesEstancia.ForeColor = Color.FromArgb(255, 222, 171);
            btnClientesEstancia.Location = new Point(489, 433);
            btnClientesEstancia.Margin = new Padding(0);
            btnClientesEstancia.Name = "btnClientesEstancia";
            btnClientesEstancia.Size = new Size(226, 45);
            btnClientesEstancia.TabIndex = 21;
            btnClientesEstancia.Text = "Clientes";
            btnClientesEstancia.UseVisualStyleBackColor = false;
            btnClientesEstancia.Click += btnClientesEstancia_Click;
            // 
            // btnServiciosEstancia
            // 
            btnServiciosEstancia.BackColor = Color.Peru;
            btnServiciosEstancia.FlatAppearance.BorderSize = 0;
            btnServiciosEstancia.FlatStyle = FlatStyle.Flat;
            btnServiciosEstancia.Font = new Font("Segoe UI", 12F);
            btnServiciosEstancia.ForeColor = Color.FromArgb(255, 222, 171);
            btnServiciosEstancia.Location = new Point(715, 433);
            btnServiciosEstancia.Margin = new Padding(0);
            btnServiciosEstancia.Name = "btnServiciosEstancia";
            btnServiciosEstancia.Size = new Size(195, 45);
            btnServiciosEstancia.TabIndex = 21;
            btnServiciosEstancia.Text = "Servicios";
            btnServiciosEstancia.UseVisualStyleBackColor = false;
            btnServiciosEstancia.Click += btnServiciosEstancia_Click;
            // 
            // pnlEmpleados
            // 
            pnlEmpleados.Controls.Add(btnEliminarEmpleado);
            pnlEmpleados.Controls.Add(btnEditarEmpleado);
            pnlEmpleados.Controls.Add(btnNuevoEmpleado);
            pnlEmpleados.Controls.Add(ucEmpleadoDatos1);
            pnlEmpleados.Controls.Add(flpEmpleados);
            pnlEmpleados.Location = new Point(1, 115);
            pnlEmpleados.Name = "pnlEmpleados";
            pnlEmpleados.Size = new Size(913, 483);
            pnlEmpleados.TabIndex = 20;
            pnlEmpleados.Visible = false;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.BackColor = Color.Peru;
            btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            btnEliminarEmpleado.FlatStyle = FlatStyle.Flat;
            btnEliminarEmpleado.Font = new Font("Segoe UI", 12F);
            btnEliminarEmpleado.ForeColor = Color.Moccasin;
            btnEliminarEmpleado.Location = new Point(773, 437);
            btnEliminarEmpleado.Margin = new Padding(0);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(140, 45);
            btnEliminarEmpleado.TabIndex = 4;
            btnEliminarEmpleado.Text = "Eliminar";
            btnEliminarEmpleado.UseVisualStyleBackColor = false;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.BackColor = Color.Peru;
            btnEditarEmpleado.FlatAppearance.BorderSize = 0;
            btnEditarEmpleado.FlatStyle = FlatStyle.Flat;
            btnEditarEmpleado.Font = new Font("Segoe UI", 12F);
            btnEditarEmpleado.ForeColor = Color.Moccasin;
            btnEditarEmpleado.Location = new Point(628, 437);
            btnEditarEmpleado.Margin = new Padding(0);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(145, 45);
            btnEditarEmpleado.TabIndex = 3;
            btnEditarEmpleado.Text = "Editar";
            btnEditarEmpleado.UseVisualStyleBackColor = false;
            btnEditarEmpleado.Click += btnEditarEmpleado_Click;
            // 
            // btnNuevoEmpleado
            // 
            btnNuevoEmpleado.BackColor = Color.Peru;
            btnNuevoEmpleado.FlatAppearance.BorderSize = 0;
            btnNuevoEmpleado.FlatStyle = FlatStyle.Flat;
            btnNuevoEmpleado.Font = new Font("Segoe UI", 12F);
            btnNuevoEmpleado.ForeColor = Color.Moccasin;
            btnNuevoEmpleado.Location = new Point(488, 437);
            btnNuevoEmpleado.Margin = new Padding(0);
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.Size = new Size(140, 45);
            btnNuevoEmpleado.TabIndex = 2;
            btnNuevoEmpleado.Text = "Nuevo";
            btnNuevoEmpleado.UseVisualStyleBackColor = false;
            btnNuevoEmpleado.Click += btnNuevoEmpleado_Click;
            // 
            // ucEmpleadoDatos1
            // 
            ucEmpleadoDatos1.Location = new Point(488, 0);
            ucEmpleadoDatos1.Margin = new Padding(0);
            ucEmpleadoDatos1.Name = "ucEmpleadoDatos1";
            ucEmpleadoDatos1.Size = new Size(425, 437);
            ucEmpleadoDatos1.TabIndex = 1;
            // 
            // flpEmpleados
            // 
            flpEmpleados.AutoScroll = true;
            flpEmpleados.Location = new Point(0, 0);
            flpEmpleados.Margin = new Padding(0);
            flpEmpleados.Name = "flpEmpleados";
            flpEmpleados.Size = new Size(488, 481);
            flpEmpleados.TabIndex = 0;
            // 
            // btnEstancias
            // 
            btnEstancias.FlatAppearance.BorderSize = 0;
            btnEstancias.FlatStyle = FlatStyle.Flat;
            btnEstancias.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEstancias.ForeColor = Color.FromArgb(44, 79, 29);
            btnEstancias.Location = new Point(602, 16);
            btnEstancias.Margin = new Padding(3, 4, 3, 4);
            btnEstancias.Name = "btnEstancias";
            btnEstancias.Size = new Size(137, 59);
            btnEstancias.TabIndex = 21;
            btnEstancias.Text = "Estancias";
            btnEstancias.UseVisualStyleBackColor = true;
            btnEstancias.Click += btnEstancias_Click;
            // 
            // pnlEstancias
            // 
            pnlEstancias.Controls.Add(ucEstanciaActual2);
            pnlEstancias.Controls.Add(flpEstancias);
            pnlEstancias.Location = new Point(1, 111);
            pnlEstancias.Name = "pnlEstancias";
            pnlEstancias.Size = new Size(913, 487);
            pnlEstancias.TabIndex = 22;
            pnlEstancias.Visible = false;
            // 
            // ucEstanciaActual2
            // 
            ucEstanciaActual2.EstanciaActual = null;
            ucEstanciaActual2.Location = new Point(488, -1);
            ucEstanciaActual2.Name = "ucEstanciaActual2";
            ucEstanciaActual2.Size = new Size(425, 396);
            ucEstanciaActual2.TabIndex = 1;
            // 
            // flpEstancias
            // 
            flpEstancias.AutoScroll = true;
            flpEstancias.Location = new Point(0, 51);
            flpEstancias.Margin = new Padding(0);
            flpEstancias.Name = "flpEstancias";
            flpEstancias.Size = new Size(488, 435);
            flpEstancias.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(915, 597);
            Controls.Add(pnlEstancias);
            Controls.Add(pnlServicios);
            Controls.Add(pnlEmpleados);
            Controls.Add(pnlParcelas);
            Controls.Add(btnParcelas);
            Controls.Add(pbLogo);
            Controls.Add(btnServicios);
            Controls.Add(btnEmpleados);
            Controls.Add(btnEstancias);
            Controls.Add(pbAjustes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            Text = "Daniel capullo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAjustes).EndInit();
            pnlServicios.ResumeLayout(false);
            panelMapaLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMapa).EndInit();
            panelDatos.ResumeLayout(false);
            pnlParcelas.ResumeLayout(false);
            pnlEmpleados.ResumeLayout(false);
            pnlEstancias.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Button btnEmpleados;
        private Button btnParcelas;
        private PictureBox pbAjustes;
        private Button btnServicios;
        private Panel pnlServicios;
        private Button btnDatos;
        private Button btnReservar;
        private Button btLista;
        private Button btnHistorial;
        private Panel panelMapaLista;
        private FlowLayoutPanel flpParcelas;
        private PictureBox pbMapa;
        private Button btnEstanciaActual;
        private Panel panelDatos;
        private Controles.ucParcelaDatos ucParcelaDatos;
        private Button btMapa;
        private Panel pnlParcelas;
        private Panel pnlEmpleados;
        private Controles.ucEstanciaActual ucEstanciaActual1;
        private Controles.ucHistorial ucHistorial1;
        private Button btnMantenimiento;
        private FlowLayoutPanel flpEmpleados;
        private Controles.ucEmpleadoDatos ucEmpleadoDatos1;
        private Button btnEliminarEmpleado;
        private Button btnEditarEmpleado;
        private Button btnNuevoEmpleado;
        private Button btnServiciosEstancia;
        private Button btnClientesEstancia;
        private Button btnEstancias;
        private Panel pnlEstancias;
        private FlowLayoutPanel flpServicios;
        private Controles.ucServicioDatos ucServicioDatos1;
        private Button btnEditarServicio;
        private Button btnNuevoServicio;
        private Button btnEliminarServicio;
        private FlowLayoutPanel flpEstancias;
        private Controles.ucEstanciaActual ucEstanciaActual2;
    }
}
