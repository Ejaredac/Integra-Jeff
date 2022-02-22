using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
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
    public partial class Registro : Form
    {
        #region Login
        private Login _lgnLog;

        public Login Log
        {
            get { return _lgnLog; }
            set { _lgnLog = value; }
        }
        #endregion

        #region Constructores
        public Registro()
        {
            InitializeComponent();
        }
        public Registro(Login log)
        {
            InitializeComponent();
            Log = log;
        }
        #endregion


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Se muestra la ventana de regisro y se cierra esta
            Log.Show();
            this.Hide();
        }


        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void Registro_Load(object sender, EventArgs e)
        {
            ConexionBD.Configurar("integrajeffschm", "newuser", "newuser");
            txtConfirmar.UseSystemPasswordChar = true;
            txtContrasenna.UseSystemPasswordChar = true;
            cboRol.SelectedIndex = 1;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            //Verificar si la contraseña esta correctamente verificada y el campo de rol no esta vacio
            if ((txtConfirmar.Text == txtContrasenna.Text))
            {
                if (!(cboRol.Text == "" || cboRol.Text == null))
                {
                    try
                    {
                        Usuario nuevoUsuario = new Usuario
                        {
                            Contrasenna = txtContrasenna.Text,
                            NombreUsuario = txtUsername.Text,
                            Email = txtEmail.Text,
                            Rol = cboRol.Text,
                            Confirmado = false
                        };
                        //Comando de insercion
                        string strComando =
                            "INSERT INTO `integrajeffschm`.`user`\n" +
                            "(`username`,\n" +
                            "`email`,\n" +
                            "`password`,\n" +
                            "`confirmado`,\n" +
                            "`rol`)\n" +
                            "VALUES\n" +
                            "(@username,\n+" +
                            "@email,\n" +
                            "@password,\n" +
                            "@confirmado,\n" +
                            "@rol);\n";
                        ConexionBD.Conexion.Open();
                        MySqlCommand comm = new MySqlCommand(strComando, ConexionBD.Conexion);
                        comm.Parameters.AddWithValue("username", nuevoUsuario.NombreUsuario);
                        comm.Parameters.AddWithValue("password", nuevoUsuario.Contrasenna);
                        comm.Parameters.AddWithValue("email", nuevoUsuario.Email);
                        comm.Parameters.AddWithValue("confirmado", nuevoUsuario.Confirmado);
                        comm.Parameters.AddWithValue("rol", nuevoUsuario.Rol);
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Se agrego usuario. En espera de ser aceptado");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        ConexionBD.Conexion.Close();
                    }
                }
                else
                {
                    MessageBox.Show("El campo de rol no debe estar vacio");
                }
            }
            else
            {
                MessageBox.Show("La contraseña debe estar correctamente rectificada");
            }
        }
    }
}
