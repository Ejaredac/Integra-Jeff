using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace IntegraJeff
{
    public partial class FrnUsuarioEmpleado : Form
    {
        private Usuario _userActUsuario;

        public Usuario ActUsuario
        {
            get { return _userActUsuario; }
            set { _userActUsuario = value; }
        }

        public FrnUsuarioEmpleado()
        {
            InitializeComponent();
        }
        public FrnUsuarioEmpleado(Usuario user)
        {
            InitializeComponent();
            user = Usuario.ObtenerUsuario(user.IdUsuario);
            ActUsuario = user;

        }

        private void FrnUsuarioEmpleado_Load(object sender, EventArgs e)
        {
            txtContrasenna.Text = ActUsuario.Contrasenna;
            txtEmail.Text = ActUsuario.Email;
            txtIDusuario.Text = ActUsuario.IdUsuario.ToString();
            txtIDusuario.Enabled = false;
            txtNombreUsuario.Text = ActUsuario.NombreUsuario;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string strOrder =   
                "UPDATE `integrajeffschm`.`users`\n" +
                "SET\n" +
                "username = @username,\n" +
                "email = @email,\n" +
                "password = @pass\n" +
                "WHERE `idusers` = @id;";
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                MySqlCommand mscComando = new MySqlCommand(strOrder, conn);
                conn.Open();
                mscComando.Parameters.AddWithValue("@username", txtNombreUsuario.Text);
                mscComando.Parameters.AddWithValue("@email", txtEmail.Text);
                mscComando.Parameters.AddWithValue("@pass", txtContrasenna.Text);
                mscComando.Parameters.AddWithValue("@id", ActUsuario.IdUsuario);
                mscComando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
