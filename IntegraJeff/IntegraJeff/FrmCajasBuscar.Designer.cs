
namespace IntegraJeff
{
    partial class FrmCajasBuscar
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIDCaja = new System.Windows.Forms.TextBox();
            this.lblNumCaja = new System.Windows.Forms.Label();
            this.txtNumeroDeCaja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(255, 323);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Buscar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(406, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(41, 71);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID-Caja";
            // 
            // txtIDCaja
            // 
            this.txtIDCaja.Location = new System.Drawing.Point(109, 71);
            this.txtIDCaja.Name = "txtIDCaja";
            this.txtIDCaja.Size = new System.Drawing.Size(100, 20);
            this.txtIDCaja.TabIndex = 3;
            // 
            // lblNumCaja
            // 
            this.lblNumCaja.AutoSize = true;
            this.lblNumCaja.Location = new System.Drawing.Point(12, 117);
            this.lblNumCaja.Name = "lblNumCaja";
            this.lblNumCaja.Size = new System.Drawing.Size(83, 13);
            this.lblNumCaja.TabIndex = 4;
            this.lblNumCaja.Text = "Numero de Caja";
            // 
            // txtNumeroDeCaja
            // 
            this.txtNumeroDeCaja.Location = new System.Drawing.Point(109, 117);
            this.txtNumeroDeCaja.Name = "txtNumeroDeCaja";
            this.txtNumeroDeCaja.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDeCaja.TabIndex = 5;
            // 
            // FrmCajasBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumeroDeCaja);
            this.Controls.Add(this.lblNumCaja);
            this.Controls.Add(this.txtIDCaja);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmCajasBuscar";
            this.Text = "FrmCajasBuscar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCajasBuscar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIDCaja;
        private System.Windows.Forms.Label lblNumCaja;
        private System.Windows.Forms.TextBox txtNumeroDeCaja;
    }
}