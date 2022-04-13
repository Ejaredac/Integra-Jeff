
namespace IntegraJeff
{
    partial class FrnUsuarioEmpleado
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.lblContrasenna = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtIDusuario = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(325, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido Empleado";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(650, 57);
            this.pnlTitulo.TabIndex = 1;
            // 
            // pnlDatos
            // 
            this.pnlDatos.AutoScroll = true;
            this.pnlDatos.Controls.Add(this.btnEditar);
            this.pnlDatos.Controls.Add(this.txtContrasenna);
            this.pnlDatos.Controls.Add(this.lblContrasenna);
            this.pnlDatos.Controls.Add(this.txtEmail);
            this.pnlDatos.Controls.Add(this.lblEmail);
            this.pnlDatos.Controls.Add(this.txtNombreUsuario);
            this.pnlDatos.Controls.Add(this.lblNombreUsuario);
            this.pnlDatos.Controls.Add(this.txtIDusuario);
            this.pnlDatos.Controls.Add(this.lblIdUsuario);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 57);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(650, 398);
            this.pnlDatos.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(22, 344);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrasenna.Location = new System.Drawing.Point(98, 167);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.Size = new System.Drawing.Size(366, 23);
            this.txtContrasenna.TabIndex = 7;
            // 
            // lblContrasenna
            // 
            this.lblContrasenna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblContrasenna.AutoSize = true;
            this.lblContrasenna.Location = new System.Drawing.Point(20, 175);
            this.lblContrasenna.Name = "lblContrasenna";
            this.lblContrasenna.Size = new System.Drawing.Size(72, 15);
            this.lblContrasenna.TabIndex = 6;
            this.lblContrasenna.Text = "Contraseña";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(86, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(378, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(157, 83);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(307, 23);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(16, 83);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(114, 15);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // txtIDusuario
            // 
            this.txtIDusuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDusuario.Location = new System.Drawing.Point(98, 37);
            this.txtIDusuario.Name = "txtIDusuario";
            this.txtIDusuario.Size = new System.Drawing.Size(65, 23);
            this.txtIDusuario.TabIndex = 1;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(16, 40);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(67, 15);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "ID-Usuario";
            // 
            // FrnUsuarioEmpleado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(650, 455);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrnUsuarioEmpleado";
            this.Text = "FrnUsuarioEmpleado";
            this.Load += new System.EventHandler(this.FrnUsuarioEmpleado_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.Label lblContrasenna;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtIDusuario;
        private System.Windows.Forms.Label lblIdUsuario;
    }
}