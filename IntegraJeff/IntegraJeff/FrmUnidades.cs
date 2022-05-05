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
    public partial class FrmUnidades : Form
    {
        int intCantidadDeRegistros = 50;
        int varPagIndice = 0;
        string[] matrVars = new string[5];
        private Unidad _unidUnidadActual;

        public Unidad UnidadActual
        {
            get { return _unidUnidadActual; }
            set { _unidUnidadActual = value; }
        }


        public FrmUnidades()
        {
            InitializeComponent();
            UnidadActual = new Unidad();
        }
        public FrmUnidades(Unidad enviado)
        {
            InitializeComponent();
            UnidadActual = enviado;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void FrmUnidades_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < matrVars.Length; i++)
            {
                matrVars[i] = "";
            }
            cboPagina.Items.Add(1);
        }

        private void cboPagina_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                varPagIndice = cboPagina.SelectedIndex;
                if (chkBusqueda.Checked)
                {
                    ActualizarPaginasBusqueda();
                }
                else
                {
                    ActualizarPaginasNormal();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkBusqueda.Checked)
                {
                    ActualizarPaginasBusqueda();
                }
                else
                {
                    ActualizarPaginasNormal();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chkBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cboPagina.SelectedIndex = 0;
                varPagIndice = cboPagina.SelectedIndex;
                if (chkBusqueda.Checked)
                {
                    ActualizarPaginasBusqueda();
                }
                else
                {
                    ActualizarPaginasNormal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmUnidadesBuscar busc = new FrmUnidadesBuscar(matrVars);
            busc.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmUnidadesAgregar agr = new FrmUnidadesAgregar();
            agr.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmUnidadesEditar edi = new FrmUnidadesEditar(UnidadActual);
            edi.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ConexionBD.UsuarioActual.Rol.Equals("Administrador"))
            {
                if (MessageBox.Show("¿Desea eliminar este cliente?", "ELIMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlConnection conn = ConexionBD.Conexion;
                    try
                    {
                        string strOrder = "DELETE FROM `integrajeffschm`.`unidades` WHERE idUnidades = @id";
                        MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                        mscCommand.Parameters.AddWithValue("@id", UnidadActual.IdUnidad);
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
                    UnidadActual.IdUnidad = 0;
                    foreach (Control txt in pnlUnidadSeleccionada.Controls)
                    {
                        txt.Text = (txt is TextBox) ? "" : txt.Text;
                    }
                    txtIdUnidad.Text = "0";
                } 
            }
            else
            {
                MessageBox.Show("Usted no puede eliminar porque no es administrador");
            }
        }

        private void dtgUnidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            MySqlConnection conn = ConexionBD.Conexion;
            int intFila = e.RowIndex;
            try
            {
                int intId = int.Parse(dtgUnidad.Rows[intFila].Cells[0].Value.ToString());
                string strQuery = $"select * from unidades where idUnidades = {intId};";
                MySqlCommand mscCommand = new MySqlCommand(strQuery, conn);

                conn.Open();
                MySqlDataReader msdrLector = mscCommand.ExecuteReader();
                if (msdrLector.HasRows)
                {
                    if (msdrLector.Read())
                    {
                        UnidadActual.IdUnidad = msdrLector.GetInt32("idUnidades");
                        UnidadActual.Numero = msdrLector.GetString("Numero");
                        UnidadActual.Tipo = msdrLector.GetString("Tipo");
                        UnidadActual.Descripcion = msdrLector.GetString("Descripcion");
                        UnidadActual.Estado = msdrLector.GetString("Estado");
                    }
                }
                txtIdUnidad.Text = UnidadActual.IdUnidad.ToString();
                txtNumero.Text = UnidadActual.Numero;
                txtTipo.Text = UnidadActual.Tipo;
                txtDescripcion.Text = UnidadActual.Descripcion;
                txtEstado.Text = UnidadActual.Estado;
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
        void ActualizarPaginasNormal()
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strComando = "CALL `integrajeffschm`.`sp_listar_unidades`(@tabinicio, @tabfinal);";
                MySqlCommand mscCommand = new MySqlCommand(strComando, conn);
                mscCommand.Parameters.AddWithValue("@tabinicio", cboPagina.SelectedIndex * intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@tabfinal", intCantidadDeRegistros);
                MySqlDataAdapter datostablas = new MySqlDataAdapter(mscCommand);
                conn.Open();

                DataSet dt = new DataSet();
                datostablas.Fill(dt);
                int _intTotalRegistros = int.Parse(dt.Tables[0].Rows[0][0].ToString());
                int cantidad = _intTotalRegistros / intCantidadDeRegistros;
                if (_intTotalRegistros % intCantidadDeRegistros > 0)
                {
                    cantidad++;
                }
                txtCantidadPaginas.Text = cantidad.ToString();
                txtRegistrosTotales.Text = _intTotalRegistros.ToString();
                cboPagina.Items.Clear();
                for (int i = 0; i < cantidad; i++)
                {
                    cboPagina.Items.Add(i + 1);
                }
                cboPagina.SelectedIndex = varPagIndice;
                dtgUnidad.DataSource = dt.Tables[1];

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

        void ActualizarPaginasBusqueda()
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strComando = "CALL `integrajeffschm`.`sp_listar_unidades_buscar`(@tabinicio, @tabfinal, @id, @num, @tip, @desc, @est);";
                MySqlCommand mscCommand = new MySqlCommand(strComando, conn);
                mscCommand.Parameters.AddWithValue("@tabinicio", cboPagina.SelectedIndex * intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@tabfinal", intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@id", matrVars[0]);
                mscCommand.Parameters.AddWithValue("@num", matrVars[1]);
                mscCommand.Parameters.AddWithValue("@tip", matrVars[2]);
                mscCommand.Parameters.AddWithValue("@desc", matrVars[3]);
                mscCommand.Parameters.AddWithValue("@est", matrVars[4]);
                MySqlDataAdapter datostablas = new MySqlDataAdapter(mscCommand);
                conn.Open();

                DataSet dt = new DataSet();
                datostablas.Fill(dt);
                int _intTotalRegistros = int.Parse(dt.Tables[0].Rows[0][0].ToString());
                int cantidad = _intTotalRegistros / intCantidadDeRegistros;
                if (_intTotalRegistros % intCantidadDeRegistros > 0)
                {
                    cantidad++;
                }
                txtCantidadPaginas.Text = cantidad.ToString();
                txtRegistrosTotales.Text = _intTotalRegistros.ToString();
                cboPagina.Items.Clear();
                for (int i = 0; i < cantidad; i++)
                {
                    cboPagina.Items.Add(i + 1);
                }
                cboPagina.SelectedIndex = varPagIndice;
                dtgUnidad.DataSource = dt.Tables[1];

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
