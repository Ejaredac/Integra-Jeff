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

    public partial class FrmClientes : Form
    {
        int intCantidadDeRegistros = 5;
        int varPagIndice = 0;
        string[] matrVars = new string[3];
        private Cliente _cltClienteActual;

        public Cliente ClienteActual
        {
            get { return _cltClienteActual; }
            set { _cltClienteActual = value; }
        }

        public FrmClientes()
        {
            InitializeComponent();
            ClienteActual = new Cliente();
        }
        public FrmClientes(Cliente enviado)
        {
            InitializeComponent();
            ClienteActual = enviado;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
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
        void ActualizarPaginasNormal()
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strComando = "call integrajeffschm.sp_listar_clientes(@tabinicio, @tabfinal);";
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
                dtgClientes.DataSource = dt.Tables[1];

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
                string strComando = "call integrajeffschm.sp_listar_clientes_buscar(@tabinicio, @tabfinal, @id, @nom, @dir);";
                MySqlCommand mscCommand = new MySqlCommand(strComando, conn);
                mscCommand.Parameters.AddWithValue("@tabinicio", cboPagina.SelectedIndex * intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@tabfinal", intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@id", matrVars[0]);
                mscCommand.Parameters.AddWithValue("@nom", matrVars[1]);
                mscCommand.Parameters.AddWithValue("@dir", matrVars[2]);
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
                dtgClientes.DataSource = dt.Tables[1];

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

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < matrVars.Length; i++)
            {
                matrVars[i] = "";
            }
            cboPagina.Items.Add(1);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmClientesBuscar busc = new FrmClientesBuscar(matrVars);
            busc.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmClientesAgregar agr = new FrmClientesAgregar();
            agr.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmClientesEditar edi = new FrmClientesEditar(ClienteActual);
            edi.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este cliente?", "ELIMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySqlConnection conn = ConexionBD.Conexion;
                try
                {
                    string strOrder = "DELETE FROM `integrajeffschm`.`clientes` WHERE idClientes = @id;";
                    MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
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
                ClienteActual.IDCliente = 0;
                ClienteActual.Nombre = "";
                ClienteActual.Direccion = "";
                txtIdClientes.Text = ClienteActual.IDCliente.ToString();
                txtNombre.Text = ClienteActual.Nombre = "";
                txtDireccion.Text = ClienteActual.Direccion;
            }
        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            int intFila = e.RowIndex;
            try
            {
                int intId = int.Parse(dtgClientes.Rows[intFila].Cells[0].Value.ToString());
                string strQuery = $"select * from clientes where idClientes={intId};";
                MySqlCommand mscCommand = new MySqlCommand(strQuery, conn);
                conn.Open();
                MySqlDataReader msdrLector = mscCommand.ExecuteReader();
                if (msdrLector.HasRows)
                {
                    if (msdrLector.Read())
                    {
                        ClienteActual.IDCliente = msdrLector.GetInt32("idClientes");
                        ClienteActual.Nombre = msdrLector.GetString("Nombre");
                        ClienteActual.Direccion = msdrLector.GetString("Direccion");
                    }
                }
                txtIdClientes.Text = ClienteActual.IDCliente.ToString();
                txtNombre.Text = ClienteActual.Nombre;
                txtDireccion.Text = ClienteActual.Direccion;
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
