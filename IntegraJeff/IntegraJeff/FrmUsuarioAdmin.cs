using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace IntegraJeff
{
    public partial class FrmUsuarioAdmin : Form
    {
        public FrmUsuarioAdmin()
        {
            InitializeComponent();
        }
        public FrmUsuarioAdmin(Usuario user)
        {
            InitializeComponent();
        }

        private void dtgUsurios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario usrUsuario = new Usuario();
            MySqlConnection conn = ConexionBD.Conexion;
            int intfila = e.RowIndex;
            
            try
            {
                int id = int.Parse(dtgUsurios.Rows[intfila].Cells[0].Value.ToString());
                string strQuery = $"select * from users where idusers={id};";
                
                MySqlCommand mscCommand = new MySqlCommand(strQuery, conn);
                conn.Open();
                MySqlDataReader msdrLector = mscCommand.ExecuteReader();
                if (msdrLector.HasRows)
                {
                    if (msdrLector.Read())
                    {
                        usrUsuario.Confirmado = msdrLector.GetBoolean("confirmado");
                        usrUsuario.Contrasenna = msdrLector.GetString("password");
                        usrUsuario.Email = msdrLector.GetString("email");
                        usrUsuario.FechaCreacion = msdrLector.GetDateTime("create_time");
                        usrUsuario.IdUsuario = msdrLector.GetInt32("idusers");
                        usrUsuario.NombreUsuario = msdrLector.GetString("username");
                        usrUsuario.Rol = msdrLector.GetString("rol");
                    }
                }
                txtContrasenna.Text = usrUsuario.Contrasenna;
                txtEmail.Text = usrUsuario.Email;
                txtIDusuario.Text = usrUsuario.IdUsuario.ToString();
                txtIDusuario.Enabled = false;
                txtNombreUsuario.Text = usrUsuario.NombreUsuario;
                chkConfirmado.Checked = usrUsuario.Confirmado;
                cboRol.Text = usrUsuario.Rol;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RecargarTabla();

        }

        private void RecargarTabla()
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strComando = "SELECT * FROM integrajeffschm.vistauser;";

                MySqlDataAdapter datostablas = new MySqlDataAdapter(strComando, conn);
                conn.Open();
                DataSet dt = new DataSet();
                dt.Tables.Add("Usuarios");
                datostablas.Fill(dt.Tables["Usuarios"]);
                dtgUsurios.DataSource = dt.Tables["Usuarios"];

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string strOrden =
                "UPDATE `integrajeffschm`.`users`\n" +
                "SET\n" +
                "`username` = @username,\n" +
                "`email` = @email,\n" +
                "`password` = @pass,\n" +
                "`confirmado` = @conf,\n" +
                "`rol` = @rol\n"+
                "WHERE `idusers` = @id;";
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                MySqlCommand mscCommand = new MySqlCommand(strOrden, conn);
                conn.Open();
                mscCommand.Parameters.AddWithValue("@username",txtNombreUsuario.Text);
                mscCommand.Parameters.AddWithValue("@email",txtEmail.Text);
                mscCommand.Parameters.AddWithValue("@pass",txtContrasenna.Text);
                mscCommand.Parameters.AddWithValue("@conf",chkConfirmado.Checked);
                mscCommand.Parameters.AddWithValue("@rol", cboRol.Text);
                mscCommand.Parameters.AddWithValue("@id", int.Parse(txtIDusuario.Text));
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
            RecargarTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string strOrden =
                "INSERT INTO `integrajeffschm`.`users`\n" +
                "(`username`,\n" +
                "`email`,\n" +
                "`password`,\n" +
                "`confirmado`,\n" +
                "`rol`)\n" +
                "VALUES\n" +
                "(@usern,\n" +
                "@email,\n" +
                "@pass,\n" +
                "@conf,\n" +
                "@rol);";
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                MySqlCommand mscCommand = new MySqlCommand(strOrden, conn);
                conn.Open();
                mscCommand.Parameters.AddWithValue("@usern", txtNombreUsuario.Text);
                mscCommand.Parameters.AddWithValue("@email", txtEmail.Text);
                mscCommand.Parameters.AddWithValue("@pass", txtContrasenna.Text);
                mscCommand.Parameters.AddWithValue("@conf", chkConfirmado.Checked);
                mscCommand.Parameters.AddWithValue("@rol", cboRol.Text);
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
            RecargarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string strOrden =
                "DELETE FROM `integrajeffschm`.`users`\n" +
                "WHERE `idusers` = @id;";
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                MySqlCommand mscComando = new MySqlCommand(strOrden, conn);
                conn.Open();
                mscComando.Parameters.AddWithValue("@id", int.Parse(txtIDusuario.Text));
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
            RecargarTabla();
        }
    }
}
