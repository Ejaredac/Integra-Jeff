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
    public partial class FrmConductor : Form
    {
        int intCantidadDeRegistros = 50;
        int varPagIndice = 0;
        string[] matrVars = new string[2];
        private Conductor _cndConductorActual;

        public Conductor ConductorActual
        {
            get { return _cndConductorActual; }
            set { _cndConductorActual = value; }
        }

        public FrmConductor()
        {
            InitializeComponent();
            ConductorActual = new Conductor();
        }
        public FrmConductor(Conductor enviado)
        {
            InitializeComponent();
            ConductorActual = enviado;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            int intFila = e.RowIndex;
            try
            {
                int intId = int.Parse(dtgConductores.Rows[intFila].Cells[0].Value.ToString());
                string strQuery = $"select * from `conductores` where idConductores = {intId};";
                MySqlCommand mscCommand = new MySqlCommand(strQuery, conn);

                conn.Open();
                MySqlDataReader msdrLector = mscCommand.ExecuteReader();
                if (msdrLector.HasRows)
                {
                    if (msdrLector.Read())
                    {
                        ConductorActual.IDConductor = msdrLector.GetInt32("idConductores");
                        ConductorActual.Nombre = msdrLector.GetString("Nombre");
                    }
                }
                txtIdConductor.Text = ConductorActual.IDConductor.ToString();
                txtNombre.Text = ConductorActual.Nombre;
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

        private void cboPagina_SelectionChangeCommitted(object sender, EventArgs e)
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

        private void btnRefresh_Click(object sender, EventArgs e)
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

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmConductorBuscar busc = new FrmConductorBuscar(matrVars);
            busc.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmConductorAgregarcs agr = new FrmConductorAgregarcs();
            agr.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmConductorEditar edi = new FrmConductorEditar(ConductorActual);
            edi.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este cliente?", "ELIMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySqlConnection conn = ConexionBD.Conexion;
                try
                {
                    string strOrder = "DELETE FROM `integrajeffschm`.`conductores` WHERE `idConductores` = @id;";
                    MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                    mscCommand.Parameters.AddWithValue("@id", ConductorActual.IDConductor);
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
                ConductorActual.IDConductor = 0;
                ConductorActual.Nombre = "";
                txtIdConductor.Text = ConductorActual.IDConductor.ToString();
                txtNombre.Text = ConductorActual.Nombre;
            }
        }

        private void FrmConductor_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < matrVars.Length; i++)
            {
                matrVars[i] = "";
            }
            cboPagina.Items.Add(1);
        }

        void ActualizarPaginasNormal()
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strComando = "call integrajeffschm.sp_listar_conductores(@tabinicio, @tabfinal);";
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
                dtgConductores.DataSource = dt.Tables[1];

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
                string strComando = "call integrajeffschm.sp_listar_conductores_buscar(@tabinicio, @tabfinal, @id, @nom);";
                MySqlCommand mscCommand = new MySqlCommand(strComando, conn);
                mscCommand.Parameters.AddWithValue("@tabinicio", cboPagina.SelectedIndex * intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@tabfinal", intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@id", matrVars[0]);
                mscCommand.Parameters.AddWithValue("@nom", matrVars[1]);
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
                dtgConductores.DataSource = dt.Tables[1];

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

        private void chkBusqueda_CheckedChanged(object sender, EventArgs e)
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
    }
}
