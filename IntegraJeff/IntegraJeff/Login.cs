using MySql;
using MySql.Data;
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
    public partial class Login : Form
    {
        private Registro _rgRegi;

        public Registro Regi
        {
            get { return _rgRegi; }
            set { _rgRegi = value; }
        }

        #region Constructores
        public Login()
        {
            InitializeComponent();
        }

        public Login(Registro reg)
        {
            InitializeComponent();
            Regi = reg;
        }
        #endregion
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //Se muestra la venta de registro y se cierra esta
            Regi.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se cierra la aplicacion cuando se cierre la ventana.
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Seleccionar conexion
            MySqlConnection conexion = ConexionBD.Conexion;

            //Comando de seleccion
            string strCommando = "SELECT * FROM integrajeffschm.users\n" +
                $"where users.username ='{txtUsuario.Text}' and users.password = '{txtContrasenna.Text}'";

            try
            {
                //Establecer comando
                MySqlCommand mscCommand = new MySqlCommand(strCommando, conexion);

                //Adicion de parametros
                //mscCommand.Parameters.AddWithValue("use", txtUsuario);
                //mscCommand.Parameters.AddWithValue("pass", txtContrasenna);

                

                //Abrir conexion
                conexion.Open();
                mscCommand.Prepare();
                //Hacer nuevo usuario
                Usuario usuario = new Usuario();

                //Ejecutar lector
                MySqlDataReader lector = mscCommand.ExecuteReader();

                
                //El lector leyo
                if (lector.Read())
                {

                    //Establcer variables al usuario
                    usuario.Confirmado = lector.GetBoolean(lector.GetOrdinal("confirmado"));
                    usuario.Contrasenna = lector.GetString(lector.GetOrdinal("password"));
                    usuario.Email = lector.GetString(lector.GetOrdinal("email"));
                    usuario.Rol = lector.GetString(lector.GetOrdinal("rol"));
                    usuario.FechaCreacion = lector.GetDateTime(lector.GetOrdinal("create_time"));
                    usuario.NombreUsuario = lector.GetString(lector.GetOrdinal("username"));
                    usuario.IdUsuario = lector.GetInt32(lector.GetOrdinal("idusers"));
                    MessageBox.Show("Este usuario si existe " + (usuario.Confirmado ? "Y esta confirmado" : "Pero no esta confirmado"));
                    
                    Pantalla_Principal pnpPantalla = new Pantalla_Principal(usuario);
                    pnpPantalla.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Algun dato es incorrecto.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ConexionBD.Configurar("integrajeffschm", "admin", "admin");
            txtContrasenna.UseSystemPasswordChar = true;
        }
    }
}
