
namespace IntegraJeff
{
    partial class FrmFactura
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
            this.pnlFacturaSeleccionada = new System.Windows.Forms.Panel();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIdRemisionesYFacturas = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtSubtotalPesos = new System.Windows.Forms.TextBox();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.txtTotalPesos = new System.Windows.Forms.TextBox();
            this.txtRetencion = new System.Windows.Forms.TextBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.chkEstatusCobro = new System.Windows.Forms.CheckBox();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblTotalPesos = new System.Windows.Forms.Label();
            this.lblRetencion = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubTotalPesos = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.lblDolares = new System.Windows.Forms.Label();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblIdRemisionesyFacturas = new System.Windows.Forms.Label();
            this.pnlEspacioTabla = new System.Windows.Forms.Panel();
            this.pnlTablaDatos = new System.Windows.Forms.Panel();
            this.dtgFactura = new System.Windows.Forms.DataGridView();
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
            this.pnlFacturaSeleccionada.SuspendLayout();
            this.pnlEspacioTabla.SuspendLayout();
            this.pnlTablaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFactura)).BeginInit();
            this.pnlControlesTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFacturaSeleccionada
            // 
            this.pnlFacturaSeleccionada.AutoScroll = true;
            this.pnlFacturaSeleccionada.Controls.Add(this.dtpFechaFactura);
            this.pnlFacturaSeleccionada.Controls.Add(this.txtNumeroFactura);
            this.pnlFacturaSeleccionada.Controls.Add(this.txtNombreCliente);
            this.pnlFacturaSeleccionada.Controls.Add(this.txtIdRemisionesYFacturas);
            this.pnlFacturaSeleccionada.Controls.Add(this.txtIva);
            this.pnlFacturaSeleccionada.Controls.Add(this.txtSubtotalPesos);
            this.pnlFacturaSeleccionada.Controls.Add(this.txtTipoCambio);
            this.pnlFacturaSeleccionada.Controls.Add(this.txtDolares);
            this.pnlFacturaSeleccionada.Controls.Add(this.txtTotalPesos);
            this.pnlFacturaSeleccionada.Controls.Add(this.txtRetencion);
            this.pnlFacturaSeleccionada.Controls.Add(this.dtpFechaVencimiento);
            this.pnlFacturaSeleccionada.Controls.Add(this.dtpFechaPago);
            this.pnlFacturaSeleccionada.Controls.Add(this.chkEstatusCobro);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblFechaVencimiento);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblFechaPago);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblTotalPesos);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblRetencion);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblIva);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblSubTotalPesos);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblTipoCambio);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblDolares);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblFechaFactura);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblNumero);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblNombreCliente);
            this.pnlFacturaSeleccionada.Controls.Add(this.lblIdRemisionesyFacturas);
            this.pnlFacturaSeleccionada.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFacturaSeleccionada.Location = new System.Drawing.Point(0, 0);
            this.pnlFacturaSeleccionada.Name = "pnlFacturaSeleccionada";
            this.pnlFacturaSeleccionada.Size = new System.Drawing.Size(1071, 191);
            this.pnlFacturaSeleccionada.TabIndex = 0;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Location = new System.Drawing.Point(149, 147);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFactura.TabIndex = 24;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(149, 106);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroFactura.TabIndex = 23;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(149, 66);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 22;
            // 
            // txtIdRemisionesYFacturas
            // 
            this.txtIdRemisionesYFacturas.Location = new System.Drawing.Point(149, 24);
            this.txtIdRemisionesYFacturas.Name = "txtIdRemisionesYFacturas";
            this.txtIdRemisionesYFacturas.Size = new System.Drawing.Size(100, 20);
            this.txtIdRemisionesYFacturas.TabIndex = 21;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(449, 146);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 20);
            this.txtIva.TabIndex = 20;
            // 
            // txtSubtotalPesos
            // 
            this.txtSubtotalPesos.Location = new System.Drawing.Point(449, 107);
            this.txtSubtotalPesos.Name = "txtSubtotalPesos";
            this.txtSubtotalPesos.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalPesos.TabIndex = 19;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(449, 66);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCambio.TabIndex = 18;
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(449, 27);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(100, 20);
            this.txtDolares.TabIndex = 17;
            // 
            // txtTotalPesos
            // 
            this.txtTotalPesos.Location = new System.Drawing.Point(691, 69);
            this.txtTotalPesos.Name = "txtTotalPesos";
            this.txtTotalPesos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPesos.TabIndex = 16;
            // 
            // txtRetencion
            // 
            this.txtRetencion.Location = new System.Drawing.Point(691, 26);
            this.txtRetencion.Name = "txtRetencion";
            this.txtRetencion.Size = new System.Drawing.Size(100, 20);
            this.txtRetencion.TabIndex = 15;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(691, 142);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVencimiento.TabIndex = 14;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(691, 103);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 13;
            // 
            // chkEstatusCobro
            // 
            this.chkEstatusCobro.AutoSize = true;
            this.chkEstatusCobro.Location = new System.Drawing.Point(885, 24);
            this.chkEstatusCobro.Name = "chkEstatusCobro";
            this.chkEstatusCobro.Size = new System.Drawing.Size(107, 17);
            this.chkEstatusCobro.TabIndex = 12;
            this.chkEstatusCobro.Text = "Estatus de Cobro";
            this.chkEstatusCobro.UseVisualStyleBackColor = true;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(573, 148);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(112, 13);
            this.lblFechaVencimiento.TabIndex = 11;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(605, 108);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 10;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblTotalPesos
            // 
            this.lblTotalPesos.AutoSize = true;
            this.lblTotalPesos.Location = new System.Drawing.Point(607, 68);
            this.lblTotalPesos.Name = "lblTotalPesos";
            this.lblTotalPesos.Size = new System.Drawing.Size(78, 13);
            this.lblTotalPesos.TabIndex = 9;
            this.lblTotalPesos.Text = "Total en Pesos";
            // 
            // lblRetencion
            // 
            this.lblRetencion.AutoSize = true;
            this.lblRetencion.Location = new System.Drawing.Point(629, 28);
            this.lblRetencion.Name = "lblRetencion";
            this.lblRetencion.Size = new System.Drawing.Size(56, 13);
            this.lblRetencion.TabIndex = 8;
            this.lblRetencion.Text = "Retencion";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(418, 147);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(24, 13);
            this.lblIva.TabIndex = 7;
            this.lblIva.Text = "IVA";
            // 
            // lblSubTotalPesos
            // 
            this.lblSubTotalPesos.AutoSize = true;
            this.lblSubTotalPesos.Location = new System.Drawing.Point(364, 107);
            this.lblSubTotalPesos.Name = "lblSubTotalPesos";
            this.lblSubTotalPesos.Size = new System.Drawing.Size(78, 13);
            this.lblSubTotalPesos.TabIndex = 6;
            this.lblSubTotalPesos.Text = "Subtotal Pesos";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Location = new System.Drawing.Point(361, 67);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(81, 13);
            this.lblTipoCambio.TabIndex = 5;
            this.lblTipoCambio.Text = "Tipo de Cambio";
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Location = new System.Drawing.Point(399, 27);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(43, 13);
            this.lblDolares.TabIndex = 4;
            this.lblDolares.Text = "Dolares";
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.Location = new System.Drawing.Point(51, 147);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(91, 13);
            this.lblFechaFactura.TabIndex = 3;
            this.lblFechaFactura.Text = "Fecha de Factura";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(44, 107);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(98, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numero de Factura";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(46, 67);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(96, 13);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // lblIdRemisionesyFacturas
            // 
            this.lblIdRemisionesyFacturas.AutoSize = true;
            this.lblIdRemisionesyFacturas.Location = new System.Drawing.Point(12, 27);
            this.lblIdRemisionesyFacturas.Name = "lblIdRemisionesyFacturas";
            this.lblIdRemisionesyFacturas.Size = new System.Drawing.Size(130, 13);
            this.lblIdRemisionesyFacturas.TabIndex = 0;
            this.lblIdRemisionesyFacturas.Text = "id - Remisiones y Facturas";
            // 
            // pnlEspacioTabla
            // 
            this.pnlEspacioTabla.Controls.Add(this.pnlTablaDatos);
            this.pnlEspacioTabla.Controls.Add(this.pnlControlesTabla);
            this.pnlEspacioTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEspacioTabla.Location = new System.Drawing.Point(0, 191);
            this.pnlEspacioTabla.Name = "pnlEspacioTabla";
            this.pnlEspacioTabla.Size = new System.Drawing.Size(1071, 444);
            this.pnlEspacioTabla.TabIndex = 7;
            // 
            // pnlTablaDatos
            // 
            this.pnlTablaDatos.Controls.Add(this.dtgFactura);
            this.pnlTablaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTablaDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlTablaDatos.Name = "pnlTablaDatos";
            this.pnlTablaDatos.Size = new System.Drawing.Size(795, 444);
            this.pnlTablaDatos.TabIndex = 1;
            // 
            // dtgFactura
            // 
            this.dtgFactura.AllowUserToAddRows = false;
            this.dtgFactura.AllowUserToDeleteRows = false;
            this.dtgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.dtgFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFactura.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgFactura.EnableHeadersVisualStyles = false;
            this.dtgFactura.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.dtgFactura.Location = new System.Drawing.Point(0, 0);
            this.dtgFactura.Name = "dtgFactura";
            this.dtgFactura.ReadOnly = true;
            this.dtgFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgFactura.RowHeadersVisible = false;
            this.dtgFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFactura.Size = new System.Drawing.Size(795, 444);
            this.dtgFactura.TabIndex = 1;
            this.dtgFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFactura_CellClick);
            this.dtgFactura.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgFactura_CellFormatting);
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
            this.pnlControlesTabla.Location = new System.Drawing.Point(795, 0);
            this.pnlControlesTabla.Name = "pnlControlesTabla";
            this.pnlControlesTabla.Size = new System.Drawing.Size(276, 444);
            this.pnlControlesTabla.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(189, 409);
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
            this.btnEditar.Location = new System.Drawing.Point(122, 326);
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
            this.btnAgregar.Location = new System.Drawing.Point(14, 326);
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
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 635);
            this.Controls.Add(this.pnlEspacioTabla);
            this.Controls.Add(this.pnlFacturaSeleccionada);
            this.Name = "FrmFactura";
            this.Text = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.pnlFacturaSeleccionada.ResumeLayout(false);
            this.pnlFacturaSeleccionada.PerformLayout();
            this.pnlEspacioTabla.ResumeLayout(false);
            this.pnlTablaDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFactura)).EndInit();
            this.pnlControlesTabla.ResumeLayout(false);
            this.pnlControlesTabla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFacturaSeleccionada;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblTotalPesos;
        private System.Windows.Forms.Label lblRetencion;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubTotalPesos;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblIdRemisionesyFacturas;
        private System.Windows.Forms.Panel pnlEspacioTabla;
        private System.Windows.Forms.Panel pnlTablaDatos;
        private System.Windows.Forms.DataGridView dtgFactura;
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
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIdRemisionesYFacturas;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtSubtotalPesos;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.TextBox txtTotalPesos;
        private System.Windows.Forms.TextBox txtRetencion;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.CheckBox chkEstatusCobro;
        private System.Windows.Forms.Label lblFechaVencimiento;
    }
}