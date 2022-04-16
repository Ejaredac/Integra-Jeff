
namespace IntegraJeff
{
    partial class FrmMantenimientos
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
            this.pnlMantenimientoSeleccionado = new System.Windows.Forms.Panel();
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
            this.pnlEspacioTabla = new System.Windows.Forms.Panel();
            this.pnlTablaDatos = new System.Windows.Forms.Panel();
            this.dtgMantenimiento = new System.Windows.Forms.DataGridView();
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
            this.pnlMantenimientoSeleccionado.SuspendLayout();
            this.pnlEspacioTabla.SuspendLayout();
            this.pnlTablaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMantenimiento)).BeginInit();
            this.pnlControlesTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMantenimientoSeleccionado
            // 
            this.pnlMantenimientoSeleccionado.Controls.Add(this.dtpFechaPago);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.lblFechaPago);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.dtpFechaReparacion);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.lblFechaReparacion);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.txtDescripcion);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.lblDescripcion);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.txtMecanico);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.lblMecanico);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.txtCosto);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.lblCosto);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.txtIdUnidad);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.lblUnidad);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.txtIdMantenimiento);
            this.pnlMantenimientoSeleccionado.Controls.Add(this.lblIdMantenimiento);
            this.pnlMantenimientoSeleccionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMantenimientoSeleccionado.Location = new System.Drawing.Point(0, 0);
            this.pnlMantenimientoSeleccionado.Name = "pnlMantenimientoSeleccionado";
            this.pnlMantenimientoSeleccionado.Size = new System.Drawing.Size(885, 247);
            this.pnlMantenimientoSeleccionado.TabIndex = 0;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(380, 153);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(220, 20);
            this.dtpFechaPago.TabIndex = 13;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(258, 156);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 12;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // dtpFechaReparacion
            // 
            this.dtpFechaReparacion.Location = new System.Drawing.Point(380, 104);
            this.dtpFechaReparacion.Name = "dtpFechaReparacion";
            this.dtpFechaReparacion.Size = new System.Drawing.Size(220, 20);
            this.dtpFechaReparacion.TabIndex = 11;
            // 
            // lblFechaReparacion
            // 
            this.lblFechaReparacion.AutoSize = true;
            this.lblFechaReparacion.Location = new System.Drawing.Point(258, 107);
            this.lblFechaReparacion.Name = "lblFechaReparacion";
            this.lblFechaReparacion.Size = new System.Drawing.Size(116, 13);
            this.lblFechaReparacion.TabIndex = 10;
            this.lblFechaReparacion.Text = "Fecha de Reaparacion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(324, 59);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(255, 62);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtMecanico
            // 
            this.txtMecanico.Location = new System.Drawing.Point(112, 208);
            this.txtMecanico.Name = "txtMecanico";
            this.txtMecanico.Size = new System.Drawing.Size(100, 20);
            this.txtMecanico.TabIndex = 7;
            // 
            // lblMecanico
            // 
            this.lblMecanico.AutoSize = true;
            this.lblMecanico.Location = new System.Drawing.Point(54, 211);
            this.lblMecanico.Name = "lblMecanico";
            this.lblMecanico.Size = new System.Drawing.Size(54, 13);
            this.lblMecanico.TabIndex = 6;
            this.lblMecanico.Text = "Mecanico";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(112, 157);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 5;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(71, 160);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 4;
            this.lblCosto.Text = "Costo";
            // 
            // txtIdUnidad
            // 
            this.txtIdUnidad.Location = new System.Drawing.Point(112, 107);
            this.txtIdUnidad.Name = "txtIdUnidad";
            this.txtIdUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtIdUnidad.TabIndex = 3;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(54, 110);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(52, 13);
            this.lblUnidad.TabIndex = 2;
            this.lblUnidad.Text = "id Unidad";
            // 
            // txtIdMantenimiento
            // 
            this.txtIdMantenimiento.Location = new System.Drawing.Point(112, 59);
            this.txtIdMantenimiento.Name = "txtIdMantenimiento";
            this.txtIdMantenimiento.Size = new System.Drawing.Size(100, 20);
            this.txtIdMantenimiento.TabIndex = 1;
            // 
            // lblIdMantenimiento
            // 
            this.lblIdMantenimiento.AutoSize = true;
            this.lblIdMantenimiento.Location = new System.Drawing.Point(18, 62);
            this.lblIdMantenimiento.Name = "lblIdMantenimiento";
            this.lblIdMantenimiento.Size = new System.Drawing.Size(88, 13);
            this.lblIdMantenimiento.TabIndex = 0;
            this.lblIdMantenimiento.Text = "Id Mantenimiento";
            // 
            // pnlEspacioTabla
            // 
            this.pnlEspacioTabla.Controls.Add(this.pnlTablaDatos);
            this.pnlEspacioTabla.Controls.Add(this.pnlControlesTabla);
            this.pnlEspacioTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEspacioTabla.Location = new System.Drawing.Point(0, 247);
            this.pnlEspacioTabla.Name = "pnlEspacioTabla";
            this.pnlEspacioTabla.Size = new System.Drawing.Size(885, 307);
            this.pnlEspacioTabla.TabIndex = 6;
            // 
            // pnlTablaDatos
            // 
            this.pnlTablaDatos.Controls.Add(this.dtgMantenimiento);
            this.pnlTablaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTablaDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlTablaDatos.Name = "pnlTablaDatos";
            this.pnlTablaDatos.Size = new System.Drawing.Size(609, 307);
            this.pnlTablaDatos.TabIndex = 1;
            // 
            // dtgMantenimiento
            // 
            this.dtgMantenimiento.AllowUserToAddRows = false;
            this.dtgMantenimiento.AllowUserToDeleteRows = false;
            this.dtgMantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgMantenimiento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMantenimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.dtgMantenimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgMantenimiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgMantenimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMantenimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMantenimiento.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMantenimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMantenimiento.EnableHeadersVisualStyles = false;
            this.dtgMantenimiento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.dtgMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.dtgMantenimiento.Name = "dtgMantenimiento";
            this.dtgMantenimiento.ReadOnly = true;
            this.dtgMantenimiento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMantenimiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgMantenimiento.RowHeadersVisible = false;
            this.dtgMantenimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMantenimiento.Size = new System.Drawing.Size(609, 307);
            this.dtgMantenimiento.TabIndex = 1;
            this.dtgMantenimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMantenimiento_CellClick);
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
            this.pnlControlesTabla.Location = new System.Drawing.Point(609, 0);
            this.pnlControlesTabla.Name = "pnlControlesTabla";
            this.pnlControlesTabla.Size = new System.Drawing.Size(276, 307);
            this.pnlControlesTabla.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(189, 272);
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
            this.btnEditar.Location = new System.Drawing.Point(122, 189);
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
            this.btnAgregar.Location = new System.Drawing.Point(14, 189);
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
            // FrmMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 554);
            this.Controls.Add(this.pnlEspacioTabla);
            this.Controls.Add(this.pnlMantenimientoSeleccionado);
            this.Name = "FrmMantenimientos";
            this.Text = "FrmMantenimientos";
            this.Load += new System.EventHandler(this.FrmMantenimientos_Load);
            this.pnlMantenimientoSeleccionado.ResumeLayout(false);
            this.pnlMantenimientoSeleccionado.PerformLayout();
            this.pnlEspacioTabla.ResumeLayout(false);
            this.pnlTablaDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMantenimiento)).EndInit();
            this.pnlControlesTabla.ResumeLayout(false);
            this.pnlControlesTabla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMantenimientoSeleccionado;
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
        private System.Windows.Forms.Panel pnlEspacioTabla;
        private System.Windows.Forms.Panel pnlTablaDatos;
        private System.Windows.Forms.DataGridView dtgMantenimiento;
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
    }
}