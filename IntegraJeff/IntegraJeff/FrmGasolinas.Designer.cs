namespace IntegraJeff
{
    partial class FrmGasolinas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEspacioTabla = new System.Windows.Forms.Panel();
            this.pnlTablaDatos = new System.Windows.Forms.Panel();
            this.dtgGasolinas = new System.Windows.Forms.DataGridView();
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
            this.lblIdGasolinas = new System.Windows.Forms.Label();
            this.txtIdGasolinas = new System.Windows.Forms.TextBox();
            this.lblIdUnidad = new System.Windows.Forms.Label();
            this.txtIdUnidad = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.lblIdConductor = new System.Windows.Forms.Label();
            this.txtIdConductor = new System.Windows.Forms.TextBox();
            this.txtConductor = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.lblGalones = new System.Windows.Forms.Label();
            this.txtGalones = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.dtpFechaCarga = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCarga = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlEspacioTabla.SuspendLayout();
            this.pnlTablaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGasolinas)).BeginInit();
            this.pnlControlesTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFechaCarga);
            this.panel1.Controls.Add(this.dtpFechaCarga);
            this.panel1.Controls.Add(this.txtTarjeta);
            this.panel1.Controls.Add(this.lblTarjeta);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.txtGalones);
            this.panel1.Controls.Add(this.lblGalones);
            this.panel1.Controls.Add(this.txtLitros);
            this.panel1.Controls.Add(this.lblLitros);
            this.panel1.Controls.Add(this.txtTipo);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.txtConductor);
            this.panel1.Controls.Add(this.txtIdConductor);
            this.panel1.Controls.Add(this.lblIdConductor);
            this.panel1.Controls.Add(this.txtUnidad);
            this.panel1.Controls.Add(this.txtIdUnidad);
            this.panel1.Controls.Add(this.lblIdUnidad);
            this.panel1.Controls.Add(this.txtIdGasolinas);
            this.panel1.Controls.Add(this.lblIdGasolinas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 120);
            this.panel1.TabIndex = 0;
            // 
            // pnlEspacioTabla
            // 
            this.pnlEspacioTabla.Controls.Add(this.pnlTablaDatos);
            this.pnlEspacioTabla.Controls.Add(this.pnlControlesTabla);
            this.pnlEspacioTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEspacioTabla.Location = new System.Drawing.Point(0, 120);
            this.pnlEspacioTabla.Name = "pnlEspacioTabla";
            this.pnlEspacioTabla.Size = new System.Drawing.Size(985, 418);
            this.pnlEspacioTabla.TabIndex = 9;
            // 
            // pnlTablaDatos
            // 
            this.pnlTablaDatos.Controls.Add(this.dtgGasolinas);
            this.pnlTablaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTablaDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlTablaDatos.Name = "pnlTablaDatos";
            this.pnlTablaDatos.Size = new System.Drawing.Size(709, 418);
            this.pnlTablaDatos.TabIndex = 1;
            // 
            // dtgGasolinas
            // 
            this.dtgGasolinas.AllowUserToAddRows = false;
            this.dtgGasolinas.AllowUserToDeleteRows = false;
            this.dtgGasolinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgGasolinas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgGasolinas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.dtgGasolinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgGasolinas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgGasolinas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGasolinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgGasolinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGasolinas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgGasolinas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgGasolinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgGasolinas.EnableHeadersVisualStyles = false;
            this.dtgGasolinas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.dtgGasolinas.Location = new System.Drawing.Point(0, 0);
            this.dtgGasolinas.Name = "dtgGasolinas";
            this.dtgGasolinas.ReadOnly = true;
            this.dtgGasolinas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGasolinas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgGasolinas.RowHeadersVisible = false;
            this.dtgGasolinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGasolinas.Size = new System.Drawing.Size(709, 418);
            this.dtgGasolinas.TabIndex = 1;
            this.dtgGasolinas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgGasolinas_CellMouseClick);
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
            this.pnlControlesTabla.Location = new System.Drawing.Point(709, 0);
            this.pnlControlesTabla.Name = "pnlControlesTabla";
            this.pnlControlesTabla.Size = new System.Drawing.Size(276, 418);
            this.pnlControlesTabla.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(189, 383);
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
            this.btnEditar.Location = new System.Drawing.Point(122, 300);
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
            this.btnAgregar.Location = new System.Drawing.Point(14, 300);
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
            // lblIdGasolinas
            // 
            this.lblIdGasolinas.AutoSize = true;
            this.lblIdGasolinas.Location = new System.Drawing.Point(12, 19);
            this.lblIdGasolinas.Name = "lblIdGasolinas";
            this.lblIdGasolinas.Size = new System.Drawing.Size(65, 13);
            this.lblIdGasolinas.TabIndex = 0;
            this.lblIdGasolinas.Text = "Id-Gasolinas";
            // 
            // txtIdGasolinas
            // 
            this.txtIdGasolinas.Location = new System.Drawing.Point(93, 16);
            this.txtIdGasolinas.Name = "txtIdGasolinas";
            this.txtIdGasolinas.Size = new System.Drawing.Size(50, 20);
            this.txtIdGasolinas.TabIndex = 1;
            // 
            // lblIdUnidad
            // 
            this.lblIdUnidad.AutoSize = true;
            this.lblIdUnidad.Location = new System.Drawing.Point(12, 53);
            this.lblIdUnidad.Name = "lblIdUnidad";
            this.lblIdUnidad.Size = new System.Drawing.Size(53, 13);
            this.lblIdUnidad.TabIndex = 2;
            this.lblIdUnidad.Text = "Id-Unidad";
            // 
            // txtIdUnidad
            // 
            this.txtIdUnidad.Location = new System.Drawing.Point(93, 50);
            this.txtIdUnidad.Name = "txtIdUnidad";
            this.txtIdUnidad.Size = new System.Drawing.Size(50, 20);
            this.txtIdUnidad.TabIndex = 3;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(149, 50);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad.TabIndex = 4;
            // 
            // lblIdConductor
            // 
            this.lblIdConductor.AutoSize = true;
            this.lblIdConductor.Location = new System.Drawing.Point(15, 86);
            this.lblIdConductor.Name = "lblIdConductor";
            this.lblIdConductor.Size = new System.Drawing.Size(68, 13);
            this.lblIdConductor.TabIndex = 5;
            this.lblIdConductor.Text = "Id-Conductor";
            // 
            // txtIdConductor
            // 
            this.txtIdConductor.Location = new System.Drawing.Point(93, 83);
            this.txtIdConductor.Name = "txtIdConductor";
            this.txtIdConductor.Size = new System.Drawing.Size(50, 20);
            this.txtIdConductor.TabIndex = 6;
            // 
            // txtConductor
            // 
            this.txtConductor.Location = new System.Drawing.Point(149, 83);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(100, 20);
            this.txtConductor.TabIndex = 7;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(281, 19);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(326, 16);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 9;
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(281, 53);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(32, 13);
            this.lblLitros.TabIndex = 10;
            this.lblLitros.Text = "Litros";
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(326, 50);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(81, 20);
            this.txtLitros.TabIndex = 11;
            // 
            // lblGalones
            // 
            this.lblGalones.AutoSize = true;
            this.lblGalones.Location = new System.Drawing.Point(413, 53);
            this.lblGalones.Name = "lblGalones";
            this.lblGalones.Size = new System.Drawing.Size(46, 13);
            this.lblGalones.TabIndex = 12;
            this.lblGalones.Text = "Galones";
            // 
            // txtGalones
            // 
            this.txtGalones.Location = new System.Drawing.Point(465, 50);
            this.txtGalones.Name = "txtGalones";
            this.txtGalones.Size = new System.Drawing.Size(80, 20);
            this.txtGalones.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(281, 86);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(326, 83);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(572, 19);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(40, 13);
            this.lblTarjeta.TabIndex = 16;
            this.lblTarjeta.Text = "Tarjeta";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(618, 16);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtTarjeta.TabIndex = 17;
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Location = new System.Drawing.Point(661, 50);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCarga.TabIndex = 18;
            // 
            // lblFechaCarga
            // 
            this.lblFechaCarga.AutoSize = true;
            this.lblFechaCarga.Location = new System.Drawing.Point(572, 53);
            this.lblFechaCarga.Name = "lblFechaCarga";
            this.lblFechaCarga.Size = new System.Drawing.Size(83, 13);
            this.lblFechaCarga.TabIndex = 19;
            this.lblFechaCarga.Text = "Fecha de Carga";
            // 
            // FrmGasolinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 538);
            this.Controls.Add(this.pnlEspacioTabla);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGasolinas";
            this.Text = "FrmGasolinas";
            this.Load += new System.EventHandler(this.FrmGasolinas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEspacioTabla.ResumeLayout(false);
            this.pnlTablaDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGasolinas)).EndInit();
            this.pnlControlesTabla.ResumeLayout(false);
            this.pnlControlesTabla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEspacioTabla;
        private System.Windows.Forms.Panel pnlTablaDatos;
        private System.Windows.Forms.DataGridView dtgGasolinas;
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
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.TextBox txtIdConductor;
        private System.Windows.Forms.Label lblIdConductor;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtIdUnidad;
        private System.Windows.Forms.Label lblIdUnidad;
        private System.Windows.Forms.TextBox txtIdGasolinas;
        private System.Windows.Forms.Label lblIdGasolinas;
    }
}