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
    public partial class FrmUnidadesAgregar : Form
    {
        public FrmUnidadesAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = "INSERT INTO `integrajeffschm`.`unidades` (`Numero`, `Tipo`, `Descripcion`, `Estado`) VALUES (@num, @tip, @desc, @est);";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@num", txtNumero.Text);
                mscCommand.Parameters.AddWithValue("@tip", txtTipo.Text);
                mscCommand.Parameters.AddWithValue("@desc", txtDescripcion.Text);
                mscCommand.Parameters.AddWithValue("@est", txtEstado.Text);
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
