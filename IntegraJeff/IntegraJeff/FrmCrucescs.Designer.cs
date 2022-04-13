
namespace IntegraJeff
{
    partial class FrmCrucescs
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
            this.pnlDatosCruceSeleccionado = new System.Windows.Forms.Panel();
            this.pnlTablaControles = new System.Windows.Forms.Panel();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.dtgUsurios = new System.Windows.Forms.DataGridView();
            this.pnlTablaControles.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsurios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatosCruceSeleccionado
            // 
            this.pnlDatosCruceSeleccionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatosCruceSeleccionado.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosCruceSeleccionado.Name = "pnlDatosCruceSeleccionado";
            this.pnlDatosCruceSeleccionado.Size = new System.Drawing.Size(1226, 367);
            this.pnlDatosCruceSeleccionado.TabIndex = 0;
            // 
            // pnlTablaControles
            // 
            this.pnlTablaControles.Controls.Add(this.pnlTabla);
            this.pnlTablaControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTablaControles.Location = new System.Drawing.Point(0, 367);
            this.pnlTablaControles.Name = "pnlTablaControles";
            this.pnlTablaControles.Size = new System.Drawing.Size(1226, 331);
            this.pnlTablaControles.TabIndex = 1;
            // 
            // pnlTabla
            // 
            this.pnlTabla.Controls.Add(this.dtgUsurios);
            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTabla.Location = new System.Drawing.Point(0, 0);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(918, 331);
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
            this.dtgUsurios.Location = new System.Drawing.Point(0, 0);
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
            this.dtgUsurios.Size = new System.Drawing.Size(918, 331);
            this.dtgUsurios.TabIndex = 1;
            // 
            // FrmCrucescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 698);
            this.Controls.Add(this.pnlTablaControles);
            this.Controls.Add(this.pnlDatosCruceSeleccionado);
            this.Name = "FrmCrucescs";
            this.Text = "FrmCrucescs";
            this.pnlTablaControles.ResumeLayout(false);
            this.pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsurios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatosCruceSeleccionado;
        private System.Windows.Forms.Panel pnlTablaControles;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.DataGridView dtgUsurios;
    }
}