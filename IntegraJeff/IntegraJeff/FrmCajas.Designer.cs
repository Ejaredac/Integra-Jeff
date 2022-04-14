
namespace IntegraJeff
{
    partial class FrmCajas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTablaCajaSeleccionada = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumeroCaja = new System.Windows.Forms.TextBox();
            this.lblNumeroCaja = new System.Windows.Forms.Label();
            this.txtIDcajas = new System.Windows.Forms.TextBox();
            this.lblIdCajas = new System.Windows.Forms.Label();
            this.pnlEspacioTabla = new System.Windows.Forms.Panel();
            this.pnlTablaDatos = new System.Windows.Forms.Panel();
            this.dtgCajas = new System.Windows.Forms.DataGridView();
            this.pnlControlesTabla = new System.Windows.Forms.Panel();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.chkBusqueda = new System.Windows.Forms.CheckBox();
            this.lblNro = new System.Windows.Forms.Label();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.txtCantidadPaginas = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.cboPagina = new System.Windows.Forms.ComboBox();
            this.txtRegistrosTotales = new System.Windows.Forms.TextBox();
            this.pnlTablaCajaSeleccionada.SuspendLayout();
            this.pnlEspacioTabla.SuspendLayout();
            this.pnlTablaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCajas)).BeginInit();
            this.pnlControlesTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTablaCajaSeleccionada
            // 
            this.pnlTablaCajaSeleccionada.Controls.Add(this.txtNumeroCaja);
            this.pnlTablaCajaSeleccionada.Controls.Add(this.lblNumeroCaja);
            this.pnlTablaCajaSeleccionada.Controls.Add(this.txtIDcajas);
            this.pnlTablaCajaSeleccionada.Controls.Add(this.lblIdCajas);
            this.pnlTablaCajaSeleccionada.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTablaCajaSeleccionada.Location = new System.Drawing.Point(0, 0);
            this.pnlTablaCajaSeleccionada.Name = "pnlTablaCajaSeleccionada";
            this.pnlTablaCajaSeleccionada.Size = new System.Drawing.Size(734, 194);
            this.pnlTablaCajaSeleccionada.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(240, 259);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(114, 176);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(6, 176);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 25);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumeroCaja
            // 
            this.txtNumeroCaja.Location = new System.Drawing.Point(103, 69);
            this.txtNumeroCaja.Name = "txtNumeroCaja";
            this.txtNumeroCaja.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCaja.TabIndex = 3;
            // 
            // lblNumeroCaja
            // 
            this.lblNumeroCaja.AutoSize = true;
            this.lblNumeroCaja.Location = new System.Drawing.Point(12, 69);
            this.lblNumeroCaja.Name = "lblNumeroCaja";
            this.lblNumeroCaja.Size = new System.Drawing.Size(83, 13);
            this.lblNumeroCaja.TabIndex = 2;
            this.lblNumeroCaja.Text = "Numero de Caja";
            // 
            // txtIDcajas
            // 
            this.txtIDcajas.Location = new System.Drawing.Point(103, 33);
            this.txtIDcajas.Name = "txtIDcajas";
            this.txtIDcajas.Size = new System.Drawing.Size(100, 20);
            this.txtIDcajas.TabIndex = 1;
            // 
            // lblIdCajas
            // 
            this.lblIdCajas.AutoSize = true;
            this.lblIdCajas.Location = new System.Drawing.Point(37, 33);
            this.lblIdCajas.Name = "lblIdCajas";
            this.lblIdCajas.Size = new System.Drawing.Size(47, 13);
            this.lblIdCajas.TabIndex = 0;
            this.lblIdCajas.Text = "ID-Cajas";
            // 
            // pnlEspacioTabla
            // 
            this.pnlEspacioTabla.Controls.Add(this.pnlTablaDatos);
            this.pnlEspacioTabla.Controls.Add(this.pnlControlesTabla);
            this.pnlEspacioTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEspacioTabla.Location = new System.Drawing.Point(0, 194);
            this.pnlEspacioTabla.Name = "pnlEspacioTabla";
            this.pnlEspacioTabla.Size = new System.Drawing.Size(734, 294);
            this.pnlEspacioTabla.TabIndex = 1;
            // 
            // pnlTablaDatos
            // 
            this.pnlTablaDatos.Controls.Add(this.dtgCajas);
            this.pnlTablaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTablaDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlTablaDatos.Name = "pnlTablaDatos";
            this.pnlTablaDatos.Size = new System.Drawing.Size(407, 294);
            this.pnlTablaDatos.TabIndex = 1;
            // 
            // dtgCajas
            // 
            this.dtgCajas.AllowUserToAddRows = false;
            this.dtgCajas.AllowUserToDeleteRows = false;
            this.dtgCajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgCajas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgCajas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.dtgCajas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCajas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCajas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCajas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCajas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgCajas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCajas.EnableHeadersVisualStyles = false;
            this.dtgCajas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(136)))), ((int)(((byte)(197)))));
            this.dtgCajas.Location = new System.Drawing.Point(0, 0);
            this.dtgCajas.Name = "dtgCajas";
            this.dtgCajas.ReadOnly = true;
            this.dtgCajas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCajas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgCajas.RowHeadersVisible = false;
            this.dtgCajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCajas.Size = new System.Drawing.Size(407, 294);
            this.dtgCajas.TabIndex = 1;
            this.dtgCajas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCajas_CellClick);
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
            this.pnlControlesTabla.Location = new System.Drawing.Point(407, 0);
            this.pnlControlesTabla.Name = "pnlControlesTabla";
            this.pnlControlesTabla.Size = new System.Drawing.Size(327, 294);
            this.pnlControlesTabla.TabIndex = 0;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusqueda.Location = new System.Drawing.Point(240, 139);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 7;
            this.btnBusqueda.Text = "Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(274, 18);
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
            // FrmCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 488);
            this.Controls.Add(this.pnlEspacioTabla);
            this.Controls.Add(this.pnlTablaCajaSeleccionada);
            this.Name = "FrmCajas";
            this.Text = "FrmCajas";
            this.Load += new System.EventHandler(this.FrmCajas_Load);
            this.pnlTablaCajaSeleccionada.ResumeLayout(false);
            this.pnlTablaCajaSeleccionada.PerformLayout();
            this.pnlEspacioTabla.ResumeLayout(false);
            this.pnlTablaDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCajas)).EndInit();
            this.pnlControlesTabla.ResumeLayout(false);
            this.pnlControlesTabla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTablaCajaSeleccionada;
        private System.Windows.Forms.Panel pnlEspacioTabla;
        private System.Windows.Forms.Panel pnlTablaDatos;
        private System.Windows.Forms.Panel pnlControlesTabla;
        private System.Windows.Forms.DataGridView dtgCajas;
        private System.Windows.Forms.TextBox txtCantidadPaginas;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.ComboBox cboPagina;
        private System.Windows.Forms.TextBox txtRegistrosTotales;
        private System.Windows.Forms.Label lblNro;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.TextBox txtNumeroCaja;
        private System.Windows.Forms.Label lblNumeroCaja;
        private System.Windows.Forms.TextBox txtIDcajas;
        private System.Windows.Forms.Label lblIdCajas;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.CheckBox chkBusqueda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
    }
}