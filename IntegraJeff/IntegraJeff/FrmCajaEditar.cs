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
    public partial class FrmCajaEditar : Form
    {
        private Caja _cajCajaActual;

        public Caja CajaActual
        {
            get { return _cajCajaActual; }
            set { _cajCajaActual = value; }
        }

        public FrmCajaEditar()
        {
            InitializeComponent();
        }
        public FrmCajaEditar(Caja enviada)
        {
            InitializeComponent();
            CajaActual = enviada;
        }

        private void FrmCajaEditar_Load(object sender, EventArgs e)
        {
            txtIDCaja.Text = CajaActual.IDCaja.ToString();
            txtNumeroDeCaja.Text = CajaActual.NumeroCaja;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = "UPDATE `integrajeffschm`.`cajas` SET `NumeroCaja` = @num WHERE `idCajas` = @id;";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@num", txtNumeroDeCaja.Text);
                mscCommand.Parameters.AddWithValue("@id", CajaActual.IDCaja);
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
