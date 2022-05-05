
namespace IntegraJeff
{
    partial class FrmFacturaAgregar
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
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIdRemisionesYFacturas = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtSubtotalPesos = new System.Windows.Forms.TextBox();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.txtTotalPesos = new System.Windows.Forms.TextBox();
            this.txtRetencion = new System.Windows.Forms.TextBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.chkEstatusCobro = new System.Windows.Forms.CheckBox();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblTotalPesos = new System.Windows.Forms.Label();
            this.lblRetencion = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubTotalPesos = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.lblDolares = new System.Windows.Forms.Label();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblIdRemisionesyFacturas = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Location = new System.Drawing.Point(156, 143);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFactura.TabIndex = 49;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(156, 102);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroFactura.TabIndex = 48;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(156, 62);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 47;
            // 
            // txtIdRemisionesYFacturas
            // 
            this.txtIdRemisionesYFacturas.Enabled = false;
            this.txtIdRemisionesYFacturas.Location = new System.Drawing.Point(156, 20);
            this.txtIdRemisionesYFacturas.Name = "txtIdRemisionesYFacturas";
            this.txtIdRemisionesYFacturas.Size = new System.Drawing.Size(100, 20);
            this.txtIdRemisionesYFacturas.TabIndex = 46;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(156, 297);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 20);
            this.txtIva.TabIndex = 45;
            this.txtIva.Text = "0";
            this.txtIva.TextChanged += new System.EventHandler(this.txtIva_TextChanged);
            this.txtIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIva_KeyPress);
            // 
            // txtSubtotalPesos
            // 
            this.txtSubtotalPesos.Location = new System.Drawing.Point(156, 258);
            this.txtSubtotalPesos.Name = "txtSubtotalPesos";
            this.txtSubtotalPesos.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalPesos.TabIndex = 44;
            this.txtSubtotalPesos.Text = "0";
            this.txtSubtotalPesos.TextChanged += new System.EventHandler(this.txtSubtotalPesos_TextChanged);
            this.txtSubtotalPesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubtotalPesos_KeyPress);
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(156, 217);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCambio.TabIndex = 43;
            this.txtTipoCambio.Text = "0";
            this.txtTipoCambio.TextChanged += new System.EventHandler(this.txtTipoCambio_TextChanged);
            this.txtTipoCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoCambio_KeyPress);
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(156, 178);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(100, 20);
            this.txtDolares.TabIndex = 42;
            this.txtDolares.Text = "0";
            this.txtDolares.TextChanged += new System.EventHandler(this.txtDolares_TextChanged);
            this.txtDolares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolares_KeyPress);
            // 
            // txtTotalPesos
            // 
            this.txtTotalPesos.Location = new System.Drawing.Point(528, 62);
            this.txtTotalPesos.Name = "txtTotalPesos";
            this.txtTotalPesos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPesos.TabIndex = 41;
            this.txtTotalPesos.Text = "0";
            this.txtTotalPesos.TextChanged += new System.EventHandler(this.txtTotalPesos_TextChanged);
            this.txtTotalPesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPesos_KeyPress);
            // 
            // txtRetencion
            // 
            this.txtRetencion.Location = new System.Drawing.Point(528, 19);
            this.txtRetencion.Name = "txtRetencion";
            this.txtRetencion.Size = new System.Drawing.Size(100, 20);
            this.txtRetencion.TabIndex = 40;
            this.txtRetencion.Text = "0";
            this.txtRetencion.TextChanged += new System.EventHandler(this.txtRetencion_TextChanged);
            this.txtRetencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetencion_KeyPress);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(528, 135);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVencimiento.TabIndex = 39;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(528, 96);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 38;
            // 
            // chkEstatusCobro
            // 
            this.chkEstatusCobro.AutoSize = true;
            this.chkEstatusCobro.Location = new System.Drawing.Point(469, 174);
            this.chkEstatusCobro.Name = "chkEstatusCobro";
            this.chkEstatusCobro.Size = new System.Drawing.Size(107, 17);
            this.chkEstatusCobro.TabIndex = 37;
            this.chkEstatusCobro.Text = "Estatus de Cobro";
            this.chkEstatusCobro.UseVisualStyleBackColor = true;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(410, 141);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(112, 13);
            this.lblFechaVencimiento.TabIndex = 36;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(442, 101);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 35;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblTotalPesos
            // 
            this.lblTotalPesos.AutoSize = true;
            this.lblTotalPesos.Location = new System.Drawing.Point(444, 61);
            this.lblTotalPesos.Name = "lblTotalPesos";
            this.lblTotalPesos.Size = new System.Drawing.Size(78, 13);
            this.lblTotalPesos.TabIndex = 34;
            this.lblTotalPesos.Text = "Total en Pesos";
            // 
            // lblRetencion
            // 
            this.lblRetencion.AutoSize = true;
            this.lblRetencion.Location = new System.Drawing.Point(466, 21);
            this.lblRetencion.Name = "lblRetencion";
            this.lblRetencion.Size = new System.Drawing.Size(56, 13);
            this.lblRetencion.TabIndex = 33;
            this.lblRetencion.Text = "Retencion";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(125, 298);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(24, 13);
            this.lblIva.TabIndex = 32;
            this.lblIva.Text = "IVA";
            // 
            // lblSubTotalPesos
            // 
            this.lblSubTotalPesos.AutoSize = true;
            this.lblSubTotalPesos.Location = new System.Drawing.Point(71, 258);
            this.lblSubTotalPesos.Name = "lblSubTotalPesos";
            this.lblSubTotalPesos.Size = new System.Drawing.Size(78, 13);
            this.lblSubTotalPesos.TabIndex = 31;
            this.lblSubTotalPesos.Text = "Subtotal Pesos";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Location = new System.Drawing.Point(68, 218);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(81, 13);
            this.lblTipoCambio.TabIndex = 30;
            this.lblTipoCambio.Text = "Tipo de Cambio";
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Location = new System.Drawing.Point(106, 178);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(43, 13);
            this.lblDolares.TabIndex = 29;
            this.lblDolares.Text = "Dolares";
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.Location = new System.Drawing.Point(58, 143);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(91, 13);
            this.lblFechaFactura.TabIndex = 28;
            this.lblFechaFactura.Text = "Fecha de Factura";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(51, 103);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(98, 13);
            this.lblNumero.TabIndex = 27;
            this.lblNumero.Text = "Numero de Factura";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(53, 63);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(96, 13);
            this.lblNombreCliente.TabIndex = 26;
            this.lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // lblIdRemisionesyFacturas
            // 
            this.lblIdRemisionesyFacturas.AutoSize = true;
            this.lblIdRemisionesyFacturas.Location = new System.Drawing.Point(19, 23);
            this.lblIdRemisionesyFacturas.Name = "lblIdRemisionesyFacturas";
            this.lblIdRemisionesyFacturas.Size = new System.Drawing.Size(130, 13);
            this.lblIdRemisionesyFacturas.TabIndex = 25;
            this.lblIdRemisionesyFacturas.Text = "id - Remisiones y Facturas";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(234, 347);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 50;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(339, 347);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(262, 62);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(32, 23);
            this.btnSeleccionarCliente.TabIndex = 52;
            this.btnSeleccionarCliente.Text = "...";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // FrmFacturaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(752, 395);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtpFechaFactura);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIdRemisionesYFacturas);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtSubtotalPesos);
            this.Controls.Add(this.txtTipoCambio);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.txtTotalPesos);
            this.Controls.Add(this.txtRetencion);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.chkEstatusCobro);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblFechaPago);
            this.Controls.Add(this.lblTotalPesos);
            this.Controls.Add(this.lblRetencion);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblSubTotalPesos);
            this.Controls.Add(this.lblTipoCambio);
            this.Controls.Add(this.lblDolares);
            this.Controls.Add(this.lblFechaFactura);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblIdRemisionesyFacturas);
            this.Name = "FrmFacturaAgregar";
            this.Text = "FrmFacturaAgregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIdRemisionesYFacturas;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtSubtotalPesos;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.TextBox txtTotalPesos;
        private System.Windows.Forms.TextBox txtRetencion;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.CheckBox chkEstatusCobro;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblTotalPesos;
        private System.Windows.Forms.Label lblRetencion;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubTotalPesos;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblIdRemisionesyFacturas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionarCliente;
    }
}