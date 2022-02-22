
namespace IntegraJeff
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlImagenLogo = new System.Windows.Forms.Panel();
            this.pctLogoJeff = new System.Windows.Forms.PictureBox();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.cboDirecciones = new System.Windows.Forms.ComboBox();
            this.pnlImagenLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoJeff)).BeginInit();
            this.pnlControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImagenLogo
            // 
            this.pnlImagenLogo.Controls.Add(this.pctLogoJeff);
            this.pnlImagenLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImagenLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlImagenLogo.Name = "pnlImagenLogo";
            this.pnlImagenLogo.Size = new System.Drawing.Size(629, 264);
            this.pnlImagenLogo.TabIndex = 0;
            // 
            // pctLogoJeff
            // 
            this.pctLogoJeff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctLogoJeff.Image = global::IntegraJeff.Properties.Resources.JeffVector;
            this.pctLogoJeff.Location = new System.Drawing.Point(0, 0);
            this.pctLogoJeff.Name = "pctLogoJeff";
            this.pctLogoJeff.Size = new System.Drawing.Size(629, 264);
            this.pctLogoJeff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogoJeff.TabIndex = 0;
            this.pctLogoJeff.TabStop = false;
            // 
            // pnlControles
            // 
            this.pnlControles.Controls.Add(this.lblDireccion);
            this.pnlControles.Controls.Add(this.btnSeleccionar);
            this.pnlControles.Controls.Add(this.cboDirecciones);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControles.Location = new System.Drawing.Point(0, 264);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(629, 66);
            this.pnlControles.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(531, 25);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(54, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSeleccionar.Location = new System.Drawing.Point(442, 19);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // cboDirecciones
            // 
            this.cboDirecciones.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboDirecciones.FormattingEnabled = true;
            this.cboDirecciones.Location = new System.Drawing.Point(241, 19);
            this.cboDirecciones.Name = "cboDirecciones";
            this.cboDirecciones.Size = new System.Drawing.Size(170, 21);
            this.cboDirecciones.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSeleccionar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 372);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.pnlImagenLogo);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(765, 451);
            this.MinimumSize = new System.Drawing.Size(640, 406);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlImagenLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoJeff)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImagenLogo;
        private System.Windows.Forms.PictureBox pctLogoJeff;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ComboBox cboDirecciones;
        private System.Windows.Forms.Label lblDireccion;
    }
}

