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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            pbLogo = new PictureBox();
            btnEmpleados = new Button();
            btnParcelas = new Button();
            btnServicios = new Button();
            pnlServicios = new Panel();
            btnRefrescarServicios = new Button();
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
            flpHistorial = new FlowLayoutPanel();
            ucHistorial1 = new Controles.ucHistorial();
            btMapa = new Button();
            pnlParcelas = new Panel();
            btnRefrescarParcelas = new Button();
            btnMantenimiento = new Button();
            btnClientesEstancia = new Button();
            btnServiciosEstancia = new Button();
            pnlEmpleados = new Panel();
            btnRefrescarEmpleados = new Button();
            btnEliminarEmpleado = new Button();
            btnEditarEmpleado = new Button();
            btnNuevoEmpleado = new Button();
            ucEmpleadoDatos1 = new Controles.ucEmpleadoDatos();
            flpEmpleados = new FlowLayoutPanel();
            btnEstancias = new Button();
            pnlEstancias = new Panel();
            btnEliminarEstancia = new Button();
            btnEditarEstancia = new Button();
            btnRefrescarEstancias = new Button();
            ucEstanciaActual2 = new Controles.ucEstanciaActual();
            flpEstancias = new FlowLayoutPanel();
            btnClientes = new Button();
            pnlClientes = new Panel();
            flpClientes = new FlowLayoutPanel();
            ucClientesLista1 = new Controles.ucClientesLista();
            btnRefrescarClientes = new Button();
            ucClienteDatos1 = new Controles.ucClienteDatos();
            btnNuevoCliente = new Button();
            btnEditarCliente = new Button();
            btnEliminarCliente = new Button();
            btnLogOut = new Button();
            pnlTop = new Panel();
            lblFechaHora = new Label();
            btnMinimizar = new Button();
            lblTitulo = new Label();
            btnSalir = new Button();
            tmFechaHora = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlServicios.SuspendLayout();
            panelMapaLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMapa).BeginInit();
            panelDatos.SuspendLayout();
            flpHistorial.SuspendLayout();
            pnlParcelas.SuspendLayout();
            pnlEmpleados.SuspendLayout();
            pnlEstancias.SuspendLayout();
            pnlClientes.SuspendLayout();
            flpClientes.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(0, 27);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(93, 87);
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
            btnEmpleados.Location = new Point(602, 37);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(118, 44);
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
            btnParcelas.Location = new Point(107, 37);
            btnParcelas.Name = "btnParcelas";
            btnParcelas.Size = new Size(118, 44);
            btnParcelas.TabIndex = 2;
            btnParcelas.Text = "Parcelas";
            btnParcelas.UseVisualStyleBackColor = true;
            btnParcelas.Click += btnParcelas_Click;
            // 
            // btnServicios
            // 
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnServicios.ForeColor = Color.FromArgb(44, 79, 29);
            btnServicios.Location = new Point(230, 37);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(118, 44);
            btnServicios.TabIndex = 10;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // pnlServicios
            // 
            pnlServicios.Controls.Add(btnRefrescarServicios);
            pnlServicios.Controls.Add(btnEliminarServicio);
            pnlServicios.Controls.Add(btnEditarServicio);
            pnlServicios.Controls.Add(btnNuevoServicio);
            pnlServicios.Controls.Add(ucServicioDatos1);
            pnlServicios.Controls.Add(flpServicios);
            pnlServicios.Location = new Point(0, 113);
            pnlServicios.Margin = new Padding(3, 2, 3, 2);
            pnlServicios.Name = "pnlServicios";
            pnlServicios.Size = new Size(799, 362);
            pnlServicios.TabIndex = 19;
            pnlServicios.Visible = false;
            // 
            // btnRefrescarServicios
            // 
            btnRefrescarServicios.FlatAppearance.BorderSize = 0;
            btnRefrescarServicios.FlatStyle = FlatStyle.Flat;
            btnRefrescarServicios.Font = new Font("Segoe UI", 20F);
            btnRefrescarServicios.Image = Forms.Properties.Resources.refresh_arrow;
            btnRefrescarServicios.Location = new Point(384, -4);
            btnRefrescarServicios.Margin = new Padding(0);
            btnRefrescarServicios.Name = "btnRefrescarServicios";
            btnRefrescarServicios.Size = new Size(40, 40);
            btnRefrescarServicios.TabIndex = 23;
            btnRefrescarServicios.UseVisualStyleBackColor = true;
            btnRefrescarServicios.Click += btnRefrescarServicios_Click;
            // 
            // btnEliminarServicio
            // 
            btnEliminarServicio.BackColor = Color.Peru;
            btnEliminarServicio.FlatAppearance.BorderSize = 0;
            btnEliminarServicio.FlatStyle = FlatStyle.Flat;
            btnEliminarServicio.Font = new Font("Segoe UI", 12F);
            btnEliminarServicio.ForeColor = Color.Moccasin;
            btnEliminarServicio.Location = new Point(677, 326);
            btnEliminarServicio.Margin = new Padding(0);
            btnEliminarServicio.Name = "btnEliminarServicio";
            btnEliminarServicio.Size = new Size(123, 36);
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
            btnEditarServicio.Location = new Point(550, 326);
            btnEditarServicio.Margin = new Padding(0);
            btnEditarServicio.Name = "btnEditarServicio";
            btnEditarServicio.Size = new Size(127, 36);
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
            btnNuevoServicio.Location = new Point(428, 326);
            btnNuevoServicio.Margin = new Padding(0);
            btnNuevoServicio.Name = "btnNuevoServicio";
            btnNuevoServicio.Size = new Size(122, 36);
            btnNuevoServicio.TabIndex = 3;
            btnNuevoServicio.Text = "Nuevo";
            btnNuevoServicio.UseVisualStyleBackColor = false;
            btnNuevoServicio.Click += btnNuevoServicio_Click;
            // 
            // ucServicioDatos1
            // 
            ucServicioDatos1.Location = new Point(428, -1);
            ucServicioDatos1.Margin = new Padding(3, 2, 3, 2);
            ucServicioDatos1.Name = "ucServicioDatos1";
            ucServicioDatos1.ServicioActual = null;
            ucServicioDatos1.Size = new Size(369, 325);
            ucServicioDatos1.TabIndex = 2;
            // 
            // flpServicios
            // 
            flpServicios.AutoScroll = true;
            flpServicios.Location = new Point(1, 35);
            flpServicios.Margin = new Padding(0);
            flpServicios.Name = "flpServicios";
            flpServicios.Size = new Size(427, 326);
            flpServicios.TabIndex = 1;
            // 
            // btnDatos
            // 
            btnDatos.BackColor = Color.FromArgb(255, 222, 171);
            btnDatos.FlatAppearance.BorderSize = 0;
            btnDatos.FlatStyle = FlatStyle.Flat;
            btnDatos.Font = new Font("Segoe UI", 12F);
            btnDatos.ForeColor = Color.FromArgb(95, 65, 0);
            btnDatos.Location = new Point(428, -2);
            btnDatos.Margin = new Padding(0);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(115, 36);
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
            btnReservar.Location = new Point(428, 325);
            btnReservar.Margin = new Padding(0);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(198, 35);
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
            btLista.Location = new Point(190, 0);
            btLista.Margin = new Padding(0);
            btLista.Name = "btLista";
            btLista.Size = new Size(192, 34);
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
            btnHistorial.Location = new Point(676, -2);
            btnHistorial.Margin = new Padding(0);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(120, 36);
            btnHistorial.TabIndex = 6;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // panelMapaLista
            // 
            panelMapaLista.Controls.Add(flpParcelas);
            panelMapaLista.Controls.Add(pbMapa);
            panelMapaLista.Location = new Point(1, 34);
            panelMapaLista.Margin = new Padding(0);
            panelMapaLista.Name = "panelMapaLista";
            panelMapaLista.Size = new Size(427, 325);
            panelMapaLista.TabIndex = 16;
            // 
            // flpParcelas
            // 
            flpParcelas.AutoScroll = true;
            flpParcelas.Dock = DockStyle.Fill;
            flpParcelas.Location = new Point(0, 0);
            flpParcelas.Margin = new Padding(0);
            flpParcelas.Name = "flpParcelas";
            flpParcelas.Size = new Size(427, 325);
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
            pbMapa.Size = new Size(427, 325);
            pbMapa.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMapa.TabIndex = 15;
            pbMapa.TabStop = false;
            pbMapa.DoubleClick += pbMapa_DoubleClick;
            // 
            // btnEstanciaActual
            // 
            btnEstanciaActual.BackColor = Color.FromArgb(255, 222, 171);
            btnEstanciaActual.FlatAppearance.BorderSize = 0;
            btnEstanciaActual.FlatStyle = FlatStyle.Flat;
            btnEstanciaActual.Font = new Font("Segoe UI", 12F);
            btnEstanciaActual.ForeColor = Color.FromArgb(95, 65, 0);
            btnEstanciaActual.Location = new Point(542, -2);
            btnEstanciaActual.Margin = new Padding(0);
            btnEstanciaActual.Name = "btnEstanciaActual";
            btnEstanciaActual.Size = new Size(135, 36);
            btnEstanciaActual.TabIndex = 5;
            btnEstanciaActual.Text = "Estancia actual";
            btnEstanciaActual.UseVisualStyleBackColor = false;
            btnEstanciaActual.Click += btnEstanciaActual_Click;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(ucParcelaDatos);
            panelDatos.Controls.Add(ucEstanciaActual1);
            panelDatos.Controls.Add(flpHistorial);
            panelDatos.Location = new Point(428, 34);
            panelDatos.Margin = new Padding(0);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(368, 291);
            panelDatos.TabIndex = 17;
            // 
            // ucParcelaDatos
            // 
            ucParcelaDatos.Location = new Point(0, 0);
            ucParcelaDatos.Margin = new Padding(0);
            ucParcelaDatos.Name = "ucParcelaDatos";
            ucParcelaDatos.Size = new Size(368, 291);
            ucParcelaDatos.TabIndex = 0;
            // 
            // ucEstanciaActual1
            // 
            ucEstanciaActual1.EstanciaActual = null;
            ucEstanciaActual1.Location = new Point(0, 0);
            ucEstanciaActual1.Margin = new Padding(3, 2, 3, 2);
            ucEstanciaActual1.Name = "ucEstanciaActual1";
            ucEstanciaActual1.Size = new Size(369, 291);
            ucEstanciaActual1.TabIndex = 21;
            // 
            // flpHistorial
            // 
            flpHistorial.Controls.Add(ucHistorial1);
            flpHistorial.Location = new Point(3, 2);
            flpHistorial.Margin = new Padding(3, 2, 3, 2);
            flpHistorial.Name = "flpHistorial";
            flpHistorial.Size = new Size(366, 286);
            flpHistorial.TabIndex = 22;
            // 
            // ucHistorial1
            // 
            ucHistorial1.Estancia = null;
            ucHistorial1.Location = new Point(3, 2);
            ucHistorial1.Margin = new Padding(3, 2, 3, 2);
            ucHistorial1.Name = "ucHistorial1";
            ucHistorial1.Size = new Size(351, 54);
            ucHistorial1.TabIndex = 0;
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
            btMapa.Size = new Size(189, 34);
            btMapa.TabIndex = 12;
            btMapa.Text = "Mapa";
            btMapa.UseVisualStyleBackColor = false;
            btMapa.Click += btMapa_Click;
            // 
            // pnlParcelas
            // 
            pnlParcelas.Controls.Add(btnRefrescarParcelas);
            pnlParcelas.Controls.Add(btLista);
            pnlParcelas.Controls.Add(btMapa);
            pnlParcelas.Controls.Add(panelMapaLista);
            pnlParcelas.Controls.Add(btnDatos);
            pnlParcelas.Controls.Add(btnEstanciaActual);
            pnlParcelas.Controls.Add(btnHistorial);
            pnlParcelas.Controls.Add(panelDatos);
            pnlParcelas.Controls.Add(btnReservar);
            pnlParcelas.Controls.Add(btnMantenimiento);
            pnlParcelas.Controls.Add(btnClientesEstancia);
            pnlParcelas.Controls.Add(btnServiciosEstancia);
            pnlParcelas.Location = new Point(0, 115);
            pnlParcelas.Margin = new Padding(3, 2, 3, 2);
            pnlParcelas.Name = "pnlParcelas";
            pnlParcelas.Size = new Size(799, 360);
            pnlParcelas.TabIndex = 18;
            // 
            // btnRefrescarParcelas
            // 
            btnRefrescarParcelas.FlatAppearance.BorderSize = 0;
            btnRefrescarParcelas.FlatStyle = FlatStyle.Flat;
            btnRefrescarParcelas.Font = new Font("Segoe UI", 20F);
            btnRefrescarParcelas.Image = Forms.Properties.Resources.refresh_arrow;
            btnRefrescarParcelas.Location = new Point(384, -6);
            btnRefrescarParcelas.Margin = new Padding(0);
            btnRefrescarParcelas.Name = "btnRefrescarParcelas";
            btnRefrescarParcelas.Size = new Size(41, 36);
            btnRefrescarParcelas.TabIndex = 22;
            btnRefrescarParcelas.UseVisualStyleBackColor = true;
            btnRefrescarParcelas.Click += btnRefrescarParcelas_Click;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.BackColor = Color.Peru;
            btnMantenimiento.FlatAppearance.BorderSize = 0;
            btnMantenimiento.FlatStyle = FlatStyle.Flat;
            btnMantenimiento.Font = new Font("Segoe UI", 12F);
            btnMantenimiento.ForeColor = Color.FromArgb(255, 222, 171);
            btnMantenimiento.Location = new Point(626, 325);
            btnMantenimiento.Margin = new Padding(0);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(174, 35);
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
            btnClientesEstancia.Location = new Point(428, 325);
            btnClientesEstancia.Margin = new Padding(0);
            btnClientesEstancia.Name = "btnClientesEstancia";
            btnClientesEstancia.Size = new Size(198, 34);
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
            btnServiciosEstancia.Location = new Point(626, 325);
            btnServiciosEstancia.Margin = new Padding(0);
            btnServiciosEstancia.Name = "btnServiciosEstancia";
            btnServiciosEstancia.Size = new Size(174, 35);
            btnServiciosEstancia.TabIndex = 21;
            btnServiciosEstancia.Text = "Servicios";
            btnServiciosEstancia.UseVisualStyleBackColor = false;
            btnServiciosEstancia.Click += btnServiciosEstancia_Click;
            // 
            // pnlEmpleados
            // 
            pnlEmpleados.Controls.Add(btnRefrescarEmpleados);
            pnlEmpleados.Controls.Add(btnEliminarEmpleado);
            pnlEmpleados.Controls.Add(btnEditarEmpleado);
            pnlEmpleados.Controls.Add(btnNuevoEmpleado);
            pnlEmpleados.Controls.Add(ucEmpleadoDatos1);
            pnlEmpleados.Controls.Add(flpEmpleados);
            pnlEmpleados.Location = new Point(1, 113);
            pnlEmpleados.Margin = new Padding(3, 2, 3, 2);
            pnlEmpleados.Name = "pnlEmpleados";
            pnlEmpleados.Size = new Size(799, 362);
            pnlEmpleados.TabIndex = 20;
            pnlEmpleados.Visible = false;
            // 
            // btnRefrescarEmpleados
            // 
            btnRefrescarEmpleados.FlatAppearance.BorderSize = 0;
            btnRefrescarEmpleados.FlatStyle = FlatStyle.Flat;
            btnRefrescarEmpleados.Font = new Font("Segoe UI", 20F);
            btnRefrescarEmpleados.Image = Forms.Properties.Resources.refresh_arrow;
            btnRefrescarEmpleados.Location = new Point(383, -6);
            btnRefrescarEmpleados.Margin = new Padding(0);
            btnRefrescarEmpleados.Name = "btnRefrescarEmpleados";
            btnRefrescarEmpleados.Size = new Size(44, 40);
            btnRefrescarEmpleados.TabIndex = 23;
            btnRefrescarEmpleados.UseVisualStyleBackColor = true;
            btnRefrescarEmpleados.Click += btnRefrescarEmpleados_Click;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.BackColor = Color.Peru;
            btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            btnEliminarEmpleado.FlatStyle = FlatStyle.Flat;
            btnEliminarEmpleado.Font = new Font("Segoe UI", 12F);
            btnEliminarEmpleado.ForeColor = Color.Moccasin;
            btnEliminarEmpleado.Location = new Point(676, 328);
            btnEliminarEmpleado.Margin = new Padding(0);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(122, 34);
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
            btnEditarEmpleado.Location = new Point(550, 328);
            btnEditarEmpleado.Margin = new Padding(0);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(127, 34);
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
            btnNuevoEmpleado.Location = new Point(427, 328);
            btnNuevoEmpleado.Margin = new Padding(0);
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.Size = new Size(123, 34);
            btnNuevoEmpleado.TabIndex = 2;
            btnNuevoEmpleado.Text = "Nuevo";
            btnNuevoEmpleado.UseVisualStyleBackColor = false;
            btnNuevoEmpleado.Click += btnNuevoEmpleado_Click;
            // 
            // ucEmpleadoDatos1
            // 
            ucEmpleadoDatos1.Location = new Point(427, 0);
            ucEmpleadoDatos1.Margin = new Padding(0);
            ucEmpleadoDatos1.Name = "ucEmpleadoDatos1";
            ucEmpleadoDatos1.Size = new Size(372, 328);
            ucEmpleadoDatos1.TabIndex = 1;
            // 
            // flpEmpleados
            // 
            flpEmpleados.AutoScroll = true;
            flpEmpleados.Location = new Point(0, 32);
            flpEmpleados.Margin = new Padding(0);
            flpEmpleados.Name = "flpEmpleados";
            flpEmpleados.Size = new Size(427, 328);
            flpEmpleados.TabIndex = 0;
            // 
            // btnEstancias
            // 
            btnEstancias.FlatAppearance.BorderSize = 0;
            btnEstancias.FlatStyle = FlatStyle.Flat;
            btnEstancias.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEstancias.ForeColor = Color.FromArgb(44, 79, 29);
            btnEstancias.Location = new Point(354, 37);
            btnEstancias.Name = "btnEstancias";
            btnEstancias.Size = new Size(118, 44);
            btnEstancias.TabIndex = 21;
            btnEstancias.Text = "Estancias";
            btnEstancias.UseVisualStyleBackColor = true;
            btnEstancias.Click += btnEstancias_Click;
            // 
            // pnlEstancias
            // 
            pnlEstancias.Controls.Add(btnEliminarEstancia);
            pnlEstancias.Controls.Add(btnEditarEstancia);
            pnlEstancias.Controls.Add(btnRefrescarEstancias);
            pnlEstancias.Controls.Add(ucEstanciaActual2);
            pnlEstancias.Controls.Add(flpEstancias);
            pnlEstancias.Location = new Point(1, 110);
            pnlEstancias.Margin = new Padding(3, 2, 3, 2);
            pnlEstancias.Name = "pnlEstancias";
            pnlEstancias.Size = new Size(799, 365);
            pnlEstancias.TabIndex = 22;
            pnlEstancias.Visible = false;
            // 
            // btnEliminarEstancia
            // 
            btnEliminarEstancia.BackColor = Color.Peru;
            btnEliminarEstancia.FlatAppearance.BorderSize = 0;
            btnEliminarEstancia.FlatStyle = FlatStyle.Flat;
            btnEliminarEstancia.Font = new Font("Segoe UI", 12F);
            btnEliminarEstancia.ForeColor = Color.Moccasin;
            btnEliminarEstancia.Location = new Point(605, 329);
            btnEliminarEstancia.Margin = new Padding(0);
            btnEliminarEstancia.Name = "btnEliminarEstancia";
            btnEliminarEstancia.Size = new Size(193, 36);
            btnEliminarEstancia.TabIndex = 7;
            btnEliminarEstancia.Text = "Eliminar";
            btnEliminarEstancia.UseVisualStyleBackColor = false;
            btnEliminarEstancia.Click += btnEliminarEstancia_Click;
            // 
            // btnEditarEstancia
            // 
            btnEditarEstancia.BackColor = Color.Peru;
            btnEditarEstancia.FlatAppearance.BorderSize = 0;
            btnEditarEstancia.FlatStyle = FlatStyle.Flat;
            btnEditarEstancia.Font = new Font("Segoe UI", 12F);
            btnEditarEstancia.ForeColor = Color.Moccasin;
            btnEditarEstancia.Location = new Point(426, 329);
            btnEditarEstancia.Margin = new Padding(0);
            btnEditarEstancia.Name = "btnEditarEstancia";
            btnEditarEstancia.Size = new Size(179, 36);
            btnEditarEstancia.TabIndex = 6;
            btnEditarEstancia.Text = "Editar";
            btnEditarEstancia.UseVisualStyleBackColor = false;
            btnEditarEstancia.Click += btnEditarEstancia_Click;
            // 
            // btnRefrescarEstancias
            // 
            btnRefrescarEstancias.FlatAppearance.BorderSize = 0;
            btnRefrescarEstancias.FlatStyle = FlatStyle.Flat;
            btnRefrescarEstancias.Font = new Font("Segoe UI", 20F);
            btnRefrescarEstancias.Image = Forms.Properties.Resources.refresh_arrow;
            btnRefrescarEstancias.Location = new Point(386, -2);
            btnRefrescarEstancias.Margin = new Padding(0);
            btnRefrescarEstancias.Name = "btnRefrescarEstancias";
            btnRefrescarEstancias.Size = new Size(41, 38);
            btnRefrescarEstancias.TabIndex = 2;
            btnRefrescarEstancias.UseVisualStyleBackColor = true;
            btnRefrescarEstancias.Click += btnRefrescarEstancias_Click;
            // 
            // ucEstanciaActual2
            // 
            ucEstanciaActual2.EstanciaActual = null;
            ucEstanciaActual2.Location = new Point(426, 38);
            ucEstanciaActual2.Margin = new Padding(3, 2, 3, 2);
            ucEstanciaActual2.Name = "ucEstanciaActual2";
            ucEstanciaActual2.Size = new Size(372, 292);
            ucEstanciaActual2.TabIndex = 1;
            // 
            // flpEstancias
            // 
            flpEstancias.AutoScroll = true;
            flpEstancias.Location = new Point(0, 38);
            flpEstancias.Margin = new Padding(0);
            flpEstancias.Name = "flpEstancias";
            flpEstancias.Size = new Size(427, 326);
            flpEstancias.TabIndex = 0;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClientes.ForeColor = Color.FromArgb(44, 79, 29);
            btnClientes.Location = new Point(478, 37);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(118, 44);
            btnClientes.TabIndex = 23;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // pnlClientes
            // 
            pnlClientes.Controls.Add(flpClientes);
            pnlClientes.Controls.Add(btnRefrescarClientes);
            pnlClientes.Controls.Add(ucClienteDatos1);
            pnlClientes.Controls.Add(btnNuevoCliente);
            pnlClientes.Controls.Add(btnEditarCliente);
            pnlClientes.Controls.Add(btnEliminarCliente);
            pnlClientes.Location = new Point(1, 113);
            pnlClientes.Margin = new Padding(3, 2, 3, 2);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(799, 362);
            pnlClientes.TabIndex = 24;
            pnlClientes.Visible = false;
            // 
            // flpClientes
            // 
            flpClientes.AutoScroll = true;
            flpClientes.Controls.Add(ucClientesLista1);
            flpClientes.Location = new Point(0, 32);
            flpClientes.Margin = new Padding(0);
            flpClientes.Name = "flpClientes";
            flpClientes.Size = new Size(427, 328);
            flpClientes.TabIndex = 0;
            // 
            // ucClientesLista1
            // 
            ucClientesLista1.Cliente = null;
            ucClientesLista1.Location = new Point(3, 2);
            ucClientesLista1.Margin = new Padding(3, 2, 3, 2);
            ucClientesLista1.Name = "ucClientesLista1";
            ucClientesLista1.Size = new Size(404, 61);
            ucClientesLista1.TabIndex = 0;
            // 
            // btnRefrescarClientes
            // 
            btnRefrescarClientes.FlatAppearance.BorderSize = 0;
            btnRefrescarClientes.FlatStyle = FlatStyle.Flat;
            btnRefrescarClientes.Font = new Font("Segoe UI", 20F);
            btnRefrescarClientes.Image = Forms.Properties.Resources.refresh_arrow;
            btnRefrescarClientes.Location = new Point(383, -6);
            btnRefrescarClientes.Margin = new Padding(0);
            btnRefrescarClientes.Name = "btnRefrescarClientes";
            btnRefrescarClientes.Size = new Size(44, 40);
            btnRefrescarClientes.TabIndex = 23;
            btnRefrescarClientes.UseVisualStyleBackColor = true;
            btnRefrescarClientes.Click += RefrescarClientes;
            // 
            // ucClienteDatos1
            // 
            ucClienteDatos1.Location = new Point(430, 2);
            ucClienteDatos1.Margin = new Padding(3, 2, 3, 2);
            ucClienteDatos1.Name = "ucClienteDatos1";
            ucClienteDatos1.Size = new Size(367, 323);
            ucClienteDatos1.TabIndex = 24;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.Peru;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Segoe UI", 12F);
            btnNuevoCliente.ForeColor = Color.Moccasin;
            btnNuevoCliente.Location = new Point(427, 328);
            btnNuevoCliente.Margin = new Padding(0);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(122, 34);
            btnNuevoCliente.TabIndex = 2;
            btnNuevoCliente.Text = "Nuevo";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.Peru;
            btnEditarCliente.FlatAppearance.BorderSize = 0;
            btnEditarCliente.FlatStyle = FlatStyle.Flat;
            btnEditarCliente.Font = new Font("Segoe UI", 12F);
            btnEditarCliente.ForeColor = Color.Moccasin;
            btnEditarCliente.Location = new Point(549, 328);
            btnEditarCliente.Margin = new Padding(0);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(127, 34);
            btnEditarCliente.TabIndex = 3;
            btnEditarCliente.Text = "Editar";
            btnEditarCliente.UseVisualStyleBackColor = false;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.Peru;
            btnEliminarCliente.FlatAppearance.BorderSize = 0;
            btnEliminarCliente.FlatStyle = FlatStyle.Flat;
            btnEliminarCliente.Font = new Font("Segoe UI", 12F);
            btnEliminarCliente.ForeColor = Color.Moccasin;
            btnEliminarCliente.Location = new Point(676, 328);
            btnEliminarCliente.Margin = new Padding(0);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(123, 34);
            btnEliminarCliente.TabIndex = 4;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.FromArgb(44, 79, 29);
            btnLogOut.Image = Forms.Properties.Resources.logout;
            btnLogOut.Location = new Point(738, 37);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(52, 44);
            btnLogOut.TabIndex = 25;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(197, 239, 100);
            pnlTop.Controls.Add(lblFechaHora);
            pnlTop.Controls.Add(btnMinimizar);
            pnlTop.Controls.Add(lblTitulo);
            pnlTop.Controls.Add(btnSalir);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 2, 3, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(799, 27);
            pnlTop.TabIndex = 26;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 8F);
            lblFechaHora.Location = new Point(354, 7);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 13);
            lblFechaHora.TabIndex = 10;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(728, 1);
            btnMinimizar.Margin = new Padding(3, 2, 3, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(28, 24);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(9, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(141, 15);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Campify - Panel principal";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(761, 1);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(38, 24);
            btnSalir.TabIndex = 7;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tmFechaHora
            // 
            tmFechaHora.Enabled = true;
            tmFechaHora.Interval = 1000;
            tmFechaHora.Tick += tmFechaHora_Tick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(799, 474);
            Controls.Add(pnlTop);
            Controls.Add(pnlEmpleados);
            Controls.Add(pnlClientes);
            Controls.Add(pnlEstancias);
            Controls.Add(pnlServicios);
            Controls.Add(pnlParcelas);
            Controls.Add(pbLogo);
            Controls.Add(btnParcelas);
            Controls.Add(btnServicios);
            Controls.Add(btnEmpleados);
            Controls.Add(btnEstancias);
            Controls.Add(btnClientes);
            Controls.Add(btnLogOut);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Campify";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlServicios.ResumeLayout(false);
            panelMapaLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMapa).EndInit();
            panelDatos.ResumeLayout(false);
            flpHistorial.ResumeLayout(false);
            pnlParcelas.ResumeLayout(false);
            pnlEmpleados.ResumeLayout(false);
            pnlEstancias.ResumeLayout(false);
            pnlClientes.ResumeLayout(false);
            flpClientes.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Button btnEmpleados;
        private Button btnParcelas;
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
        private Button btnRefrescarEstancias;
        private Button btnRefrescarParcelas;
        private Button btnRefrescarServicios;
        private Button btnRefrescarEmpleados;
        private Button btnEliminarEstancia;
        private Button btnEditarEstancia;
        private FlowLayoutPanel flpHistorial;
        private Controles.ucHistorial ucHistorial1;
        private Button btnClientes;
        private Panel pnlClientes;
        private Button btnRefrescarClientes;
        private Button btnEliminarCliente;
        private Button btnEditarCliente;
        private Button btnNuevoCliente;
        private FlowLayoutPanel flpClientes;
        private Controles.ucClientesLista ucClientesLista1;
        private Controles.ucClienteDatos ucClienteDatos1;
        private Button btnLogOut;
        private Panel pnlTop;
        private Button btnMinimizar;
        private Label lblTitulo;
        private Button btnSalir;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer tmFechaHora;
    }
}
