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
    public partial class FrmClientesEditar : Form
    {
        private Cliente _cltClienteActual;

        public Cliente ClienteActual
        {
            get { return _cltClienteActual; }
            set { _cltClienteActual = value; }
        }

        public FrmClientesEditar()
        {
            InitializeComponent();
        }
        public FrmClientesEditar(Cliente enviado)
        {
            InitializeComponent();
            ClienteActual = enviado;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = "UPDATE `integrajeffschm`.`clientes` SET `Nombre` = @nom, `Direccion` = @dir WHERE `idClientes` = @id;";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@nom", txtNombre.Text);
                mscCommand.Parameters.AddWithValue("@dir", txtDireccion.Text);
                mscCommand.Parameters.AddWithValue("@id", ClienteActual.IDCliente);
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

        private void FrmClientesEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void FrmClientesEditar_Load(object sender, EventArgs e)
        {
            txtIdCliente.Text = ClienteActual.IDCliente.ToString();
            txtDireccion.Text = ClienteActual.Direccion;
            txtNombre.Text = ClienteActual.Nombre;
        }
    }
}
