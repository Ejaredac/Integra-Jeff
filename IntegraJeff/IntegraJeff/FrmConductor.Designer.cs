
namespace IntegraJeff
{
    partial class FrmConductor
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
            this.pnlConductorSeleccionado = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdConductor = new System.Windows.Forms.TextBox();
            this.lblIdConductor = new System.Windows.Forms.Label();
            this.pnlEspacioTabla = new System.Windows.Forms.Panel();
            this.pnlTablaDatos = new System.Windows.Forms.Panel();
            this.dtgConductores = new System.Windows.Forms.DataGridView();
            this.pnlControlesTabla = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.chkBusqueda = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNro = new System.Windows.Forms.Label();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.txtCantidadPaginas = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.cboPagina = new System.Windows.Forms.ComboBox();
            this.txtRegistrosTotales = new System.Windows.Forms.TextBox();
            this.pnlConductorSeleccionado.SuspendLayout();
            this.pnlEspacioTabla.SuspendLayout();
            this.pnlTablaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConductores)).BeginInit();
            this.pnlControlesTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConductorSeleccionado
            // 
            this.pnlConductorSeleccionado.Controls.Add(this.txtNombre);
            this.pnlConductorSeleccionado.Controls.Add(this.lblNombre);
            this.pnlConductorSeleccionado.Controls.Add(this.txtIdConductor);
            this.pnlConductorSeleccionado.Controls.Add(this.lblIdConductor);
            this.pnlConductorSeleccionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConductorSeleccionado.Location = new System.Drawing.Point(0, 0);
            this.pnlConductorSeleccionado.Name = "pnlConductorSeleccionado";
            this.pnlConductorSeleccionado.Size = new System.Drawing.Size(824, 110);
            this.pnlConductorSeleccionado.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(60, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtIdConductor
            // 
            this.txtIdConductor.Enabled = false;
            this.txtIdConductor.Location = new System.Drawing.Point(129, 34);
            this.txtIdConductor.Name = "txtIdConductor";
            this.txtIdConductor.Size = new System.Drawing.Size(100, 20);
            this.txtIdConductor.TabIndex = 1;
            // 
            // lblIdConductor
            // 
            this.lblIdConductor.AutoSize = true;
            this.lblIdConductor.Location = new System.Drawing.Point(36, 34);
            this.lblIdConductor.Name = "lblIdConductor";
            this.lblIdConductor.Size = new System.Drawing.Size(68, 13);
            this.lblIdConductor.TabIndex = 0;
            this.lblIdConductor.Text = "Id-Conductor";
            // 
            // pnlEspacioTabla
            // 
            this.pnlEspacioTabla.Controls.Add(this.pnlTablaDatos);
            this.pnlEspacioTabla.Controls.Add(this.pnlControlesTabla);
            this.pnlEspacioTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEspacioTabla.Location = new System.Drawing.Point(0, 110);
            this.pnlEspacioTabla.Name = "pnlEspacioTabla";
            this.pnlEspacioTabla.Size = new System.Drawing.Size(824, 377);
            this.pnlEspacioTabla.TabIndex = 3;
            // 
            // pnlTablaDatos
            // 
            this.pnlTablaDatos.Controls.Add(this.dtgConductores);
            this.pnlTablaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTablaDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlTablaDatos.Name = "pnlTablaDatos";
            this.pnlTablaDatos.Size = new System.Drawing.Size(548, 377);
            this.pnlTablaDatos.TabIndex = 1;
            // 
            // dtgConductores
            // 
            this.dtgConductores.AllowUserToAddRows = false;
            this.dtgConductores.AllowUserToDeleteRows = false;
            this.dtgConductores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgConductores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgConductores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.dtgConductores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConductores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgConductores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConductores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConductores.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgConductores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConductores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgConductores.EnableHeadersVisualStyles = false;
            this.dtgConductores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.dtgConductores.Location = new System.Drawing.Point(0, 0);
            this.dtgConductores.Name = "dtgConductores";
            this.dtgConductores.ReadOnly = true;
            this.dtgConductores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConductores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgConductores.RowHeadersVisible = false;
            this.dtgConductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConductores.Size = new System.Drawing.Size(548, 377);
            this.dtgConductores.TabIndex = 1;
            this.dtgConductores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellClick);
            // 
            // pnlControlesTabla
            // 
            this.pnlControlesTabla.Controls.Add(this.btnEliminar);
            this.pnlControlesTabla.Controls.Add(this.btnBusqueda);
            this.pnlControlesTabla.Controls.Add(this.btnEditar);
            this.pnlControlesTabla.Controls.Add(this.chkBusqueda);
            this.pnlControlesTabla.Controls.Add(this.btnAgregar);
            this.pnlControlesTabla.Controls.Add(this.lblNro);
            this.pnlControlesTabla.Controls.Add(this.btnRefresh);
            this.pnlControlesTabla.Controls.Add(this.txtCantidadPaginas);
            this.pnlControlesTabla.Controls.Add(this.lblDe);
            this.pnlControlesTabla.Controls.Add(this.cboPagina);
            this.pnlControlesTabla.Controls.Add(this.txtRegistrosTotales);
            this.pnlControlesTabla.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControlesTabla.Location = new System.Drawing.Point(548, 0);
            this.pnlControlesTabla.Name = "pnlControlesTabla";
            this.pnlControlesTabla.Size = new System.Drawing.Size(276, 377);
            this.pnlControlesTabla.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(189, 342);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusqueda.Location = new System.Drawing.Point(189, 139);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 7;
            this.btnBusqueda.Text = "Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(122, 259);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // chkBusqueda
            // 
            this.chkBusqueda.AutoSize = true;
            this.chkBusqueda.Location = new System.Drawing.Point(24, 145);
            this.chkBusqueda.Name = "chkBusqueda";
            this.chkBusqueda.Size = new System.Drawing.Size(74, 17);
            this.chkBusqueda.TabIndex = 6;
            this.chkBusqueda.Text = "Busqueda";
            this.chkBusqueda.UseVisualStyleBackColor = true;
            this.chkBusqueda.CheckedChanged += new System.EventHandler(this.chkBusqueda_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(14, 259);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 25);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(19, 30);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(27, 13);
            this.lblNro.TabIndex = 5;
            this.lblNro.Text = "Nro.";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Columns;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 26;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.Location = new System.Drawing.Point(223, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(41, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtCantidadPaginas
            // 
            this.txtCantidadPaginas.Enabled = false;
            this.txtCantidadPaginas.Location = new System.Drawing.Point(186, 75);
            this.txtCantidadPaginas.Name = "txtCantidadPaginas";
            this.txtCantidadPaginas.Size = new System.Drawing.Size(69, 20);
            this.txtCantidadPaginas.TabIndex = 3;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(149, 82);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(21, 13);
            this.lblDe.TabIndex = 2;
            this.lblDe.Text = "De";
            // 
            // cboPagina
            // 
            this.cboPagina.FormattingEnabled = true;
            this.cboPagina.Location = new System.Drawing.Point(24, 75);
            this.cboPagina.Name = "cboPagina";
            this.cboPagina.Size = new System.Drawing.Size(100, 21);
            this.cboPagina.TabIndex = 1;
            this.cboPagina.SelectionChangeCommitted += new System.EventHandler(this.cboPagina_SelectionChangeCommitted);
            // 
            // txtRegistrosTotales
            // 
            this.txtRegistrosTotales.Enabled = false;
            this.txtRegistrosTotales.Location = new System.Drawing.Point(52, 27);
            this.txtRegistrosTotales.Name = "txtRegistrosTotales";
            this.txtRegistrosTotales.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrosTotales.TabIndex = 0;
            // 
            // FrmConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 487);
            this.Controls.Add(this.pnlEspacioTabla);
            this.Controls.Add(this.pnlConductorSeleccionado);
            this.Name = "FrmConductor";
            this.Text = "FrmConductor";
            this.Load += new System.EventHandler(this.FrmConductor_Load);
            this.pnlConductorSeleccionado.ResumeLayout(false);
            this.pnlConductorSeleccionado.PerformLayout();
            this.pnlEspacioTabla.ResumeLayout(false);
            this.pnlTablaDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConductores)).EndInit();
            this.pnlControlesTabla.ResumeLayout(false);
            this.pnlControlesTabla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConductorSeleccionado;
        private System.Windows.Forms.Panel pnlEspacioTabla;
        private System.Windows.Forms.Panel pnlTablaDatos;
        private System.Windows.Forms.DataGridView dtgConductores;
        private System.Windows.Forms.Panel pnlControlesTabla;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.CheckBox chkBusqueda;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNro;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.TextBox txtCantidadPaginas;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.ComboBox cboPagina;
        private System.Windows.Forms.TextBox txtRegistrosTotales;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIdConductor;
        private System.Windows.Forms.Label lblIdConductor;
    }
}