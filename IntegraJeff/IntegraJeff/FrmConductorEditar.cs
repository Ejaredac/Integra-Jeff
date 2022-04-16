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
    public partial class FrmConductorEditar : Form
    {
        private Conductor _cndConductorActual;

        public Conductor ConductorActual
        {
            get { return _cndConductorActual; }
            set { _cndConductorActual = value; }
        }

        public FrmConductorEditar()
        {
            InitializeComponent();
        }
        public FrmConductorEditar(Conductor enviado)
        {
            InitializeComponent();
            ConductorActual = enviado;
        }

        private void FrmConductorEditar_Load(object sender, EventArgs e)
        {
            txtIdConductor.Text = ConductorActual.IDConductor.ToString();
            txtNombre.Text = ConductorActual.Nombre;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = "UPDATE `integrajeffschm`.`conductores` SET `Nombre` = @nom WHERE `idConductores` = @id";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@id", ConductorActual.IDConductor);
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
