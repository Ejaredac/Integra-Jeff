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
    public partial class FrmMantenimientos : Form
    {
        int intCantidadDeRegistros = 50;
        int varPagIndice = 0;
        string[] matrVars = new string[6];
        DateTime[] matrdats = new DateTime[2];
        private Unidad _unidUnidadActual;
        private Mantenimiento _mntMantenimientoActual;

        public Mantenimiento MantenimientoActual
        {
            get { return _mntMantenimientoActual; }
            set { _mntMantenimientoActual = value; }
        }

        public FrmMantenimientos()
        {
            InitializeComponent();
            MantenimientoActual = new Mantenimiento();
            MantenimientoActual.FechaPago = DateTime.Parse("2020-01-01");
            MantenimientoActual.FechaReparacion = DateTime.Parse("2020-01-01");
        }
        public FrmMantenimientos(Mantenimiento enviado)
        {
            InitializeComponent();
            MantenimientoActual = enviado;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void FrmMantenimientos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < matrVars.Length; i++)
            {
                matrVars[i] = "";
            }
            for (int i = 0; i < matrdats.Length; i++)
            {
                matrdats[i] = DateTime.Parse("2019-01-01");
            }
            cboPagina.Items.Add(1);
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

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmMantenimientosBuscar busc = new FrmMantenimientosBuscar(matrVars, matrdats);
            busc.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmMantenimientosAgregar agr = new FrmMantenimientosAgregar();
            agr.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmMantenimientosEditar edi = new FrmMantenimientosEditar(MantenimientoActual);
            edi.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este cliente?", "ELIMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySqlConnection conn = ConexionBD.Conexion;
                try
                {
                    string strOrder = "DELETE FROM `integrajeffschm`.`mantenimientos` WHERE idMantenimientos = @id;";
                    MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                    mscCommand.Parameters.AddWithValue("@id", MantenimientoActual.IdMantenimiento);
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
                MantenimientoActual.IdMantenimiento = 0;
                foreach (Control txt in pnlMantenimientoSeleccionado.Controls)
                {
                    txt.Text = (txt is TextBox) ? "" : txt.Text;
                }
                txtIdUnidad.Text = "0";
            }
        }
        void ActualizarPaginasNormal()
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strComando = "CALL `integrajeffschm`.`sp_listar_mantenimientos`(@tabinicio, @tabfinal);";
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
                dtgMantenimiento.DataSource = dt.Tables[1];

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
                string strComando = "CALL `integrajeffschm`.`sp_listar_mantenimientos_buscar`(@tabinicio, @tabfinal, @idmant, @iduni, @numuni, @cos, @mec, @desc, @frep, @fpag);";
                MySqlCommand mscCommand = new MySqlCommand(strComando, conn);
                mscCommand.Parameters.AddWithValue("@tabinicio", cboPagina.SelectedIndex * intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@tabfinal", intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@idmant",matrVars[0]);                
                mscCommand.Parameters.AddWithValue("@iduni", matrVars[1]);
                mscCommand.Parameters.AddWithValue("@numuni", matrVars[2]);
                mscCommand.Parameters.AddWithValue("@cos", matrVars[3]);
                mscCommand.Parameters.AddWithValue("@mec", matrVars[4]);
                mscCommand.Parameters.AddWithValue("@desc", matrVars[5]);
                mscCommand.Parameters.AddWithValue("@frep", DateTime.Parse(matrdats[0].ToString()));
                mscCommand.Parameters.AddWithValue("@fpag", DateTime.Parse(matrdats[1].ToString()));
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
                dtgMantenimiento.DataSource = dt.Tables[1];

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

        private void dtgMantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            int intFila = e.RowIndex;
            try
            {
                int intId = int.Parse(dtgMantenimiento.Rows[intFila].Cells[0].Value.ToString());
                string strQuery = $"select * from mantenimientos where idMantenimientos = {intId};";
                MySqlCommand mscCommand = new MySqlCommand(strQuery, conn);

                conn.Open();
                MySqlDataReader msdrLector = mscCommand.ExecuteReader();
                if (msdrLector.HasRows)
                {
                    if (msdrLector.Read())
                    {
                        MantenimientoActual.IdMantenimiento = msdrLector.GetInt32("idMantenimientos");
                        MantenimientoActual.IdUnidades = msdrLector.GetInt32("idUnidades");
                        MantenimientoActual.Costo = msdrLector.GetDouble("Costo");
                        MantenimientoActual.Mecanico = msdrLector.GetString("Mecanico");
                        MantenimientoActual.Descripcion = msdrLector.GetString("Descripcion");
                        MantenimientoActual.FechaReparacion = msdrLector.GetDateTime("FechaReparacion");
                        MantenimientoActual.FechaPago = msdrLector.GetDateTime("FechaPago");
                    }
                }
                txtIdMantenimiento.Text = MantenimientoActual.IdMantenimiento.ToString();
                txtIdUnidad.Text = MantenimientoActual.IdUnidades.ToString();
                txtDescripcion.Text = MantenimientoActual.Descripcion;
                txtCosto.Text = MantenimientoActual.Costo.ToString();
                txtMecanico.Text = MantenimientoActual.Mecanico;
                dtpFechaReparacion.Value = MantenimientoActual.FechaReparacion;
                dtpFechaPago.Value = MantenimientoActual.FechaPago;
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
