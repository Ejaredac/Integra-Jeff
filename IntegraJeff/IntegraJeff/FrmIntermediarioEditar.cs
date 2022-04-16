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
    public partial class FrmIntermediarioEditar : Form
    {
        private Intermediario _itdIntermediarioActual;

        public Intermediario IntermediarioActual
        {
            get { return _itdIntermediarioActual; }
            set { _itdIntermediarioActual = value; }
        }

        public FrmIntermediarioEditar()
        {
            InitializeComponent();
        }

        public FrmIntermediarioEditar(Intermediario enviado)
        {
            InitializeComponent();
            IntermediarioActual = enviado;
        }

        private void FrmIntermediarioEditar_Load(object sender, EventArgs e)
        {
            txtIdIntermediario.Text = IntermediarioActual.IDIntermediario.ToString();
            txtIdIntermediario.Enabled = false;
            txtNombre.Text = IntermediarioActual.Nombre;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = "UPDATE `integrajeffschm`.`intermediarios` SET `Nombre` = @nom WHERE `idIntermediarios` = @id;";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@id", IntermediarioActual.IDIntermediario);
                mscCommand.Parameters.AddWithValue("@nom", txtNombre.Text);
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
