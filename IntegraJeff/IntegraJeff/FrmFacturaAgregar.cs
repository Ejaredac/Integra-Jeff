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
    public partial class FrmFacturaAgregar : Form
    {
        public FrmFacturaAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = @"INSERT INTO `integrajeffschm`.`remisionesyfacturas`
(`NombreCliente`,
`Numero`,
`FechaFactura`,
`Dolares`,
`TipoCambio`,
`SubtotalPesos`,
`Iva`,
`Retencion`,
`TotalPesos`,
`FechaPago`,
`FechaVencimiento`,
`EstatusCobro`)
VALUES
(@nomb,
@num,
@ffact,
@dol,
@tpc,
@stp,
@iva,
@ret,
@totp,
@fpag,
@fven,
@est);";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@nomb", txtNombreCliente.Text);
                mscCommand.Parameters.AddWithValue("@num", txtNumeroFactura.Text);
                mscCommand.Parameters.AddWithValue("@ffact", dtpFechaFactura.Value.Date);
                mscCommand.Parameters.AddWithValue("@dol", double.Parse(txtDolares.Text));
                mscCommand.Parameters.AddWithValue("@tpc", double.Parse(txtTipoCambio.Text));
                mscCommand.Parameters.AddWithValue("@stp", double.Parse(txtSubtotalPesos.Text));
                mscCommand.Parameters.AddWithValue("@iva", double.Parse(txtIva.Text));
                mscCommand.Parameters.AddWithValue("@ret", double.Parse(txtRetencion.Text));
                mscCommand.Parameters.AddWithValue("@totp", double.Parse(txtTotalPesos.Text));
                mscCommand.Parameters.AddWithValue("@fpag", dtpFechaPago.Value.Date);
                mscCommand.Parameters.AddWithValue("@fven", dtpFechaVencimiento.Value.Date);
                mscCommand.Parameters.AddWithValue("@est", chkEstatusCobro.Checked);
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

        private void txtDolares_TextChanged(object sender, EventArgs e)
        {
            txtDolares.Text = (string.IsNullOrEmpty(txtDolares.Text)) ? "0" : txtDolares.Text;

        }

        private void txtDolares_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTipoCambio_TextChanged(object sender, EventArgs e)
        {
            txtTipoCambio.Text = (string.IsNullOrEmpty(txtTipoCambio.Text)) ? "0" : txtTipoCambio.Text;

        }

        private void txtTipoCambio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSubtotalPesos_TextChanged(object sender, EventArgs e)
        {
            txtSubtotalPesos.Text = (string.IsNullOrEmpty(txtSubtotalPesos.Text)) ? "0" : txtSubtotalPesos.Text;

        }

        private void txtSubtotalPesos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIva_TextChanged(object sender, EventArgs e)
        {
            txtIva.Text = (string.IsNullOrEmpty(txtIva.Text)) ? "0" : txtIva.Text;

        }

        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRetencion_TextChanged(object sender, EventArgs e)
        {
            txtRetencion.Text = (string.IsNullOrEmpty(txtRetencion.Text)) ? "0" : txtRetencion.Text;

        }

        private void txtRetencion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTotalPesos_TextChanged(object sender, EventArgs e)
        {
            txtTotalPesos.Text = (string.IsNullOrEmpty(txtTotalPesos.Text)) ? "0" : txtTotalPesos.Text;

        }

        private void txtTotalPesos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            Cliente clie = new Cliente();
            FrmClientes fcl = new FrmClientes(clie);
            fcl.ShowDialog();
            txtNombreCliente.Text = clie.Nombre;
        }
    }
}
