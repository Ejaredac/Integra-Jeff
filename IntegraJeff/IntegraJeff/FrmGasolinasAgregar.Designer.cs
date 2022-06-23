namespace IntegraJeff
{
    partial class FrmGasolinasAgregar
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
            this.lblFechaCarga = new System.Windows.Forms.Label();
            this.dtpFechaCarga = new System.Windows.Forms.DateTimePicker();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtGalones = new System.Windows.Forms.TextBox();
            this.lblGalones = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtConductor = new System.Windows.Forms.TextBox();
            this.txtIdConductor = new System.Windows.Forms.TextBox();
            this.lblIdConductor = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtIdUnidad = new System.Windows.Forms.TextBox();
            this.lblIdUnidad = new System.Windows.Forms.Label();
            this.btnSelcUnidad = new System.Windows.Forms.Button();
            this.btnSelcCond = new System.Windows.Forms.Button();
            this.btnConvLitAGal = new System.Windows.Forms.Button();
            this.btnConvGalALit = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Location = new System.Drawing.Point(469, 170);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(83, 13);
            this.lblFechaCarga.TabIndex = 39;
            this.lblFechaCarga.Text = "Fecha de Carga";
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Location = new System.Drawing.Point(558, 167);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCarga.TabIndex = 38;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(395, 90);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtTarjeta.TabIndex = 37;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(349, 93);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(40, 13);
            this.lblTarjeta.TabIndex = 36;
            this.lblTarjeta.Text = "Tarjeta";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(395, 54);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 35;
            this.txtTotal.Text = "0";
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoublePress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(350, 57);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total";
            // 
            // txtGalones
            // 
            this.txtGalones.Location = new System.Drawing.Point(353, 166);
            this.txtGalones.Name = "txtGalones";
            this.txtGalones.Size = new System.Drawing.Size(80, 20);
            this.txtGalones.TabIndex = 33;
            this.txtGalones.Text = "0";
            this.txtGalones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoublePress);
            // 
            // lblGalones
            // 
            this.lblGalones.AutoSize = true;
            this.lblGalones.Location = new System.Drawing.Point(301, 169);
            this.lblGalones.Name = "lblGalones";
            this.lblGalones.Size = new System.Drawing.Size(46, 13);
            this.lblGalones.TabIndex = 32;
            this.lblGalones.Text = "Galones";
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(155, 166);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(81, 20);
            this.txtLitros.TabIndex = 31;
            this.txtLitros.Text = "0";
            this.txtLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoublePress);
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(110, 169);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(32, 13);
            this.lblLitros.TabIndex = 30;
            this.lblLitros.Text = "Litros";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(350, 23);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 28;
            this.lblTipo.Text = "Tipo";
            // 
            // txtConductor
            // 
            this.txtConductor.Location = new System.Drawing.Point(155, 87);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(100, 20);
            this.txtConductor.TabIndex = 27;
            // 
            // txtIdConductor
            // 
            this.txtIdConductor.Location = new System.Drawing.Point(99, 87);
            this.txtIdConductor.Name = "txtIdConductor";
            this.txtIdConductor.Size = new System.Drawing.Size(50, 20);
            this.txtIdConductor.TabIndex = 26;
            this.txtIdConductor.Text = "0";
            // 
            // lblIdConductor
            // 
            this.lblIdConductor.AutoSize = true;
            this.lblIdConductor.Location = new System.Drawing.Point(21, 90);
            this.lblIdConductor.Name = "lblIdConductor";
            this.lblIdConductor.Size = new System.Drawing.Size(68, 13);
            this.lblIdConductor.TabIndex = 25;
            this.lblIdConductor.Text = "Id-Conductor";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(155, 54);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad.TabIndex = 24;
            // 
            // txtIdUnidad
            // 
            this.txtIdUnidad.Location = new System.Drawing.Point(99, 54);
            this.txtIdUnidad.Name = "txtIdUnidad";
            this.txtIdUnidad.Size = new System.Drawing.Size(50, 20);
            this.txtIdUnidad.TabIndex = 23;
            this.txtIdUnidad.Text = "0";
            // 
            // lblIdUnidad
            // 
            this.lblIdUnidad.AutoSize = true;
            this.lblIdUnidad.Location = new System.Drawing.Point(18, 57);
            this.lblIdUnidad.Name = "lblIdUnidad";
            this.lblIdUnidad.Size = new System.Drawing.Size(53, 13);
            this.lblIdUnidad.TabIndex = 22;
            this.lblIdUnidad.Text = "Id-Unidad";
            // 
            // btnSelcUnidad
            // 
            this.btnSelcUnidad.Location = new System.Drawing.Point(261, 52);
            this.btnSelcUnidad.Name = "btnSelcUnidad";
            this.btnSelcUnidad.Size = new System.Drawing.Size(28, 23);
            this.btnSelcUnidad.TabIndex = 40;
            this.btnSelcUnidad.Text = "...";
            this.btnSelcUnidad.UseVisualStyleBackColor = true;
            this.btnSelcUnidad.Click += new System.EventHandler(this.btnSelcUnidad_Click);
            // 
            // btnSelcCond
            // 
            this.btnSelcCond.Location = new System.Drawing.Point(261, 84);
            this.btnSelcCond.Name = "btnSelcCond";
            this.btnSelcCond.Size = new System.Drawing.Size(28, 23);
            this.btnSelcCond.TabIndex = 41;
            this.btnSelcCond.Text = "...";
            this.btnSelcCond.UseVisualStyleBackColor = true;
            this.btnSelcCond.Click += new System.EventHandler(this.btnSelcCond_Click);
            // 
            // btnConvLitAGal
            // 
            this.btnConvLitAGal.Location = new System.Drawing.Point(79, 166);
            this.btnConvLitAGal.Name = "btnConvLitAGal";
            this.btnConvLitAGal.Size = new System.Drawing.Size(25, 24);
            this.btnConvLitAGal.TabIndex = 42;
            this.btnConvLitAGal.Text = ".";
            this.btnConvLitAGal.UseVisualStyleBackColor = true;
            this.btnConvLitAGal.Click += new System.EventHandler(this.btnConvLitAGal_Click);
            // 
            // btnConvGalALit
            // 
            this.btnConvGalALit.Location = new System.Drawing.Point(270, 167);
            this.btnConvGalALit.Name = "btnConvGalALit";
            this.btnConvGalALit.Size = new System.Drawing.Size(25, 24);
            this.btnConvGalALit.TabIndex = 43;
            this.btnConvGalALit.Text = ".";
            this.btnConvGalALit.UseVisualStyleBackColor = true;
            this.btnConvGalALit.Click += new System.EventHandler(this.btnConvGalALit_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(409, 246);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(190, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel"});
            this.cboTipo.Location = new System.Drawing.Point(395, 20);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 73;
            this.cboTipo.Text = "Gasolina";
            // 
            // FrmGasolinasAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 317);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnConvGalALit);
            this.Controls.Add(this.btnConvLitAGal);
            this.Controls.Add(this.btnSelcCond);
            this.Controls.Add(this.btnSelcUnidad);
            this.Controls.Add(this.lblFechaCarga);
            this.Controls.Add(this.dtpFechaCarga);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.lblTarjeta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtGalones);
            this.Controls.Add(this.lblGalones);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtConductor);
            this.Controls.Add(this.txtIdConductor);
            this.Controls.Add(this.lblIdConductor);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtIdUnidad);
            this.Controls.Add(this.lblIdUnidad);
            this.Name = "FrmGasolinasAgregar";
            this.Text = "FrmGasolinasAgregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaCarga;
        private System.Windows.Forms.DateTimePicker dtpFechaCarga;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtGalones;
        private System.Windows.Forms.Label lblGalones;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.TextBox txtIdConductor;
        private System.Windows.Forms.Label lblIdConductor;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtIdUnidad;
        private System.Windows.Forms.Label lblIdUnidad;
        private System.Windows.Forms.Button btnSelcUnidad;
        private System.Windows.Forms.Button btnSelcCond;
        private System.Windows.Forms.Button btnConvLitAGal;
        private System.Windows.Forms.Button btnConvGalALit;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboTipo;
    }
}