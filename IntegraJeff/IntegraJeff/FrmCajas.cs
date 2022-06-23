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
    public partial class FrmCajas : Form
    {
        int intCantidadDeRegistros = 50;
        int varPagIndice = 0;
        string[] matrVars = new string[2];
        private Caja _cajCajaActual;

        public Caja CajaActual
        {
            get { return _cajCajaActual; }
            set { _cajCajaActual = value; }
        }

        public FrmCajas()
        {
            InitializeComponent();
            CajaActual = new Caja();
        }
        public FrmCajas(Caja enviado)
        {
            InitializeComponent();
            CajaActual = enviado;
            //btnAgregar.Enabled = false;
            //btnEditar.Enabled = false;
            //btnEliminar.Enabled = false;

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
        void ActualizarPaginasNormal()
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strComando = "call integrajeffschm.sp_listar_cajas(@tabinicio, @tabfinal);";
                MySqlCommand mscCommand = new MySqlCommand(strComando, conn);
                mscCommand.Parameters.AddWithValue("@tabinicio", cboPagina.SelectedIndex * intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@tabfinal", intCantidadDeRegistros);
                MySqlDataAdapter datostablas = new MySqlDataAdapter(mscCommand);
                conn.Open();

                DataSet dt = new DataSet();
                datostablas.Fill(dt);
                int _intTotalRegistros=int.Parse(dt.Tables[0].Rows[0][0].ToString());
                int cantidad = _intTotalRegistros / intCantidadDeRegistros;
                if (_intTotalRegistros%intCantidadDeRegistros >0)
                {
                    cantidad++;
                }
                else if (_intTotalRegistros == 0)
                {
                    cantidad++;
                    varPagIndice = 0;
                }
                txtCantidadPaginas.Text = cantidad.ToString();
                txtRegistrosTotales.Text = _intTotalRegistros.ToString();
                cboPagina.Items.Clear();
                for (int i = 0; i < cantidad; i++)
                {
                    cboPagina.Items.Add(i + 1);
                }
                cboPagina.SelectedIndex = varPagIndice;
                dtgCajas.DataSource = dt.Tables[1];

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
                string strComando = "call integrajeffschm.sp_listar_cajas_buscar(@tabinicio, @tabfinal, @id, @num);";
                MySqlCommand mscCommand = new MySqlCommand(strComando, conn);
                mscCommand.Parameters.AddWithValue("@tabinicio", cboPagina.SelectedIndex * intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@tabfinal", intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@id", matrVars[0]);
                mscCommand.Parameters.AddWithValue("@num", matrVars[1]);
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
                else if (_intTotalRegistros == 0)
                {
                    cantidad++;
                    varPagIndice = 0;
                }
                txtCantidadPaginas.Text = cantidad.ToString();
                txtRegistrosTotales.Text = _intTotalRegistros.ToString();
                cboPagina.Items.Clear();
                for (int i = 0; i < cantidad; i++)
                {
                    cboPagina.Items.Add(i + 1);
                }
                cboPagina.SelectedIndex = varPagIndice;
                dtgCajas.DataSource = dt.Tables[1];

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
        void RecargarNormal()
        {
            ActualizarPaginasNormal();

        }
        void RecargarBusqueda()
        {

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmCajasBuscar busqueda = new FrmCajasBuscar(matrVars);
            busqueda.ShowDialog();
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
                throw;
            }
        }

        private void FrmCajas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < matrVars.Length; i++)
            {
                matrVars[i] = "";
            }
            cboPagina.Items.Add(1);
        }

        private void dtgCajas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            int intFila = e.RowIndex;
            try
            {
                int intId = int.Parse(dtgCajas.Rows[intFila].Cells[0].Value.ToString());
                string strQuery = $"select * from cajas where idCajas={intId};";
                MySqlCommand mscCommand = new MySqlCommand(strQuery, conn);
                conn.Open();
                MySqlDataReader msdrLector = mscCommand.ExecuteReader();
                if (msdrLector.HasRows)
                {
                    if (msdrLector.Read())
                    {
                        CajaActual.IDCaja = msdrLector.GetInt32("idCajas");
                        CajaActual.NumeroCaja = msdrLector.GetString("NumeroCaja");
                    }
                }
                txtIDcajas.Text = CajaActual.IDCaja.ToString();
                txtNumeroCaja.Text = CajaActual.NumeroCaja;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea agregar una caja?","AGREGAR",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                FrmCajaAgregar agr = new FrmCajaAgregar();
                agr.ShowDialog(); 
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea editar esta caja?","EDITAR",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                FrmCajaEditar edi = new FrmCajaEditar(CajaActual);
                edi.ShowDialog(); 
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ConexionBD.UsuarioActual.Rol.Equals("Administrador"))
            {
                if (MessageBox.Show("¿Desea eliminar esta caja?", "ELIMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlConnection conn = ConexionBD.Conexion;
                    try
                    {
                        string strOrder = "DELETE FROM `integrajeffschm`.`cajas` WHERE idCajas = @id;";
                        MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
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
                    CajaActual.IDCaja = 0;
                    CajaActual.NumeroCaja = "";
                    txtNumeroCaja.Text = CajaActual.NumeroCaja;
                    txtIDcajas.Text = CajaActual.IDCaja.ToString();
                } 
            }
            else
            {
                MessageBox.Show("Usted no puede eliminar porque no es administrador");
            }
        }
    }
}
