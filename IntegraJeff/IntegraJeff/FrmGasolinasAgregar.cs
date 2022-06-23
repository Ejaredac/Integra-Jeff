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
    public partial class FrmGasolinasAgregar : Form
    {
        public FrmGasolinasAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = @"INSERT INTO `integrajeffschm`.`gasolinas`
(`idunidades`,
`tipo`,
`litros`,
`total`,
`idconductor`,
`tarjeta`,
`fechacarga`)
VALUES
(@iduni,
@tipo,
@litros,
@total,
@idcond,
@tarj,
@fecha);";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@iduni", int.Parse(txtIdUnidad.Text));
                mscCommand.Parameters.AddWithValue("@tipo", cboTipo.Text);
                mscCommand.Parameters.AddWithValue("@litros", double.Parse(txtLitros.Text));
                mscCommand.Parameters.AddWithValue("@total", double.Parse(txtTotal.Text));
                mscCommand.Parameters.AddWithValue("@idcond", int.Parse(txtIdConductor.Text));
                mscCommand.Parameters.AddWithValue("@tarj", txtTarjeta.Text);
                mscCommand.Parameters.AddWithValue("@fecha", dtpFechaCarga.Value);
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
        private void NotVacio(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (string.IsNullOrEmpty((sender as TextBox).Text)) ? "0" : (sender as TextBox).Text;
        }
        private void IntAllow(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }
        private void DoublePress(object sender, KeyPressEventArgs e)
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

        private void btnConvLitAGal_Click(object sender, EventArgs e)
        {
            txtGalones.Text = (double.Parse(txtLitros.Text) / 3.78541).ToString();
        }

        private void btnConvGalALit_Click(object sender, EventArgs e)
        {
            txtLitros.Text = (double.Parse(txtGalones.Text) * 3.78541).ToString();
        }

        private void btnSelcUnidad_Click(object sender, EventArgs e)
        {
            Unidad uni = new Unidad();
            FrmUnidades frUn = new FrmUnidades(uni);
            frUn.ShowDialog();
            txtIdUnidad.Text = uni.IdUnidad.ToString();
            txtUnidad.Text = uni.Numero;
        }

        private void btnSelcCond_Click(object sender, EventArgs e)
        {
            Conductor cond = new Conductor();
            FrmConductor frmCondu = new FrmConductor(cond);
            frmCondu.ShowDialog();
            txtIdConductor.Text = cond.IDConductor.ToString();
            txtConductor.Text = cond.Nombre;
        }
    }
}
