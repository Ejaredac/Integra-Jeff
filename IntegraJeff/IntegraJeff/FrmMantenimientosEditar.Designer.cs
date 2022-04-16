
namespace IntegraJeff
{
    partial class FrmMantenimientosEditar
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
            this.btnSeleccionarUnidad = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(416, 134);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(220, 20);
            this.dtpFechaPago.TabIndex = 27;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(294, 137);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 26;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // dtpFechaReparacion
            // 
            this.dtpFechaReparacion.Location = new System.Drawing.Point(416, 85);
            this.dtpFechaReparacion.Name = "dtpFechaReparacion";
            this.dtpFechaReparacion.Size = new System.Drawing.Size(220, 20);
            this.dtpFechaReparacion.TabIndex = 25;
            // 
            // lblFechaReparacion
            // 
            this.lblFechaReparacion.AutoSize = true;
            this.lblFechaReparacion.Location = new System.Drawing.Point(294, 88);
            this.lblFechaReparacion.Name = "lblFechaReparacion";
            this.lblFechaReparacion.Size = new System.Drawing.Size(116, 13);
            this.lblFechaReparacion.TabIndex = 24;
            this.lblFechaReparacion.Text = "Fecha de Reaparacion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(360, 40);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 23;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(291, 43);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtMecanico
            // 
            this.txtMecanico.Location = new System.Drawing.Point(109, 186);
            this.txtMecanico.Name = "txtMecanico";
            this.txtMecanico.Size = new System.Drawing.Size(100, 20);
            this.txtMecanico.TabIndex = 21;
            // 
            // lblMecanico
            // 
            this.lblMecanico.AutoSize = true;
            this.lblMecanico.Location = new System.Drawing.Point(51, 189);
            this.lblMecanico.Name = "lblMecanico";
            this.lblMecanico.Size = new System.Drawing.Size(54, 13);
            this.lblMecanico.TabIndex = 20;
            this.lblMecanico.Text = "Mecanico";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(109, 135);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 19;
            this.txtCosto.Text = "0.00";
            this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(68, 138);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 18;
            this.lblCosto.Text = "Costo";
            // 
            // txtIdUnidad
            // 
            this.txtIdUnidad.Location = new System.Drawing.Point(109, 85);
            this.txtIdUnidad.Name = "txtIdUnidad";
            this.txtIdUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtIdUnidad.TabIndex = 17;
            this.txtIdUnidad.Text = "0";
            this.txtIdUnidad.TextChanged += new System.EventHandler(this.txtIdUnidad_TextChanged);
            this.txtIdUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdUnidad_KeyPress);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(51, 88);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(52, 13);
            this.lblUnidad.TabIndex = 16;
            this.lblUnidad.Text = "id Unidad";
            // 
            // txtIdMantenimiento
            // 
            this.txtIdMantenimiento.Enabled = false;
            this.txtIdMantenimiento.Location = new System.Drawing.Point(109, 37);
            this.txtIdMantenimiento.Name = "txtIdMantenimiento";
            this.txtIdMantenimiento.Size = new System.Drawing.Size(100, 20);
            this.txtIdMantenimiento.TabIndex = 15;
            // 
            // lblIdMantenimiento
            // 
            this.lblIdMantenimiento.AutoSize = true;
            this.lblIdMantenimiento.Location = new System.Drawing.Point(15, 40);
            this.lblIdMantenimiento.Name = "lblIdMantenimiento";
            this.lblIdMantenimiento.Size = new System.Drawing.Size(88, 13);
            this.lblIdMantenimiento.TabIndex = 14;
            this.lblIdMantenimiento.Text = "Id Mantenimiento";
            // 
            // btnSeleccionarUnidad
            // 
            this.btnSeleccionarUnidad.Location = new System.Drawing.Point(216, 85);
            this.btnSeleccionarUnidad.Name = "btnSeleccionarUnidad";
            this.btnSeleccionarUnidad.Size = new System.Drawing.Size(31, 20);
            this.btnSeleccionarUnidad.TabIndex = 28;
            this.btnSeleccionarUnidad.Text = "...";
            this.btnSeleccionarUnidad.UseVisualStyleBackColor = true;
            this.btnSeleccionarUnidad.Click += new System.EventHandler(this.btnSeleccionarUnidad_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(216, 258);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(350, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmMantenimientosEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 321);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSeleccionarUnidad);
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
            this.Name = "FrmMantenimientosEditar";
            this.Text = "FrmMantenimientosEditar";
            this.Load += new System.EventHandler(this.FrmMantenimientosEditar_Load);
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
        private System.Windows.Forms.Button btnSeleccionarUnidad;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}