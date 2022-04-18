
namespace IntegraJeff
{
    partial class FrmCruceEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtAnotaciones = new System.Windows.Forms.TextBox();
            this.txtIdConductores = new System.Windows.Forms.TextBox();
            this.txtIdUnidades = new System.Windows.Forms.TextBox();
            this.txtHorasDemora = new System.Windows.Forms.TextBox();
            this.txtDemora = new System.Windows.Forms.TextBox();
            this.txtIdIntermediarios = new System.Windows.Forms.TextBox();
            this.txtPrecioDolares = new System.Windows.Forms.TextBox();
            this.txtPrecioPesos = new System.Windows.Forms.TextBox();
            this.txtLugarDescarga = new System.Windows.Forms.TextBox();
            this.txtLugarCarga = new System.Windows.Forms.TextBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCarga = new System.Windows.Forms.DateTimePicker();
            this.txtIdRemisiones = new System.Windows.Forms.TextBox();
            this.txtIdCajas = new System.Windows.Forms.TextBox();
            this.txtIdClientes = new System.Windows.Forms.TextBox();
            this.txtTipoServicio = new System.Windows.Forms.TextBox();
            this.txtIdCruces = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblAnotaciones = new System.Windows.Forms.Label();
            this.lblIdConductores = new System.Windows.Forms.Label();
            this.lblIdUnidades = new System.Windows.Forms.Label();
            this.lblHorasDemora = new System.Windows.Forms.Label();
            this.lblDemora = new System.Windows.Forms.Label();
            this.chkEstatusCobro = new System.Windows.Forms.CheckBox();
            this.chkAsignada = new System.Windows.Forms.CheckBox();
            this.lblIdIntermediarios = new System.Windows.Forms.Label();
            this.lblPrecioDolares = new System.Windows.Forms.Label();
            this.lblPrecioPesos = new System.Windows.Forms.Label();
            this.lblLugarDescarga = new System.Windows.Forms.Label();
            this.lblLugarCarga = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblFechaCarga = new System.Windows.Forms.Label();
            this.lblIdRemisionesyFacturas = new System.Windows.Forms.Label();
            this.lblIdCajas = new System.Windows.Forms.Label();
            this.lblIdClientes = new System.Windows.Forms.Label();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.lblIdCruces = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionarConductor = new System.Windows.Forms.Button();
            this.btnSeleccionarUnidad = new System.Windows.Forms.Button();
            this.btnSeleccionarIntermediario = new System.Windows.Forms.Button();
            this.btnSeleccionarCaja = new System.Windows.Forms.Button();
            this.btnSeleccionarFactura = new System.Windows.Forms.Button();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(988, 162);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(133, 20);
            this.txtReferencia.TabIndex = 40;
            // 
            // txtAnotaciones
            // 
            this.txtAnotaciones.Location = new System.Drawing.Point(988, 131);
            this.txtAnotaciones.Name = "txtAnotaciones";
            this.txtAnotaciones.Size = new System.Drawing.Size(133, 20);
            this.txtAnotaciones.TabIndex = 26;
            // 
            // txtIdConductores
            // 
            this.txtIdConductores.Location = new System.Drawing.Point(988, 94);
            this.txtIdConductores.Name = "txtIdConductores";
            this.txtIdConductores.Size = new System.Drawing.Size(133, 20);
            this.txtIdConductores.TabIndex = 27;
            this.txtIdConductores.Text = "0";
            this.txtIdConductores.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtIdConductores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntAllow);
            // 
            // txtIdUnidades
            // 
            this.txtIdUnidades.Location = new System.Drawing.Point(988, 63);
            this.txtIdUnidades.Name = "txtIdUnidades";
            this.txtIdUnidades.Size = new System.Drawing.Size(133, 20);
            this.txtIdUnidades.TabIndex = 28;
            this.txtIdUnidades.Text = "0";
            this.txtIdUnidades.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtIdUnidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntAllow);
            // 
            // txtHorasDemora
            // 
            this.txtHorasDemora.Location = new System.Drawing.Point(988, 29);
            this.txtHorasDemora.Name = "txtHorasDemora";
            this.txtHorasDemora.Size = new System.Drawing.Size(133, 20);
            this.txtHorasDemora.TabIndex = 29;
            this.txtHorasDemora.Text = "0";
            this.txtHorasDemora.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtHorasDemora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntAllow);
            // 
            // txtDemora
            // 
            this.txtDemora.Location = new System.Drawing.Point(716, 165);
            this.txtDemora.Name = "txtDemora";
            this.txtDemora.Size = new System.Drawing.Size(153, 20);
            this.txtDemora.TabIndex = 33;
            // 
            // txtIdIntermediarios
            // 
            this.txtIdIntermediarios.Location = new System.Drawing.Point(716, 97);
            this.txtIdIntermediarios.Name = "txtIdIntermediarios";
            this.txtIdIntermediarios.Size = new System.Drawing.Size(153, 20);
            this.txtIdIntermediarios.TabIndex = 31;
            this.txtIdIntermediarios.Text = "0";
            this.txtIdIntermediarios.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtIdIntermediarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntAllow);
            // 
            // txtPrecioDolares
            // 
            this.txtPrecioDolares.Location = new System.Drawing.Point(716, 63);
            this.txtPrecioDolares.Name = "txtPrecioDolares";
            this.txtPrecioDolares.Size = new System.Drawing.Size(153, 20);
            this.txtPrecioDolares.TabIndex = 32;
            this.txtPrecioDolares.Text = "0";
            this.txtPrecioDolares.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtPrecioDolares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalAllow);
            // 
            // txtPrecioPesos
            // 
            this.txtPrecioPesos.Location = new System.Drawing.Point(716, 29);
            this.txtPrecioPesos.Name = "txtPrecioPesos";
            this.txtPrecioPesos.Size = new System.Drawing.Size(153, 20);
            this.txtPrecioPesos.TabIndex = 39;
            this.txtPrecioPesos.Text = "0";
            this.txtPrecioPesos.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtPrecioPesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalAllow);
            // 
            // txtLugarDescarga
            // 
            this.txtLugarDescarga.Location = new System.Drawing.Point(425, 165);
            this.txtLugarDescarga.Name = "txtLugarDescarga";
            this.txtLugarDescarga.Size = new System.Drawing.Size(200, 20);
            this.txtLugarDescarga.TabIndex = 34;
            // 
            // txtLugarCarga
            // 
            this.txtLugarCarga.Location = new System.Drawing.Point(425, 131);
            this.txtLugarCarga.Name = "txtLugarCarga";
            this.txtLugarCarga.Size = new System.Drawing.Size(200, 20);
            this.txtLugarCarga.TabIndex = 35;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(425, 97);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEntrega.TabIndex = 36;
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Location = new System.Drawing.Point(425, 63);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCarga.TabIndex = 37;
            // 
            // txtIdRemisiones
            // 
            this.txtIdRemisiones.Location = new System.Drawing.Point(135, 165);
            this.txtIdRemisiones.Name = "txtIdRemisiones";
            this.txtIdRemisiones.Size = new System.Drawing.Size(153, 20);
            this.txtIdRemisiones.TabIndex = 38;
            this.txtIdRemisiones.Text = "0";
            this.txtIdRemisiones.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtIdRemisiones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntAllow);
            // 
            // txtIdCajas
            // 
            this.txtIdCajas.Location = new System.Drawing.Point(135, 131);
            this.txtIdCajas.Name = "txtIdCajas";
            this.txtIdCajas.Size = new System.Drawing.Size(153, 20);
            this.txtIdCajas.TabIndex = 25;
            this.txtIdCajas.Text = "0";
            this.txtIdCajas.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtIdCajas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntAllow);
            // 
            // txtIdClientes
            // 
            this.txtIdClientes.Location = new System.Drawing.Point(135, 97);
            this.txtIdClientes.Name = "txtIdClientes";
            this.txtIdClientes.Size = new System.Drawing.Size(153, 20);
            this.txtIdClientes.TabIndex = 30;
            this.txtIdClientes.Text = "0";
            this.txtIdClientes.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtIdClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntAllow);
            // 
            // txtTipoServicio
            // 
            this.txtTipoServicio.Location = new System.Drawing.Point(135, 63);
            this.txtTipoServicio.Name = "txtTipoServicio";
            this.txtTipoServicio.Size = new System.Drawing.Size(153, 20);
            this.txtTipoServicio.TabIndex = 23;
            // 
            // txtIdCruces
            // 
            this.txtIdCruces.Enabled = false;
            this.txtIdCruces.Location = new System.Drawing.Point(135, 29);
            this.txtIdCruces.Name = "txtIdCruces";
            this.txtIdCruces.Size = new System.Drawing.Size(153, 20);
            this.txtIdCruces.TabIndex = 22;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(923, 165);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(59, 13);
            this.lblReferencia.TabIndex = 24;
            this.lblReferencia.Text = "Referencia";
            // 
            // lblAnotaciones
            // 
            this.lblAnotaciones.AutoSize = true;
            this.lblAnotaciones.Location = new System.Drawing.Point(916, 134);
            this.lblAnotaciones.Name = "lblAnotaciones";
            this.lblAnotaciones.Size = new System.Drawing.Size(66, 13);
            this.lblAnotaciones.TabIndex = 20;
            this.lblAnotaciones.Text = "Anotaciones";
            // 
            // lblIdConductores
            // 
            this.lblIdConductores.AutoSize = true;
            this.lblIdConductores.Location = new System.Drawing.Point(903, 97);
            this.lblIdConductores.Name = "lblIdConductores";
            this.lblIdConductores.Size = new System.Drawing.Size(79, 13);
            this.lblIdConductores.TabIndex = 19;
            this.lblIdConductores.Text = "Id Conductores";
            // 
            // lblIdUnidades
            // 
            this.lblIdUnidades.AutoSize = true;
            this.lblIdUnidades.Location = new System.Drawing.Point(918, 63);
            this.lblIdUnidades.Name = "lblIdUnidades";
            this.lblIdUnidades.Size = new System.Drawing.Size(64, 13);
            this.lblIdUnidades.TabIndex = 18;
            this.lblIdUnidades.Text = "Id Unidades";
            // 
            // lblHorasDemora
            // 
            this.lblHorasDemora.AutoSize = true;
            this.lblHorasDemora.Location = new System.Drawing.Point(892, 29);
            this.lblHorasDemora.Name = "lblHorasDemora";
            this.lblHorasDemora.Size = new System.Drawing.Size(90, 13);
            this.lblHorasDemora.TabIndex = 46;
            this.lblHorasDemora.Text = "Horas de Demora";
            // 
            // lblDemora
            // 
            this.lblDemora.AutoSize = true;
            this.lblDemora.Location = new System.Drawing.Point(666, 168);
            this.lblDemora.Name = "lblDemora";
            this.lblDemora.Size = new System.Drawing.Size(44, 13);
            this.lblDemora.TabIndex = 17;
            this.lblDemora.Text = "Demora";
            // 
            // chkEstatusCobro
            // 
            this.chkEstatusCobro.AutoSize = true;
            this.chkEstatusCobro.Location = new System.Drawing.Point(312, 31);
            this.chkEstatusCobro.Name = "chkEstatusCobro";
            this.chkEstatusCobro.Size = new System.Drawing.Size(107, 17);
            this.chkEstatusCobro.TabIndex = 16;
            this.chkEstatusCobro.Text = "Estatus de Cobro";
            this.chkEstatusCobro.UseVisualStyleBackColor = true;
            // 
            // chkAsignada
            // 
            this.chkAsignada.AutoSize = true;
            this.chkAsignada.Location = new System.Drawing.Point(640, 133);
            this.chkAsignada.Name = "chkAsignada";
            this.chkAsignada.Size = new System.Drawing.Size(70, 17);
            this.chkAsignada.TabIndex = 15;
            this.chkAsignada.Text = "Asignada";
            this.chkAsignada.UseVisualStyleBackColor = true;
            // 
            // lblIdIntermediarios
            // 
            this.lblIdIntermediarios.AutoSize = true;
            this.lblIdIntermediarios.Location = new System.Drawing.Point(626, 100);
            this.lblIdIntermediarios.Name = "lblIdIntermediarios";
            this.lblIdIntermediarios.Size = new System.Drawing.Size(84, 13);
            this.lblIdIntermediarios.TabIndex = 14;
            this.lblIdIntermediarios.Text = "Id Intermediarios";
            // 
            // lblPrecioDolares
            // 
            this.lblPrecioDolares.AutoSize = true;
            this.lblPrecioDolares.Location = new System.Drawing.Point(628, 66);
            this.lblPrecioDolares.Name = "lblPrecioDolares";
            this.lblPrecioDolares.Size = new System.Drawing.Size(82, 13);
            this.lblPrecioDolares.TabIndex = 13;
            this.lblPrecioDolares.Text = "Precio (Dolares)";
            // 
            // lblPrecioPesos
            // 
            this.lblPrecioPesos.AutoSize = true;
            this.lblPrecioPesos.Location = new System.Drawing.Point(635, 32);
            this.lblPrecioPesos.Name = "lblPrecioPesos";
            this.lblPrecioPesos.Size = new System.Drawing.Size(75, 13);
            this.lblPrecioPesos.TabIndex = 12;
            this.lblPrecioPesos.Text = "Precio (Pesos)";
            // 
            // lblLugarDescarga
            // 
            this.lblLugarDescarga.AutoSize = true;
            this.lblLugarDescarga.Location = new System.Drawing.Point(321, 168);
            this.lblLugarDescarga.Name = "lblLugarDescarga";
            this.lblLugarDescarga.Size = new System.Drawing.Size(98, 13);
            this.lblLugarDescarga.TabIndex = 45;
            this.lblLugarDescarga.Text = "Lugar de Descarga";
            // 
            // lblLugarCarga
            // 
            this.lblLugarCarga.AutoSize = true;
            this.lblLugarCarga.Location = new System.Drawing.Point(339, 134);
            this.lblLugarCarga.Name = "lblLugarCarga";
            this.lblLugarCarga.Size = new System.Drawing.Size(80, 13);
            this.lblLugarCarga.TabIndex = 11;
            this.lblLugarCarga.Text = "Lugar de Carga";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(327, 100);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(92, 13);
            this.lblFechaEntrega.TabIndex = 10;
            this.lblFechaEntrega.Text = "Fecha de Entrega";
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Location = new System.Drawing.Point(336, 66);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(83, 13);
            this.lblFechaCarga.TabIndex = 44;
            this.lblFechaCarga.Text = "Fecha de Carga";
            // 
            // lblIdRemisionesyFacturas
            // 
            this.lblIdRemisionesyFacturas.AutoSize = true;
            this.lblIdRemisionesyFacturas.Location = new System.Drawing.Point(10, 168);
            this.lblIdRemisionesyFacturas.Name = "lblIdRemisionesyFacturas";
            this.lblIdRemisionesyFacturas.Size = new System.Drawing.Size(119, 13);
            this.lblIdRemisionesyFacturas.TabIndex = 43;
            this.lblIdRemisionesyFacturas.Text = "Id RemisionesyFacturas";
            // 
            // lblIdCajas
            // 
            this.lblIdCajas.AutoSize = true;
            this.lblIdCajas.Location = new System.Drawing.Point(84, 134);
            this.lblIdCajas.Name = "lblIdCajas";
            this.lblIdCajas.Size = new System.Drawing.Size(45, 13);
            this.lblIdCajas.TabIndex = 42;
            this.lblIdCajas.Text = "Id Cajas";
            // 
            // lblIdClientes
            // 
            this.lblIdClientes.AutoSize = true;
            this.lblIdClientes.Location = new System.Drawing.Point(73, 100);
            this.lblIdClientes.Name = "lblIdClientes";
            this.lblIdClientes.Size = new System.Drawing.Size(56, 13);
            this.lblIdClientes.TabIndex = 41;
            this.lblIdClientes.Text = "Id Clientes";
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Location = new System.Drawing.Point(45, 66);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(84, 13);
            this.lblTipoServicio.TabIndex = 21;
            this.lblTipoServicio.Text = "Tipo de Servicio";
            // 
            // lblIdCruces
            // 
            this.lblIdCruces.AutoSize = true;
            this.lblIdCruces.Location = new System.Drawing.Point(77, 32);
            this.lblIdCruces.Name = "lblIdCruces";
            this.lblIdCruces.Size = new System.Drawing.Size(52, 13);
            this.lblIdCruces.TabIndex = 9;
            this.lblIdCruces.Text = "Id Cruces";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(328, 221);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(455, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionarConductor
            // 
            this.btnSeleccionarConductor.Location = new System.Drawing.Point(1127, 93);
            this.btnSeleccionarConductor.Name = "btnSeleccionarConductor";
            this.btnSeleccionarConductor.Size = new System.Drawing.Size(24, 24);
            this.btnSeleccionarConductor.TabIndex = 55;
            this.btnSeleccionarConductor.Text = ".";
            this.btnSeleccionarConductor.UseVisualStyleBackColor = true;
            this.btnSeleccionarConductor.Click += new System.EventHandler(this.btnSeleccionarConductor_Click);
            // 
            // btnSeleccionarUnidad
            // 
            this.btnSeleccionarUnidad.Location = new System.Drawing.Point(1127, 60);
            this.btnSeleccionarUnidad.Name = "btnSeleccionarUnidad";
            this.btnSeleccionarUnidad.Size = new System.Drawing.Size(24, 24);
            this.btnSeleccionarUnidad.TabIndex = 56;
            this.btnSeleccionarUnidad.Text = ".";
            this.btnSeleccionarUnidad.UseVisualStyleBackColor = true;
            this.btnSeleccionarUnidad.Click += new System.EventHandler(this.btnSeleccionarUnidad_Click);
            // 
            // btnSeleccionarIntermediario
            // 
            this.btnSeleccionarIntermediario.Location = new System.Drawing.Point(873, 94);
            this.btnSeleccionarIntermediario.Name = "btnSeleccionarIntermediario";
            this.btnSeleccionarIntermediario.Size = new System.Drawing.Size(24, 24);
            this.btnSeleccionarIntermediario.TabIndex = 57;
            this.btnSeleccionarIntermediario.Text = ".";
            this.btnSeleccionarIntermediario.UseVisualStyleBackColor = true;
            this.btnSeleccionarIntermediario.Click += new System.EventHandler(this.btnSeleccionarIntermediario_Click);
            // 
            // btnSeleccionarCaja
            // 
            this.btnSeleccionarCaja.Location = new System.Drawing.Point(294, 131);
            this.btnSeleccionarCaja.Name = "btnSeleccionarCaja";
            this.btnSeleccionarCaja.Size = new System.Drawing.Size(24, 24);
            this.btnSeleccionarCaja.TabIndex = 58;
            this.btnSeleccionarCaja.Text = ".";
            this.btnSeleccionarCaja.UseVisualStyleBackColor = true;
            this.btnSeleccionarCaja.Click += new System.EventHandler(this.btnSeleccionarCaja_Click);
            // 
            // btnSeleccionarFactura
            // 
            this.btnSeleccionarFactura.Location = new System.Drawing.Point(294, 162);
            this.btnSeleccionarFactura.Name = "btnSeleccionarFactura";
            this.btnSeleccionarFactura.Size = new System.Drawing.Size(24, 24);
            this.btnSeleccionarFactura.TabIndex = 59;
            this.btnSeleccionarFactura.Text = ".";
            this.btnSeleccionarFactura.UseVisualStyleBackColor = true;
            this.btnSeleccionarFactura.Click += new System.EventHandler(this.btnSeleccionarFactura_Click);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(294, 91);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(24, 24);
            this.btnSeleccionarCliente.TabIndex = 60;
            this.btnSeleccionarCliente.Text = ".";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // FrmCruceEditar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1174, 272);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.btnSeleccionarFactura);
            this.Controls.Add(this.btnSeleccionarCaja);
            this.Controls.Add(this.btnSeleccionarIntermediario);
            this.Controls.Add(this.btnSeleccionarUnidad);
            this.Controls.Add(this.btnSeleccionarConductor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.txtAnotaciones);
            this.Controls.Add(this.txtIdConductores);
            this.Controls.Add(this.txtIdUnidades);
            this.Controls.Add(this.txtHorasDemora);
            this.Controls.Add(this.txtDemora);
            this.Controls.Add(this.txtIdIntermediarios);
            this.Controls.Add(this.txtPrecioDolares);
            this.Controls.Add(this.txtPrecioPesos);
            this.Controls.Add(this.txtLugarDescarga);
            this.Controls.Add(this.txtLugarCarga);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.dtpFechaCarga);
            this.Controls.Add(this.txtIdRemisiones);
            this.Controls.Add(this.txtIdCajas);
            this.Controls.Add(this.txtIdClientes);
            this.Controls.Add(this.txtTipoServicio);
            this.Controls.Add(this.txtIdCruces);
            this.Controls.Add(this.lblReferencia);
            this.Controls.Add(this.lblAnotaciones);
            this.Controls.Add(this.lblIdConductores);
            this.Controls.Add(this.lblIdUnidades);
            this.Controls.Add(this.lblHorasDemora);
            this.Controls.Add(this.lblDemora);
            this.Controls.Add(this.chkEstatusCobro);
            this.Controls.Add(this.chkAsignada);
            this.Controls.Add(this.lblIdIntermediarios);
            this.Controls.Add(this.lblPrecioDolares);
            this.Controls.Add(this.lblPrecioPesos);
            this.Controls.Add(this.lblLugarDescarga);
            this.Controls.Add(this.lblLugarCarga);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.lblFechaCarga);
            this.Controls.Add(this.lblIdRemisionesyFacturas);
            this.Controls.Add(this.lblIdCajas);
            this.Controls.Add(this.lblIdClientes);
            this.Controls.Add(this.lblTipoServicio);
            this.Controls.Add(this.lblIdCruces);
            this.Name = "FrmCruceEditar";
            this.Text = "FrmCruceEditar";
            this.Load += new System.EventHandler(this.FrmCruceEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtAnotaciones;
        private System.Windows.Forms.TextBox txtIdConductores;
        private System.Windows.Forms.TextBox txtIdUnidades;
        private System.Windows.Forms.TextBox txtHorasDemora;
        private System.Windows.Forms.TextBox txtDemora;
        private System.Windows.Forms.TextBox txtIdIntermediarios;
        private System.Windows.Forms.TextBox txtPrecioDolares;
        private System.Windows.Forms.TextBox txtPrecioPesos;
        private System.Windows.Forms.TextBox txtLugarDescarga;
        private System.Windows.Forms.TextBox txtLugarCarga;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaCarga;
        private System.Windows.Forms.TextBox txtIdRemisiones;
        private System.Windows.Forms.TextBox txtIdCajas;
        private System.Windows.Forms.TextBox txtIdClientes;
        private System.Windows.Forms.TextBox txtTipoServicio;
        private System.Windows.Forms.TextBox txtIdCruces;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblAnotaciones;
        private System.Windows.Forms.Label lblIdConductores;
        private System.Windows.Forms.Label lblIdUnidades;
        private System.Windows.Forms.Label lblHorasDemora;
        private System.Windows.Forms.Label lblDemora;
        private System.Windows.Forms.CheckBox chkEstatusCobro;
        private System.Windows.Forms.CheckBox chkAsignada;
        private System.Windows.Forms.Label lblIdIntermediarios;
        private System.Windows.Forms.Label lblPrecioDolares;
        private System.Windows.Forms.Label lblPrecioPesos;
        private System.Windows.Forms.Label lblLugarDescarga;
        private System.Windows.Forms.Label lblLugarCarga;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblFechaCarga;
        private System.Windows.Forms.Label lblIdRemisionesyFacturas;
        private System.Windows.Forms.Label lblIdCajas;
        private System.Windows.Forms.Label lblIdClientes;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.Label lblIdCruces;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionarConductor;
        private System.Windows.Forms.Button btnSeleccionarUnidad;
        private System.Windows.Forms.Button btnSeleccionarIntermediario;
        private System.Windows.Forms.Button btnSeleccionarCaja;
        private System.Windows.Forms.Button btnSeleccionarFactura;
        private System.Windows.Forms.Button btnSeleccionarCliente;
    }
}