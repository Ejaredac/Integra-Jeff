
namespace IntegraJeff
{
    partial class FrmCajaEditar
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
            this.txtNumeroDeCaja = new System.Windows.Forms.TextBox();
            this.lblNumCaja = new System.Windows.Forms.Label();
            this.txtIDCaja = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroDeCaja
            // 
            this.txtNumeroDeCaja.Location = new System.Drawing.Point(151, 113);
            this.txtNumeroDeCaja.Name = "txtNumeroDeCaja";
            this.txtNumeroDeCaja.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDeCaja.TabIndex = 11;
            // 
            // lblNumCaja
            // 
            this.lblNumCaja.AutoSize = true;
            this.lblNumCaja.Location = new System.Drawing.Point(54, 116);
            this.lblNumCaja.Name = "lblNumCaja";
            this.lblNumCaja.Size = new System.Drawing.Size(83, 13);
            this.lblNumCaja.TabIndex = 10;
            this.lblNumCaja.Text = "Numero de Caja";
            // 
            // txtIDCaja
            // 
            this.txtIDCaja.Enabled = false;
            this.txtIDCaja.Location = new System.Drawing.Point(151, 70);
            this.txtIDCaja.Name = "txtIDCaja";
            this.txtIDCaja.Size = new System.Drawing.Size(100, 20);
            this.txtIDCaja.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(83, 70);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "ID-Caja";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(448, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(297, 322);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmCajaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumeroDeCaja);
            this.Controls.Add(this.lblNumCaja);
            this.Controls.Add(this.txtIDCaja);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Name = "FrmCajaEditar";
            this.Text = "FrmCajaEditar";
            this.Load += new System.EventHandler(this.FrmCajaEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroDeCaja;
        private System.Windows.Forms.Label lblNumCaja;
        private System.Windows.Forms.TextBox txtIDCaja;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
    }
}