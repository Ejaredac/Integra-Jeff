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
    public partial class FrmFacturaEditar : Form
    {
        private Factura _fctFacturaActual;

        public Factura FacturaActual
        {
            get { return _fctFacturaActual; }
            set { _fctFacturaActual = value; }
        }

        public FrmFacturaEditar()
        {
            InitializeComponent();
        }

        public FrmFacturaEditar(Factura enviado)
        {
            InitializeComponent();
            FacturaActual = enviado;
        }
        private void FrmFacturaEditar_Load(object sender, EventArgs e)
        {
            txtDolares.Text = FacturaActual.Dolares.ToString();
            txtIdRemisionesYFacturas.Text = FacturaActual.IdRemisionesFactura.ToString();
            txtIva.Text = FacturaActual.Iva.ToString();
            txtNombreCliente.Text = FacturaActual.NombreCliente;
            txtNumeroFactura.Text = FacturaActual.Numero;
            txtRetencion.Text = FacturaActual.Retencion.ToString();
            txtSubtotalPesos.Text = FacturaActual.SubtotalPesos.ToString();
            txtTipoCambio.Text = FacturaActual.TipoCambio.ToString();
            txtTotalPesos.Text = FacturaActual.TotalPesos.ToString();
            dtpFechaFactura.Value = FacturaActual.FechaFactura;
            dtpFechaPago.Value = FacturaActual.FechaPago;
            dtpFechaVencimiento.Value = FacturaActual.FechaVencimiento;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = @"UPDATE `integrajeffschm`.`remisionesyfacturas`
SET
`NombreCliente` = @nomb,
`Numero` = @num,
`FechaFactura` = @ffact,
`Dolares` = @dol,
`TipoCambio` = @tpc,
`SubtotalPesos` = @stp,
`Iva` = @iva,
`Retencion` = @ret,
`TotalPesos` = @totp,
`FechaPago` = @fpag,
`FechaVencimiento` = @fven,
`EstatusCobro` = @est
WHERE `idRemisionesYFacturas` = @id;";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@nomb", txtNombreCliente.Text);
                mscCommand.Parameters.AddWithValue("@num", txtNumeroFactura.Text);
                mscCommand.Parameters.AddWithValue("@ffact", dtpFechaFactura.Value);
                mscCommand.Parameters.AddWithValue("@dol", double.Parse(txtDolares.Text));
                mscCommand.Parameters.AddWithValue("@tpc", double.Parse(txtTipoCambio.Text));
                mscCommand.Parameters.AddWithValue("@stp", double.Parse(txtSubtotalPesos.Text));
                mscCommand.Parameters.AddWithValue("@iva", double.Parse(txtIva.Text));
                mscCommand.Parameters.AddWithValue("@ret", double.Parse(txtRetencion.Text));
                mscCommand.Parameters.AddWithValue("@totp", double.Parse(txtTotalPesos.Text));
                mscCommand.Parameters.AddWithValue("@fpag", dtpFechaPago.Value);
                mscCommand.Parameters.AddWithValue("@fven", dtpFechaVencimiento.Value);
                mscCommand.Parameters.AddWithValue("@est", chkEstatusCobro.Checked);
                mscCommand.Parameters.AddWithValue("@id", FacturaActual.IdRemisionesFactura);
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
            txtDolares.Text = (string.IsNullOrEmpty(txtDolares.Text)) ? "0":txtDolares.Text;
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

        private void txtTotalPesos_TextChanged(object sender, EventArgs e)
        {
            txtTotalPesos.Text = (string.IsNullOrEmpty(txtTotalPesos.Text)) ? "0" : txtTotalPesos.Text;
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
