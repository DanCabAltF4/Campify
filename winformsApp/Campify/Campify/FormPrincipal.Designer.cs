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
            pnlMapaLista = new Panel();
            flpParcelas = new FlowLayoutPanel();
            pbMapa = new PictureBox();
            btnEstanciaActual = new Button();
            pnlDatos = new Panel();
            btnImagen = new Button();
            ucParcelaDatos = new Controles.ucParcelaDatos();
            ucEstanciaActual1 = new Controles.ucEstanciaActual();
            flpHistorial = new FlowLayoutPanel();
            ucHistorial1 = new Controles.ucHistorial();
            btnEliminarParcela = new Button();
            btnEditarParcela = new Button();
            btnNuevaParcela = new Button();
            btMapa = new Button();
            pnlParcelas = new Panel();
            btnFiltros = new Button();
            btnRefrescarParcelas = new Button();
            pnlFiltros = new Panel();
            ckFiltroPrecioMax = new CheckBox();
            nudFiltroPrecioMax = new NumericUpDown();
            btnFiltrar = new Button();
            nudFiltroPrecioMin = new NumericUpDown();
            ckFiltroTranquilo = new CheckBox();
            cbFiltroEstado = new ComboBox();
            ckFiltroEstado = new CheckBox();
            ckFiltroVistas = new CheckBox();
            ckFiltroPrecioMin = new CheckBox();
            ckFiltroSombra = new CheckBox();
            ckFiltroEntrada = new CheckBox();
            ckFiltroBaño = new CheckBox();
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
            lblCreditos = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlServicios.SuspendLayout();
            pnlMapaLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMapa).BeginInit();
            pnlDatos.SuspendLayout();
            flpHistorial.SuspendLayout();
            pnlParcelas.SuspendLayout();
            pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFiltroPrecioMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFiltroPrecioMin).BeginInit();
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
            pbLogo.Location = new Point(0, 36);
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
            btnEmpleados.Location = new Point(667, 59);
            btnEmpleados.Margin = new Padding(3, 4, 3, 4);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(135, 59);
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
            btnParcelas.Location = new Point(112, 59);
            btnParcelas.Margin = new Padding(3, 4, 3, 4);
            btnParcelas.Name = "btnParcelas";
            btnParcelas.Size = new Size(124, 59);
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
            btnServicios.Location = new Point(242, 59);
            btnServicios.Margin = new Padding(3, 4, 3, 4);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(135, 59);
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
            pnlServicios.Location = new Point(0, 151);
            pnlServicios.Name = "pnlServicios";
            pnlServicios.Size = new Size(913, 483);
            pnlServicios.TabIndex = 19;
            pnlServicios.Visible = false;
            // 
            // btnRefrescarServicios
            // 
            btnRefrescarServicios.FlatAppearance.BorderSize = 0;
            btnRefrescarServicios.FlatStyle = FlatStyle.Flat;
            btnRefrescarServicios.Font = new Font("Segoe UI", 20F);
            btnRefrescarServicios.Image = Forms.Properties.Resources.refresh_arrow;
            btnRefrescarServicios.Location = new Point(439, -5);
            btnRefrescarServicios.Margin = new Padding(0);
            btnRefrescarServicios.Name = "btnRefrescarServicios";
            btnRefrescarServicios.Size = new Size(46, 53);
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
            btnEliminarServicio.Location = new Point(774, 435);
            btnEliminarServicio.Margin = new Padding(0);
            btnEliminarServicio.Name = "btnEliminarServicio";
            btnEliminarServicio.Size = new Size(141, 48);
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
            btnEditarServicio.Size = new Size(145, 48);
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
            btnNuevoServicio.Size = new Size(141, 48);
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
            btnReservar.Size = new Size(226, 47);
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
            btLista.Location = new Point(201, 0);
            btLista.Margin = new Padding(0);
            btLista.Name = "btLista";
            btLista.Size = new Size(200, 45);
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
            btnHistorial.Click += btnHistorial_Click;
            // 
            // pnlMapaLista
            // 
            pnlMapaLista.Controls.Add(flpParcelas);
            pnlMapaLista.Controls.Add(pbMapa);
            pnlMapaLista.Location = new Point(1, 45);
            pnlMapaLista.Margin = new Padding(0);
            pnlMapaLista.Name = "pnlMapaLista";
            pnlMapaLista.Size = new Size(488, 433);
            pnlMapaLista.TabIndex = 16;
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
            pbMapa.DoubleClick += pbMapa_DoubleClick;
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
            // pnlDatos
            // 
            pnlDatos.Controls.Add(btnImagen);
            pnlDatos.Controls.Add(ucParcelaDatos);
            pnlDatos.Controls.Add(ucEstanciaActual1);
            pnlDatos.Controls.Add(flpHistorial);
            pnlDatos.Location = new Point(489, 45);
            pnlDatos.Margin = new Padding(0);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(421, 388);
            pnlDatos.TabIndex = 17;
            // 
            // btnImagen
            // 
            btnImagen.FlatAppearance.BorderSize = 0;
            btnImagen.FlatStyle = FlatStyle.Flat;
            btnImagen.Image = Forms.Properties.Resources.image;
            btnImagen.Location = new Point(50, 290);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(51, 38);
            btnImagen.TabIndex = 23;
            btnImagen.UseVisualStyleBackColor = true;
            btnImagen.Click += btnImagen_Click;
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
            // flpHistorial
            // 
            flpHistorial.Controls.Add(ucHistorial1);
            flpHistorial.Location = new Point(3, 3);
            flpHistorial.Name = "flpHistorial";
            flpHistorial.Size = new Size(418, 381);
            flpHistorial.TabIndex = 22;
            // 
            // ucHistorial1
            // 
            ucHistorial1.Estancia = null;
            ucHistorial1.Location = new Point(3, 3);
            ucHistorial1.Name = "ucHistorial1";
            ucHistorial1.Size = new Size(401, 72);
            ucHistorial1.TabIndex = 0;
            // 
            // btnEliminarParcela
            // 
            btnEliminarParcela.BackColor = Color.FromArgb(190, 130, 65);
            btnEliminarParcela.FlatAppearance.BorderSize = 0;
            btnEliminarParcela.FlatStyle = FlatStyle.Flat;
            btnEliminarParcela.Font = new Font("Segoe UI", 12F);
            btnEliminarParcela.ForeColor = Color.FromArgb(255, 222, 171);
            btnEliminarParcela.Location = new Point(772, 393);
            btnEliminarParcela.Margin = new Padding(0);
            btnEliminarParcela.Name = "btnEliminarParcela";
            btnEliminarParcela.Size = new Size(145, 40);
            btnEliminarParcela.TabIndex = 25;
            btnEliminarParcela.Text = "Eliminar";
            btnEliminarParcela.UseVisualStyleBackColor = false;
            btnEliminarParcela.Click += btnEliminarParcela_Click;
            // 
            // btnEditarParcela
            // 
            btnEditarParcela.BackColor = Color.FromArgb(190, 130, 65);
            btnEditarParcela.FlatAppearance.BorderSize = 0;
            btnEditarParcela.FlatStyle = FlatStyle.Flat;
            btnEditarParcela.Font = new Font("Segoe UI", 12F);
            btnEditarParcela.ForeColor = Color.FromArgb(255, 222, 171);
            btnEditarParcela.Location = new Point(633, 393);
            btnEditarParcela.Margin = new Padding(0);
            btnEditarParcela.Name = "btnEditarParcela";
            btnEditarParcela.Size = new Size(141, 40);
            btnEditarParcela.TabIndex = 24;
            btnEditarParcela.Text = "Editar";
            btnEditarParcela.UseVisualStyleBackColor = false;
            btnEditarParcela.Click += btnEditarParcela_Click;
            // 
            // btnNuevaParcela
            // 
            btnNuevaParcela.BackColor = Color.FromArgb(190, 130, 65);
            btnNuevaParcela.FlatAppearance.BorderSize = 0;
            btnNuevaParcela.FlatStyle = FlatStyle.Flat;
            btnNuevaParcela.Font = new Font("Segoe UI", 12F);
            btnNuevaParcela.ForeColor = Color.FromArgb(255, 222, 171);
            btnNuevaParcela.Location = new Point(489, 393);
            btnNuevaParcela.Margin = new Padding(0);
            btnNuevaParcela.Name = "btnNuevaParcela";
            btnNuevaParcela.Size = new Size(144, 40);
            btnNuevaParcela.TabIndex = 23;
            btnNuevaParcela.Text = "Nueva";
            btnNuevaParcela.UseVisualStyleBackColor = false;
            btnNuevaParcela.Click += btnNuevaParcela_Click;
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
            btMapa.Size = new Size(200, 45);
            btMapa.TabIndex = 12;
            btMapa.Text = "Mapa";
            btMapa.UseVisualStyleBackColor = false;
            btMapa.Click += btMapa_Click;
            // 
            // pnlParcelas
            // 
            pnlParcelas.Controls.Add(btnEditarParcela);
            pnlParcelas.Controls.Add(btnNuevaParcela);
            pnlParcelas.Controls.Add(btnEliminarParcela);
            pnlParcelas.Controls.Add(btMapa);
            pnlParcelas.Controls.Add(btLista);
            pnlParcelas.Controls.Add(btnFiltros);
            pnlParcelas.Controls.Add(btnRefrescarParcelas);
            pnlParcelas.Controls.Add(pnlMapaLista);
            pnlParcelas.Controls.Add(btnDatos);
            pnlParcelas.Controls.Add(btnEstanciaActual);
            pnlParcelas.Controls.Add(btnHistorial);
            pnlParcelas.Controls.Add(pnlFiltros);
            pnlParcelas.Controls.Add(pnlDatos);
            pnlParcelas.Controls.Add(btnReservar);
            pnlParcelas.Controls.Add(btnMantenimiento);
            pnlParcelas.Controls.Add(btnClientesEstancia);
            pnlParcelas.Controls.Add(btnServiciosEstancia);
            pnlParcelas.Location = new Point(0, 153);
            pnlParcelas.Name = "pnlParcelas";
            pnlParcelas.Size = new Size(913, 480);
            pnlParcelas.TabIndex = 18;
            // 
            // btnFiltros
            // 
            btnFiltros.FlatAppearance.BorderSize = 0;
            btnFiltros.FlatStyle = FlatStyle.Flat;
            btnFiltros.Font = new Font("Segoe UI", 20F);
            btnFiltros.Image = (Image)resources.GetObject("btnFiltros.Image");
            btnFiltros.Location = new Point(405, 4);
            btnFiltros.Margin = new Padding(0);
            btnFiltros.Name = "btnFiltros";
            btnFiltros.Size = new Size(37, 37);
            btnFiltros.TabIndex = 23;
            btnFiltros.UseVisualStyleBackColor = true;
            btnFiltros.Click += btnFiltros_Click;
            // 
            // btnRefrescarParcelas
            // 
            btnRefrescarParcelas.FlatAppearance.BorderSize = 0;
            btnRefrescarParcelas.FlatStyle = FlatStyle.Flat;
            btnRefrescarParcelas.Font = new Font("Segoe UI", 20F);
            btnRefrescarParcelas.Image = Forms.Properties.Resources.refresh_arrow;
            btnRefrescarParcelas.Location = new Point(445, 3);
            btnRefrescarParcelas.Margin = new Padding(0);
            btnRefrescarParcelas.Name = "btnRefrescarParcelas";
            btnRefrescarParcelas.Size = new Size(37, 37);
            btnRefrescarParcelas.TabIndex = 22;
            btnRefrescarParcelas.UseVisualStyleBackColor = true;
            btnRefrescarParcelas.Click += btnRefrescarParcelas_Click;
            // 
            // pnlFiltros
            // 
            pnlFiltros.Controls.Add(ckFiltroPrecioMax);
            pnlFiltros.Controls.Add(nudFiltroPrecioMax);
            pnlFiltros.Controls.Add(btnFiltrar);
            pnlFiltros.Controls.Add(nudFiltroPrecioMin);
            pnlFiltros.Controls.Add(ckFiltroTranquilo);
            pnlFiltros.Controls.Add(cbFiltroEstado);
            pnlFiltros.Controls.Add(ckFiltroEstado);
            pnlFiltros.Controls.Add(ckFiltroVistas);
            pnlFiltros.Controls.Add(ckFiltroPrecioMin);
            pnlFiltros.Controls.Add(ckFiltroSombra);
            pnlFiltros.Controls.Add(ckFiltroEntrada);
            pnlFiltros.Controls.Add(ckFiltroBaño);
            pnlFiltros.Location = new Point(488, 44);
            pnlFiltros.Margin = new Padding(0);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(421, 349);
            pnlFiltros.TabIndex = 28;
            pnlFiltros.Visible = false;
            // 
            // ckFiltroPrecioMax
            // 
            ckFiltroPrecioMax.AutoSize = true;
            ckFiltroPrecioMax.Location = new Point(324, 153);
            ckFiltroPrecioMax.Name = "ckFiltroPrecioMax";
            ckFiltroPrecioMax.Size = new Size(71, 24);
            ckFiltroPrecioMax.TabIndex = 12;
            ckFiltroPrecioMax.Text = "€ max";
            ckFiltroPrecioMax.UseVisualStyleBackColor = true;
            ckFiltroPrecioMax.CheckedChanged += ckFiltroPrecioMax_CheckedChanged;
            // 
            // nudFiltroPrecioMax
            // 
            nudFiltroPrecioMax.DecimalPlaces = 2;
            nudFiltroPrecioMax.Enabled = false;
            nudFiltroPrecioMax.Location = new Point(324, 192);
            nudFiltroPrecioMax.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudFiltroPrecioMax.Name = "nudFiltroPrecioMax";
            nudFiltroPrecioMax.Size = new Size(75, 27);
            nudFiltroPrecioMax.TabIndex = 11;
            nudFiltroPrecioMax.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(190, 130, 65);
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI", 10F);
            btnFiltrar.ForeColor = Color.FromArgb(255, 222, 171);
            btnFiltrar.Location = new Point(273, 284);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 10;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // nudFiltroPrecioMin
            // 
            nudFiltroPrecioMin.DecimalPlaces = 2;
            nudFiltroPrecioMin.Enabled = false;
            nudFiltroPrecioMin.Location = new Point(227, 192);
            nudFiltroPrecioMin.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudFiltroPrecioMin.Name = "nudFiltroPrecioMin";
            nudFiltroPrecioMin.Size = new Size(75, 27);
            nudFiltroPrecioMin.TabIndex = 9;
            nudFiltroPrecioMin.TextAlign = HorizontalAlignment.Right;
            // 
            // ckFiltroTranquilo
            // 
            ckFiltroTranquilo.AutoSize = true;
            ckFiltroTranquilo.Location = new Point(23, 291);
            ckFiltroTranquilo.Name = "ckFiltroTranquilo";
            ckFiltroTranquilo.Size = new Size(128, 24);
            ckFiltroTranquilo.TabIndex = 8;
            ckFiltroTranquilo.Text = "Zona tranquila";
            ckFiltroTranquilo.UseVisualStyleBackColor = true;
            // 
            // cbFiltroEstado
            // 
            cbFiltroEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltroEstado.Enabled = false;
            cbFiltroEstado.FormattingEnabled = true;
            cbFiltroEstado.Location = new Point(227, 59);
            cbFiltroEstado.Name = "cbFiltroEstado";
            cbFiltroEstado.Size = new Size(172, 28);
            cbFiltroEstado.TabIndex = 7;
            // 
            // ckFiltroEstado
            // 
            ckFiltroEstado.AutoSize = true;
            ckFiltroEstado.Location = new Point(227, 25);
            ckFiltroEstado.Name = "ckFiltroEstado";
            ckFiltroEstado.Size = new Size(150, 24);
            ckFiltroEstado.TabIndex = 6;
            ckFiltroEstado.Text = "Estado de parcela";
            ckFiltroEstado.UseVisualStyleBackColor = true;
            ckFiltroEstado.CheckedChanged += ckFiltroEstado_CheckedChanged;
            // 
            // ckFiltroVistas
            // 
            ckFiltroVistas.AutoSize = true;
            ckFiltroVistas.Location = new Point(23, 95);
            ckFiltroVistas.Name = "ckFiltroVistas";
            ckFiltroVistas.Size = new Size(107, 24);
            ckFiltroVistas.TabIndex = 5;
            ckFiltroVistas.Text = "Tiene vistas";
            ckFiltroVistas.UseVisualStyleBackColor = true;
            // 
            // ckFiltroPrecioMin
            // 
            ckFiltroPrecioMin.AutoSize = true;
            ckFiltroPrecioMin.Location = new Point(227, 153);
            ckFiltroPrecioMin.Name = "ckFiltroPrecioMin";
            ckFiltroPrecioMin.Size = new Size(68, 24);
            ckFiltroPrecioMin.TabIndex = 4;
            ckFiltroPrecioMin.Text = "€ min";
            ckFiltroPrecioMin.UseVisualStyleBackColor = true;
            ckFiltroPrecioMin.CheckedChanged += ckFiltroPrecio_CheckedChanged;
            // 
            // ckFiltroSombra
            // 
            ckFiltroSombra.AutoSize = true;
            ckFiltroSombra.Location = new Point(23, 162);
            ckFiltroSombra.Name = "ckFiltroSombra";
            ckFiltroSombra.Size = new Size(140, 24);
            ckFiltroSombra.TabIndex = 3;
            ckFiltroSombra.Text = "Zona de sombra";
            ckFiltroSombra.UseVisualStyleBackColor = true;
            // 
            // ckFiltroEntrada
            // 
            ckFiltroEntrada.AutoSize = true;
            ckFiltroEntrada.Location = new Point(23, 228);
            ckFiltroEntrada.Name = "ckFiltroEntrada";
            ckFiltroEntrada.Size = new Size(144, 24);
            ckFiltroEntrada.TabIndex = 2;
            ckFiltroEntrada.Text = "Cerca de entrada";
            ckFiltroEntrada.UseVisualStyleBackColor = true;
            // 
            // ckFiltroBaño
            // 
            ckFiltroBaño.AutoSize = true;
            ckFiltroBaño.Location = new Point(23, 25);
            ckFiltroBaño.Name = "ckFiltroBaño";
            ckFiltroBaño.Size = new Size(104, 24);
            ckFiltroBaño.TabIndex = 1;
            ckFiltroBaño.Text = "Baño cerca";
            ckFiltroBaño.UseVisualStyleBackColor = true;
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
            btnMantenimiento.Size = new Size(196, 47);
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
            btnServiciosEstancia.Size = new Size(199, 47);
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
            pnlEmpleados.Location = new Point(1, 151);
            pnlEmpleados.Name = "pnlEmpleados";
            pnlEmpleados.Size = new Size(913, 483);
            pnlEmpleados.TabIndex = 20;
            pnlEmpleados.Visible = false;
            // 
            // btnRefrescarEmpleados
            // 
            btnRefrescarEmpleados.FlatAppearance.BorderSize = 0;
            btnRefrescarEmpleados.FlatStyle = FlatStyle.Flat;
            btnRefrescarEmpleados.Font = new Font("Segoe UI", 20F);
            btnRefrescarEmpleados.Image = Forms.Properties.Resources.refresh_arrow;
            btnRefrescarEmpleados.Location = new Point(438, -1);
            btnRefrescarEmpleados.Margin = new Padding(0);
            btnRefrescarEmpleados.Name = "btnRefrescarEmpleados";
            btnRefrescarEmpleados.Size = new Size(32, 34);
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
            btnEliminarEmpleado.Location = new Point(773, 437);
            btnEliminarEmpleado.Margin = new Padding(0);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(139, 45);
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
            btnEditarEmpleado.Location = new Point(629, 437);
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
            btnNuevoEmpleado.Size = new Size(141, 45);
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
            flpEmpleados.Location = new Point(0, 43);
            flpEmpleados.Margin = new Padding(0);
            flpEmpleados.Name = "flpEmpleados";
            flpEmpleados.Size = new Size(488, 437);
            flpEmpleados.TabIndex = 0;
            // 
            // btnEstancias
            // 
            btnEstancias.FlatAppearance.BorderSize = 0;
            btnEstancias.FlatStyle = FlatStyle.Flat;
            btnEstancias.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEstancias.ForeColor = Color.FromArgb(44, 79, 29);
            btnEstancias.Location = new Point(384, 59);
            btnEstancias.Margin = new Padding(3, 4, 3, 4);
            btnEstancias.Name = "btnEstancias";
            btnEstancias.Size = new Size(135, 59);
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
            pnlEstancias.Location = new Point(1, 147);
            pnlEstancias.Name = "pnlEstancias";
            pnlEstancias.Size = new Size(913, 487);
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
            btnEliminarEstancia.Location = new Point(691, 439);
            btnEliminarEstancia.Margin = new Padding(0);
            btnEliminarEstancia.Name = "btnEliminarEstancia";
            btnEliminarEstancia.Size = new Size(221, 48);
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
            btnEditarEstancia.Location = new Point(487, 439);
            btnEditarEstancia.Margin = new Padding(0);
            btnEditarEstancia.Name = "btnEditarEstancia";
            btnEditarEstancia.Size = new Size(205, 48);
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
            btnRefrescarEstancias.Location = new Point(441, -3);
            btnRefrescarEstancias.Margin = new Padding(0);
            btnRefrescarEstancias.Name = "btnRefrescarEstancias";
            btnRefrescarEstancias.Size = new Size(47, 51);
            btnRefrescarEstancias.TabIndex = 2;
            btnRefrescarEstancias.UseVisualStyleBackColor = true;
            btnRefrescarEstancias.Click += btnRefrescarEstancias_Click;
            // 
            // ucEstanciaActual2
            // 
            ucEstanciaActual2.EstanciaActual = null;
            ucEstanciaActual2.Location = new Point(487, 51);
            ucEstanciaActual2.Name = "ucEstanciaActual2";
            ucEstanciaActual2.Size = new Size(425, 389);
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
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClientes.ForeColor = Color.FromArgb(44, 79, 29);
            btnClientes.Location = new Point(525, 59);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(135, 59);
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
            pnlClientes.Location = new Point(1, 151);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(913, 483);
            pnlClientes.TabIndex = 24;
            pnlClientes.Visible = false;
            // 
            // flpClientes
            // 
            flpClientes.AutoScroll = true;
            flpClientes.Controls.Add(ucClientesLista1);
            flpClientes.Location = new Point(0, 43);
            flpClientes.Margin = new Padding(0);
            flpClientes.Name = "flpClientes";
            flpClientes.Size = new Size(488, 437);
            flpClientes.TabIndex = 0;
            // 
            // ucClientesLista1
            // 
            ucClientesLista1.Cliente = null;
            ucClientesLista1.Location = new Point(3, 3);
            ucClientesLista1.Name = "ucClientesLista1";
            ucClientesLista1.Size = new Size(462, 81);
            ucClientesLista1.TabIndex = 0;
            // 
            // btnRefrescarClientes
            // 
            btnRefrescarClientes.FlatAppearance.BorderSize = 0;
            btnRefrescarClientes.FlatStyle = FlatStyle.Flat;
            btnRefrescarClientes.Font = new Font("Segoe UI", 20F);
            btnRefrescarClientes.Image = Forms.Properties.Resources.refresh_arrow;
            btnRefrescarClientes.Location = new Point(438, -8);
            btnRefrescarClientes.Margin = new Padding(0);
            btnRefrescarClientes.Name = "btnRefrescarClientes";
            btnRefrescarClientes.Size = new Size(50, 53);
            btnRefrescarClientes.TabIndex = 23;
            btnRefrescarClientes.UseVisualStyleBackColor = true;
            btnRefrescarClientes.Click += RefrescarClientes;
            // 
            // ucClienteDatos1
            // 
            ucClienteDatos1.Location = new Point(491, 3);
            ucClienteDatos1.Name = "ucClienteDatos1";
            ucClienteDatos1.Size = new Size(419, 431);
            ucClienteDatos1.TabIndex = 24;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.Peru;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Segoe UI", 12F);
            btnNuevoCliente.ForeColor = Color.Moccasin;
            btnNuevoCliente.Location = new Point(488, 437);
            btnNuevoCliente.Margin = new Padding(0);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(139, 45);
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
            btnEditarCliente.Location = new Point(627, 437);
            btnEditarCliente.Margin = new Padding(0);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(147, 45);
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
            btnEliminarCliente.Location = new Point(773, 437);
            btnEliminarCliente.Margin = new Padding(0);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(141, 45);
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
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.TopCenter;
            btnLogOut.Location = new Point(824, 36);
            btnLogOut.Margin = new Padding(0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(87, 82);
            btnLogOut.TabIndex = 25;
            btnLogOut.TextAlign = ContentAlignment.BottomCenter;
            btnLogOut.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogOut.UseVisualStyleBackColor = false;
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
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(910, 36);
            pnlTop.TabIndex = 26;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 8F);
            lblFechaHora.Location = new Point(405, 9);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 19);
            lblFechaHora.TabIndex = 10;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(832, 1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 32);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(175, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Campify - Panel principal";
            lblTitulo.MouseDown += pnlTop_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(870, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(43, 32);
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
            // lblCreditos
            // 
            lblCreditos.Location = new Point(4, 39);
            lblCreditos.Name = "lblCreditos";
            lblCreditos.Size = new Size(16, 15);
            lblCreditos.TabIndex = 27;
            lblCreditos.DoubleClick += lblCreditos_DoubleClick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 239, 170);
            ClientSize = new Size(910, 632);
            Controls.Add(pnlTop);
            Controls.Add(lblCreditos);
            Controls.Add(pnlParcelas);
            Controls.Add(pnlEmpleados);
            Controls.Add(pnlClientes);
            Controls.Add(pnlEstancias);
            Controls.Add(pnlServicios);
            Controls.Add(pbLogo);
            Controls.Add(btnParcelas);
            Controls.Add(btnServicios);
            Controls.Add(btnEmpleados);
            Controls.Add(btnEstancias);
            Controls.Add(btnClientes);
            Controls.Add(btnLogOut);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Campify";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlServicios.ResumeLayout(false);
            pnlMapaLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMapa).EndInit();
            pnlDatos.ResumeLayout(false);
            flpHistorial.ResumeLayout(false);
            pnlParcelas.ResumeLayout(false);
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFiltroPrecioMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFiltroPrecioMin).EndInit();
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
        private Panel pnlMapaLista;
        private FlowLayoutPanel flpParcelas;
        private PictureBox pbMapa;
        private Button btnEstanciaActual;
        private Panel pnlDatos;
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
        private Button btnImagen;
        private Button btnNuevaParcela;
        private Button btnEliminarParcela;
        private Button btnEditarParcela;
        private Label lblCreditos;
        private Button btnFiltros;
        private Panel pnlFiltros;
        private CheckBox ckFiltroBaño;
        private CheckBox ckFiltroEstado;
        private CheckBox ckFiltroVistas;
        private CheckBox ckFiltroPrecioMin;
        private CheckBox ckFiltroSombra;
        private CheckBox ckFiltroEntrada;
        private Button btnFiltrar;
        private NumericUpDown nudFiltroPrecioMin;
        private CheckBox ckFiltroTranquilo;
        private ComboBox cbFiltroEstado;
        private NumericUpDown nudFiltroPrecioMax;
        private CheckBox ckFiltroPrecioMax;
    }
}
