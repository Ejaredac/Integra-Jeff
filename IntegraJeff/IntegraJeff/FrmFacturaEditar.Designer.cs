
namespace IntegraJeff
{
    partial class FrmFacturaEditar
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Location = new System.Drawing.Point(156, 144);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFactura.TabIndex = 74;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(156, 103);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroFactura.TabIndex = 73;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(156, 63);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 72;
            // 
            // txtIdRemisionesYFacturas
            // 
            this.txtIdRemisionesYFacturas.Enabled = false;
            this.txtIdRemisionesYFacturas.Location = new System.Drawing.Point(156, 21);
            this.txtIdRemisionesYFacturas.Name = "txtIdRemisionesYFacturas";
            this.txtIdRemisionesYFacturas.Size = new System.Drawing.Size(100, 20);
            this.txtIdRemisionesYFacturas.TabIndex = 71;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(156, 298);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 20);
            this.txtIva.TabIndex = 70;
            this.txtIva.Text = "0";
            this.txtIva.TextChanged += new System.EventHandler(this.txtIva_TextChanged);
            this.txtIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIva_KeyPress);
            // 
            // txtSubtotalPesos
            // 
            this.txtSubtotalPesos.Location = new System.Drawing.Point(156, 259);
            this.txtSubtotalPesos.Name = "txtSubtotalPesos";
            this.txtSubtotalPesos.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalPesos.TabIndex = 69;
            this.txtSubtotalPesos.Text = "0";
            this.txtSubtotalPesos.TextChanged += new System.EventHandler(this.txtSubtotalPesos_TextChanged);
            this.txtSubtotalPesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubtotalPesos_KeyPress);
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(156, 218);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCambio.TabIndex = 68;
            this.txtTipoCambio.Text = "0";
            this.txtTipoCambio.TextChanged += new System.EventHandler(this.txtTipoCambio_TextChanged);
            this.txtTipoCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoCambio_KeyPress);
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(156, 179);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(100, 20);
            this.txtDolares.TabIndex = 67;
            this.txtDolares.Text = "0";
            this.txtDolares.TextChanged += new System.EventHandler(this.txtDolares_TextChanged);
            this.txtDolares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolares_KeyPress);
            // 
            // txtTotalPesos
            // 
            this.txtTotalPesos.Location = new System.Drawing.Point(528, 63);
            this.txtTotalPesos.Name = "txtTotalPesos";
            this.txtTotalPesos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPesos.TabIndex = 66;
            this.txtTotalPesos.Text = "0";
            this.txtTotalPesos.TextChanged += new System.EventHandler(this.txtTotalPesos_TextChanged);
            this.txtTotalPesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPesos_KeyPress);
            // 
            // txtRetencion
            // 
            this.txtRetencion.Location = new System.Drawing.Point(528, 20);
            this.txtRetencion.Name = "txtRetencion";
            this.txtRetencion.Size = new System.Drawing.Size(100, 20);
            this.txtRetencion.TabIndex = 65;
            this.txtRetencion.Text = "0";
            this.txtRetencion.TextChanged += new System.EventHandler(this.txtRetencion_TextChanged);
            this.txtRetencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetencion_KeyPress);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(528, 136);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVencimiento.TabIndex = 64;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(528, 97);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 63;
            // 
            // chkEstatusCobro
            // 
            this.chkEstatusCobro.AutoSize = true;
            this.chkEstatusCobro.Location = new System.Drawing.Point(469, 175);
            this.chkEstatusCobro.Name = "chkEstatusCobro";
            this.chkEstatusCobro.Size = new System.Drawing.Size(107, 17);
            this.chkEstatusCobro.TabIndex = 62;
            this.chkEstatusCobro.Text = "Estatus de Cobro";
            this.chkEstatusCobro.UseVisualStyleBackColor = true;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(410, 142);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(112, 13);
            this.lblFechaVencimiento.TabIndex = 61;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(442, 102);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 60;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblTotalPesos
            // 
            this.lblTotalPesos.AutoSize = true;
            this.lblTotalPesos.Location = new System.Drawing.Point(444, 62);
            this.lblTotalPesos.Name = "lblTotalPesos";
            this.lblTotalPesos.Size = new System.Drawing.Size(78, 13);
            this.lblTotalPesos.TabIndex = 59;
            this.lblTotalPesos.Text = "Total en Pesos";
            // 
            // lblRetencion
            // 
            this.lblRetencion.AutoSize = true;
            this.lblRetencion.Location = new System.Drawing.Point(466, 22);
            this.lblRetencion.Name = "lblRetencion";
            this.lblRetencion.Size = new System.Drawing.Size(56, 13);
            this.lblRetencion.TabIndex = 58;
            this.lblRetencion.Text = "Retencion";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(125, 299);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(24, 13);
            this.lblIva.TabIndex = 57;
            this.lblIva.Text = "IVA";
            // 
            // lblSubTotalPesos
            // 
            this.lblSubTotalPesos.AutoSize = true;
            this.lblSubTotalPesos.Location = new System.Drawing.Point(71, 259);
            this.lblSubTotalPesos.Name = "lblSubTotalPesos";
            this.lblSubTotalPesos.Size = new System.Drawing.Size(78, 13);
            this.lblSubTotalPesos.TabIndex = 56;
            this.lblSubTotalPesos.Text = "Subtotal Pesos";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Location = new System.Drawing.Point(68, 219);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(81, 13);
            this.lblTipoCambio.TabIndex = 55;
            this.lblTipoCambio.Text = "Tipo de Cambio";
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Location = new System.Drawing.Point(106, 179);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(43, 13);
            this.lblDolares.TabIndex = 54;
            this.lblDolares.Text = "Dolares";
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.Location = new System.Drawing.Point(58, 144);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(91, 13);
            this.lblFechaFactura.TabIndex = 53;
            this.lblFechaFactura.Text = "Fecha de Factura";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(51, 104);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(98, 13);
            this.lblNumero.TabIndex = 52;
            this.lblNumero.Text = "Numero de Factura";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(53, 64);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(96, 13);
            this.lblNombreCliente.TabIndex = 51;
            this.lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // lblIdRemisionesyFacturas
            // 
            this.lblIdRemisionesyFacturas.AutoSize = true;
            this.lblIdRemisionesyFacturas.Location = new System.Drawing.Point(19, 24);
            this.lblIdRemisionesyFacturas.Name = "lblIdRemisionesyFacturas";
            this.lblIdRemisionesyFacturas.Size = new System.Drawing.Size(130, 13);
            this.lblIdRemisionesyFacturas.TabIndex = 50;
            this.lblIdRemisionesyFacturas.Text = "id - Remisiones y Facturas";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(270, 342);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 75;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(393, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(263, 59);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(31, 23);
            this.btnSeleccionarCliente.TabIndex = 77;
            this.btnSeleccionarCliente.Text = "...";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // FrmFacturaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 382);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
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
            this.Name = "FrmFacturaEditar";
            this.Text = "FrmFacturaEditar";
            this.Load += new System.EventHandler(this.FrmFacturaEditar_Load);
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionarCliente;
    }
}