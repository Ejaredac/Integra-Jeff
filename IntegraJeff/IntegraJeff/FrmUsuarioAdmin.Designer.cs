
namespace IntegraJeff
{
    partial class FrmUsuarioAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlDatosPropios = new System.Windows.Forms.Panel();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.chkConfirmado = new System.Windows.Forms.CheckBox();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.lblContrasenna = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtIDusuario = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.pnlDatosUsuarios = new System.Windows.Forms.Panel();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.dtgUsurios = new System.Windows.Forms.DataGridView();
            this.pnlTitulo.SuspendLayout();
            this.pnlDatosPropios.SuspendLayout();
            this.pnlDatosUsuarios.SuspendLayout();
            this.pnlControles.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsurios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(389, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido Administrador";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(809, 50);
            this.pnlTitulo.TabIndex = 1;
            // 
            // pnlDatosPropios
            // 
            this.pnlDatosPropios.Controls.Add(this.cboRol);
            this.pnlDatosPropios.Controls.Add(this.chkConfirmado);
            this.pnlDatosPropios.Controls.Add(this.txtContrasenna);
            this.pnlDatosPropios.Controls.Add(this.lblContrasenna);
            this.pnlDatosPropios.Controls.Add(this.txtEmail);
            this.pnlDatosPropios.Controls.Add(this.lblEmail);
            this.pnlDatosPropios.Controls.Add(this.txtNombreUsuario);
            this.pnlDatosPropios.Controls.Add(this.lblNombreUsuario);
            this.pnlDatosPropios.Controls.Add(this.txtIDusuario);
            this.pnlDatosPropios.Controls.Add(this.lblIdUsuario);
            this.pnlDatosPropios.Controls.Add(this.btnRefresh);
            this.pnlDatosPropios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatosPropios.Location = new System.Drawing.Point(0, 50);
            this.pnlDatosPropios.Name = "pnlDatosPropios";
            this.pnlDatosPropios.Size = new System.Drawing.Size(809, 217);
            this.pnlDatosPropios.TabIndex = 2;
            // 
            // cboRol
            // 
            this.cboRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.cboRol.Location = new System.Drawing.Point(320, 103);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(121, 21);
            this.cboRol.TabIndex = 17;
            // 
            // chkConfirmado
            // 
            this.chkConfirmado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkConfirmado.AutoSize = true;
            this.chkConfirmado.Location = new System.Drawing.Point(320, 57);
            this.chkConfirmado.Name = "chkConfirmado";
            this.chkConfirmado.Size = new System.Drawing.Size(83, 17);
            this.chkConfirmado.TabIndex = 16;
            this.chkConfirmado.Text = "Confirmado";
            this.chkConfirmado.UseVisualStyleBackColor = true;
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrasenna.Location = new System.Drawing.Point(94, 145);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.Size = new System.Drawing.Size(201, 21);
            this.txtContrasenna.TabIndex = 15;
            // 
            // lblContrasenna
            // 
            this.lblContrasenna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblContrasenna.AutoSize = true;
            this.lblContrasenna.Location = new System.Drawing.Point(16, 153);
            this.lblContrasenna.Name = "lblContrasenna";
            this.lblContrasenna.Size = new System.Drawing.Size(64, 13);
            this.lblContrasenna.TabIndex = 14;
            this.lblContrasenna.Text = "Contraseña";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(82, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 21);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 109);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(153, 61);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(142, 21);
            this.txtNombreUsuario.TabIndex = 11;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 61);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(102, 13);
            this.lblNombreUsuario.TabIndex = 10;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // txtIDusuario
            // 
            this.txtIDusuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDusuario.Location = new System.Drawing.Point(94, 15);
            this.txtIDusuario.Name = "txtIDusuario";
            this.txtIDusuario.Size = new System.Drawing.Size(65, 21);
            this.txtIDusuario.TabIndex = 9;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(12, 18);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(58, 13);
            this.lblIdUsuario.TabIndex = 8;
            this.lblIdUsuario.Text = "ID-Usuario";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Columns;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 26;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.Location = new System.Drawing.Point(756, 175);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(41, 36);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlDatosUsuarios
            // 
            this.pnlDatosUsuarios.Controls.Add(this.pnlControles);
            this.pnlDatosUsuarios.Controls.Add(this.pnlTabla);
            this.pnlDatosUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosUsuarios.Location = new System.Drawing.Point(0, 267);
            this.pnlDatosUsuarios.Name = "pnlDatosUsuarios";
            this.pnlDatosUsuarios.Size = new System.Drawing.Size(809, 229);
            this.pnlDatosUsuarios.TabIndex = 3;
            // 
            // pnlControles
            // 
            this.pnlControles.Controls.Add(this.btnAgregar);
            this.pnlControles.Controls.Add(this.btnEliminar);
            this.pnlControles.Controls.Add(this.btnEditar);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControles.Location = new System.Drawing.Point(609, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(200, 229);
            this.pnlControles.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(6, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(182, 27);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(79)))), ((int)(((byte)(55)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(6, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(182, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(6, 99);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(182, 23);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlTabla
            // 
            this.pnlTabla.Controls.Add(this.dtgUsurios);
            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabla.Location = new System.Drawing.Point(0, 0);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Padding = new System.Windows.Forms.Padding(2);
            this.pnlTabla.Size = new System.Drawing.Size(809, 229);
            this.pnlTabla.TabIndex = 0;
            // 
            // dtgUsurios
            // 
            this.dtgUsurios.AllowUserToAddRows = false;
            this.dtgUsurios.AllowUserToDeleteRows = false;
            this.dtgUsurios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgUsurios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgUsurios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.dtgUsurios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgUsurios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgUsurios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsurios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsurios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsurios.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgUsurios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgUsurios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUsurios.EnableHeadersVisualStyles = false;
            this.dtgUsurios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.dtgUsurios.Location = new System.Drawing.Point(2, 2);
            this.dtgUsurios.Name = "dtgUsurios";
            this.dtgUsurios.ReadOnly = true;
            this.dtgUsurios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsurios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgUsurios.RowHeadersVisible = false;
            this.dtgUsurios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsurios.Size = new System.Drawing.Size(805, 225);
            this.dtgUsurios.TabIndex = 0;
            this.dtgUsurios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsurios_CellClick);
            // 
            // FrmUsuarioAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 496);
            this.Controls.Add(this.pnlDatosUsuarios);
            this.Controls.Add(this.pnlDatosPropios);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(825, 535);
            this.Name = "FrmUsuarioAdmin";
            this.Text = "FrmUsuarioAdmin";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlDatosPropios.ResumeLayout(false);
            this.pnlDatosPropios.PerformLayout();
            this.pnlDatosUsuarios.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            this.pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsurios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlDatosPropios;
        private System.Windows.Forms.Panel pnlDatosUsuarios;
        private System.Windows.Forms.DataGridView dtgUsurios;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.Label lblContrasenna;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtIDusuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.CheckBox chkConfirmado;
        private System.Windows.Forms.ComboBox cboRol;
    }
}