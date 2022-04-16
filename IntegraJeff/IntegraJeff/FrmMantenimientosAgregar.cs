using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegraJeff
{
    public partial class FrmMantenimientosAgregar : Form
    {
        public FrmMantenimientosAgregar()
        {
            InitializeComponent();
        }

        private void txtIdUnidad_TextChanged(object sender, EventArgs e)
        {
            txtIdUnidad.Text = (string.IsNullOrEmpty(txtIdUnidad.Text)) ? "0" : txtIdUnidad.Text;
        }

        private void txtIdUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            txtCosto.Text = (string.IsNullOrEmpty(txtCosto.Text)) ? "0" : txtCosto.Text;
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSeleccionarUnidad_Click(object sender, EventArgs e)
        {
            Unidad sel = new Unidad();
            FrmUnidades uni = new FrmUnidades(sel);
            uni.ShowDialog();
            txtIdUnidad.Text = sel.IdUnidad.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = @"INSERT INTO `integrajeffschm`.`mantenimientos`
(`idUnidades`,
`Costo`,
`Mecanico`,
`Descripcion`,
`FechaReparacion`,
`FechaPago`)
VALUES
(@iduni,
@cos,
@mec,
@desc,
@frep,
@fpag);";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@iduni",int.Parse(txtIdUnidad.Text));
                mscCommand.Parameters.AddWithValue("@cos",double.Parse(txtCosto.Text));
                mscCommand.Parameters.AddWithValue("@mec",txtMecanico.Text);
                mscCommand.Parameters.AddWithValue("@desc", txtDescripcion.Text);
                mscCommand.Parameters.AddWithValue("@frep",dtpFechaReparacion.Value);
                mscCommand.Parameters.AddWithValue("@fpag",dtpFechaPago.Value);
                conn.Open();
                mscCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
