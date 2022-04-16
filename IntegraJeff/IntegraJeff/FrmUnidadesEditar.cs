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
    public partial class FrmUnidadesEditar : Form
    {
        private Unidad _undUnidadActual;

        public Unidad UnidadActual
        {
            get { return _undUnidadActual; }
            set { _undUnidadActual = value; }
        }

        public FrmUnidadesEditar()
        {
            InitializeComponent();
        }
        public FrmUnidadesEditar(Unidad enviado)
        {
            InitializeComponent();
            UnidadActual = enviado;
        }

        private void FrmUnidadesEditar_Load(object sender, EventArgs e)
        {
            txtIdUnidad.Text = UnidadActual.IdUnidad.ToString();
            txtDescripcion.Text = UnidadActual.Descripcion;
            txtEstado.Text = UnidadActual.Estado;
            txtNumero.Text = UnidadActual.Numero;
            txtTipo.Text = UnidadActual.Tipo;
            txtIdUnidad.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = "UPDATE `integrajeffschm`.`unidades` SET `Numero` = @num, `Tipo` = @tip, `Descripcion` = @desc, `Estado` = @est WHERE `idUnidades` = @id;";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@id",UnidadActual.IdUnidad);
                mscCommand.Parameters.AddWithValue("@num",txtNumero.Text);
                mscCommand.Parameters.AddWithValue("@tip",txtTipo.Text);
                mscCommand.Parameters.AddWithValue("@desc",txtDescripcion.Text);
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
