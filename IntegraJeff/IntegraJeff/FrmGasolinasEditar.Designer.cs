﻿namespace IntegraJeff
{
    partial class FrmGasolinasEditar
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConvGalALit = new System.Windows.Forms.Button();
            this.btnConvLitAGal = new System.Windows.Forms.Button();
            this.btnSelcCond = new System.Windows.Forms.Button();
            this.btnSelcUnidad = new System.Windows.Forms.Button();
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
            this.txtIdGasolinas = new System.Windows.Forms.TextBox();
            this.lblIdGasolinas = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(184, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(403, 238);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 70;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConvGalALit
            // 
            this.btnConvGalALit.Location = new System.Drawing.Point(264, 159);
            this.btnConvGalALit.Name = "btnConvGalALit";
            this.btnConvGalALit.Size = new System.Drawing.Size(25, 24);
            this.btnConvGalALit.TabIndex = 69;
            this.btnConvGalALit.Text = ".";
            this.btnConvGalALit.UseVisualStyleBackColor = true;
            this.btnConvGalALit.Click += new System.EventHandler(this.btnConvGalALit_Click);
            // 
            // btnConvLitAGal
            // 
            this.btnConvLitAGal.Location = new System.Drawing.Point(73, 158);
            this.btnConvLitAGal.Name = "btnConvLitAGal";
            this.btnConvLitAGal.Size = new System.Drawing.Size(25, 24);
            this.btnConvLitAGal.TabIndex = 68;
            this.btnConvLitAGal.Text = ".";
            this.btnConvLitAGal.UseVisualStyleBackColor = true;
            this.btnConvLitAGal.Click += new System.EventHandler(this.btnConvLitAGal_Click);
            // 
            // btnSelcCond
            // 
            this.btnSelcCond.Location = new System.Drawing.Point(255, 76);
            this.btnSelcCond.Name = "btnSelcCond";
            this.btnSelcCond.Size = new System.Drawing.Size(28, 23);
            this.btnSelcCond.TabIndex = 67;
            this.btnSelcCond.Text = "...";
            this.btnSelcCond.UseVisualStyleBackColor = true;
            this.btnSelcCond.Click += new System.EventHandler(this.btnSelcCond_Click);
            // 
            // btnSelcUnidad
            // 
            this.btnSelcUnidad.Location = new System.Drawing.Point(255, 44);
            this.btnSelcUnidad.Name = "btnSelcUnidad";
            this.btnSelcUnidad.Size = new System.Drawing.Size(28, 23);
            this.btnSelcUnidad.TabIndex = 66;
            this.btnSelcUnidad.Text = "...";
            this.btnSelcUnidad.UseVisualStyleBackColor = true;
            this.btnSelcUnidad.Click += new System.EventHandler(this.btnSelcUnidad_Click);
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Location = new System.Drawing.Point(463, 162);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(83, 13);
            this.lblFechaCarga.TabIndex = 65;
            this.lblFechaCarga.Text = "Fecha de Carga";
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Location = new System.Drawing.Point(552, 159);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCarga.TabIndex = 64;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(389, 82);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtTarjeta.TabIndex = 63;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(343, 85);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(40, 13);
            this.lblTarjeta.TabIndex = 62;
            this.lblTarjeta.Text = "Tarjeta";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(389, 46);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 61;
            this.txtTotal.Text = "0";
            this.txtTotal.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoublePress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(344, 49);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Text = "Total";
            // 
            // txtGalones
            // 
            this.txtGalones.Location = new System.Drawing.Point(347, 158);
            this.txtGalones.Name = "txtGalones";
            this.txtGalones.Size = new System.Drawing.Size(80, 20);
            this.txtGalones.TabIndex = 59;
            this.txtGalones.Text = "0";
            this.txtGalones.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtGalones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoublePress);
            // 
            // lblGalones
            // 
            this.lblGalones.AutoSize = true;
            this.lblGalones.Location = new System.Drawing.Point(295, 161);
            this.lblGalones.Name = "lblGalones";
            this.lblGalones.Size = new System.Drawing.Size(46, 13);
            this.lblGalones.TabIndex = 58;
            this.lblGalones.Text = "Galones";
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(149, 158);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(81, 20);
            this.txtLitros.TabIndex = 57;
            this.txtLitros.Text = "0";
            this.txtLitros.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoublePress);
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(104, 161);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(32, 13);
            this.lblLitros.TabIndex = 56;
            this.lblLitros.Text = "Litros";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(344, 15);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 54;
            this.lblTipo.Text = "Tipo";
            // 
            // txtConductor
            // 
            this.txtConductor.Location = new System.Drawing.Point(149, 79);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(100, 20);
            this.txtConductor.TabIndex = 53;
            // 
            // txtIdConductor
            // 
            this.txtIdConductor.Location = new System.Drawing.Point(93, 79);
            this.txtIdConductor.Name = "txtIdConductor";
            this.txtIdConductor.Size = new System.Drawing.Size(50, 20);
            this.txtIdConductor.TabIndex = 52;
            this.txtIdConductor.Text = "0";
            this.txtIdConductor.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtIdConductor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntAllow);
            // 
            // lblIdConductor
            // 
            this.lblIdConductor.AutoSize = true;
            this.lblIdConductor.Location = new System.Drawing.Point(15, 82);
            this.lblIdConductor.Name = "lblIdConductor";
            this.lblIdConductor.Size = new System.Drawing.Size(68, 13);
            this.lblIdConductor.TabIndex = 51;
            this.lblIdConductor.Text = "Id-Conductor";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(149, 46);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad.TabIndex = 50;
            // 
            // txtIdUnidad
            // 
            this.txtIdUnidad.Location = new System.Drawing.Point(93, 46);
            this.txtIdUnidad.Name = "txtIdUnidad";
            this.txtIdUnidad.Size = new System.Drawing.Size(50, 20);
            this.txtIdUnidad.TabIndex = 49;
            this.txtIdUnidad.Text = "0";
            this.txtIdUnidad.TextChanged += new System.EventHandler(this.NotVacio);
            this.txtIdUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntAllow);
            // 
            // lblIdUnidad
            // 
            this.lblIdUnidad.AutoSize = true;
            this.lblIdUnidad.Location = new System.Drawing.Point(12, 49);
            this.lblIdUnidad.Name = "lblIdUnidad";
            this.lblIdUnidad.Size = new System.Drawing.Size(53, 13);
            this.lblIdUnidad.TabIndex = 48;
            this.lblIdUnidad.Text = "Id-Unidad";
            // 
            // txtIdGasolinas
            // 
            this.txtIdGasolinas.Enabled = false;
            this.txtIdGasolinas.Location = new System.Drawing.Point(93, 12);
            this.txtIdGasolinas.Name = "txtIdGasolinas";
            this.txtIdGasolinas.Size = new System.Drawing.Size(50, 20);
            this.txtIdGasolinas.TabIndex = 47;
            // 
            // lblIdGasolinas
            // 
            this.lblIdGasolinas.AutoSize = true;
            this.lblIdGasolinas.Location = new System.Drawing.Point(12, 15);
            this.lblIdGasolinas.Name = "lblIdGasolinas";
            this.lblIdGasolinas.Size = new System.Drawing.Size(65, 13);
            this.lblIdGasolinas.TabIndex = 46;
            this.lblIdGasolinas.Text = "Id-Gasolinas";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel"});
            this.cboTipo.Location = new System.Drawing.Point(389, 15);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 72;
            this.cboTipo.Text = "Gasolina";
            // 
            // FrmGasolinasEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 291);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
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
            this.Controls.Add(this.txtIdGasolinas);
            this.Controls.Add(this.lblIdGasolinas);
            this.Name = "FrmGasolinasEditar";
            this.Text = "FrmGasolinasEditar";
            this.Load += new System.EventHandler(this.FrmGasolinasEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConvGalALit;
        private System.Windows.Forms.Button btnConvLitAGal;
        private System.Windows.Forms.Button btnSelcCond;
        private System.Windows.Forms.Button btnSelcUnidad;
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
        private System.Windows.Forms.TextBox txtIdGasolinas;
        private System.Windows.Forms.Label lblIdGasolinas;
        private System.Windows.Forms.ComboBox cboTipo;
    }
}