
namespace IntegraJeff
{
    partial class FrmMantenimientosBuscar
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
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.dtpFechaReparacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReparacion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtMecanico = new System.Windows.Forms.TextBox();
            this.lblMecanico = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtIdUnidad = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtIdMantenimiento = new System.Windows.Forms.TextBox();
            this.lblIdMantenimiento = new System.Windows.Forms.Label();
            this.lblNumeroUnidad = new System.Windows.Forms.Label();
            this.txtNumeroUnidad = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(384, 131);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(220, 20);
            this.dtpFechaPago.TabIndex = 27;
            this.dtpFechaPago.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(262, 134);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 26;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // dtpFechaReparacion
            // 
            this.dtpFechaReparacion.Location = new System.Drawing.Point(384, 82);
            this.dtpFechaReparacion.Name = "dtpFechaReparacion";
            this.dtpFechaReparacion.Size = new System.Drawing.Size(220, 20);
            this.dtpFechaReparacion.TabIndex = 25;
            this.dtpFechaReparacion.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblFechaReparacion
            // 
            this.lblFechaReparacion.AutoSize = true;
            this.lblFechaReparacion.Location = new System.Drawing.Point(262, 85);
            this.lblFechaReparacion.Name = "lblFechaReparacion";
            this.lblFechaReparacion.Size = new System.Drawing.Size(116, 13);
            this.lblFechaReparacion.TabIndex = 24;
            this.lblFechaReparacion.Text = "Fecha de Reaparacion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(328, 37);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 23;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(259, 40);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtMecanico
            // 
            this.txtMecanico.Location = new System.Drawing.Point(116, 186);
            this.txtMecanico.Name = "txtMecanico";
            this.txtMecanico.Size = new System.Drawing.Size(100, 20);
            this.txtMecanico.TabIndex = 21;
            // 
            // lblMecanico
            // 
            this.lblMecanico.AutoSize = true;
            this.lblMecanico.Location = new System.Drawing.Point(58, 189);
            this.lblMecanico.Name = "lblMecanico";
            this.lblMecanico.Size = new System.Drawing.Size(54, 13);
            this.lblMecanico.TabIndex = 20;
            this.lblMecanico.Text = "Mecanico";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(116, 135);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 19;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(75, 138);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 18;
            this.lblCosto.Text = "Costo";
            // 
            // txtIdUnidad
            // 
            this.txtIdUnidad.Location = new System.Drawing.Point(116, 85);
            this.txtIdUnidad.Name = "txtIdUnidad";
            this.txtIdUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtIdUnidad.TabIndex = 17;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(58, 88);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(52, 13);
            this.lblUnidad.TabIndex = 16;
            this.lblUnidad.Text = "id Unidad";
            // 
            // txtIdMantenimiento
            // 
            this.txtIdMantenimiento.Location = new System.Drawing.Point(116, 37);
            this.txtIdMantenimiento.Name = "txtIdMantenimiento";
            this.txtIdMantenimiento.Size = new System.Drawing.Size(100, 20);
            this.txtIdMantenimiento.TabIndex = 15;
            // 
            // lblIdMantenimiento
            // 
            this.lblIdMantenimiento.AutoSize = true;
            this.lblIdMantenimiento.Location = new System.Drawing.Point(22, 40);
            this.lblIdMantenimiento.Name = "lblIdMantenimiento";
            this.lblIdMantenimiento.Size = new System.Drawing.Size(88, 13);
            this.lblIdMantenimiento.TabIndex = 14;
            this.lblIdMantenimiento.Text = "Id Mantenimiento";
            // 
            // lblNumeroUnidad
            // 
            this.lblNumeroUnidad.AutoSize = true;
            this.lblNumeroUnidad.Location = new System.Drawing.Point(265, 188);
            this.lblNumeroUnidad.Name = "lblNumeroUnidad";
            this.lblNumeroUnidad.Size = new System.Drawing.Size(96, 13);
            this.lblNumeroUnidad.TabIndex = 28;
            this.lblNumeroUnidad.Text = "Numero de Unidad";
            // 
            // txtNumeroUnidad
            // 
            this.txtNumeroUnidad.Location = new System.Drawing.Point(384, 185);
            this.txtNumeroUnidad.Name = "txtNumeroUnidad";
            this.txtNumeroUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroUnidad.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(188, 243);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(312, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmMantenimientosBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 295);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumeroUnidad);
            this.Controls.Add(this.lblNumeroUnidad);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.lblFechaPago);
            this.Controls.Add(this.dtpFechaReparacion);
            this.Controls.Add(this.lblFechaReparacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtMecanico);
            this.Controls.Add(this.lblMecanico);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtIdUnidad);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtIdMantenimiento);
            this.Controls.Add(this.lblIdMantenimiento);
            this.Name = "FrmMantenimientosBuscar";
            this.Text = "FrmMantenimientosBuscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.DateTimePicker dtpFechaReparacion;
        private System.Windows.Forms.Label lblFechaReparacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtMecanico;
        private System.Windows.Forms.Label lblMecanico;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtIdUnidad;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtIdMantenimiento;
        private System.Windows.Forms.Label lblIdMantenimiento;
        private System.Windows.Forms.Label lblNumeroUnidad;
        private System.Windows.Forms.TextBox txtNumeroUnidad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
    }
}