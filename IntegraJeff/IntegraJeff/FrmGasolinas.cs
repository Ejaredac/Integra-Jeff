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
    public partial class FrmGasolinas : Form
    {
        int intCantidadDeRegistros = 50;
        int varPagIndice = 0;
        string[] matrVars = new string[10];
        DateTime[] matrdats = new DateTime[1];
        private Gasolina _gslGasolinaActual;

        public Gasolina GasolinaActual
        {
            get { return _gslGasolinaActual; }
            set { _gslGasolinaActual = value; }
        }

        public FrmGasolinas()
        {
            InitializeComponent();
            GasolinaActual = new Gasolina();
            GasolinaActual.FechaCarga = DateTime.Parse("2022-01-01");
        }

        public FrmGasolinas(Gasolina enviado)
        {
            InitializeComponent();
            GasolinaActual = enviado;

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
            FrmGasolinasBuscar busc = new FrmGasolinasBuscar(matrVars, matrdats);
            busc.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmGasolinasAgregar agr = new FrmGasolinasAgregar();
            agr.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmGasolinasEditar edi = new FrmGasolinasEditar(GasolinaActual);
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
                        string strOrder = "DELETE FROM `integrajeffschm`.`gasolinas` WHERE idgasolinas = @id";
                        MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                        mscCommand.Parameters.AddWithValue("@id", GasolinaActual.IdGasolinas);
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
                    GasolinaActual.IdGasolinas = 0;
                    foreach (Control txt in panel1.Controls)
                    {
                        txt.Text = (txt is TextBox) ? "" : txt.Text;
                    }

                }
            }
            else
            {
                MessageBox.Show("Usted no puede eliminar porque no es administrador");
            }
        }

        private void dtgGasolinas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            int intFila = e.RowIndex;
            try
            {
                int intId = int.Parse(dtgGasolinas.Rows[intFila].Cells[0].Value.ToString());
                string strQuery = $"SELECT * FROM integrajeffschm.vistagasolinas where `ID-Gasolinas` = {intId};";
                MySqlCommand mscCommand = new MySqlCommand(strQuery, conn);

                conn.Open();
                MySqlDataReader msdrLector = mscCommand.ExecuteReader();
                if (msdrLector.HasRows)
                {
                    if (msdrLector.Read())
                    {
                        GasolinaActual.IdGasolinas = msdrLector.GetInt32("ID-Gasolinas");
                        GasolinaActual.IdUnidad = msdrLector.GetInt32("ID-Unidad");
                        GasolinaActual.Unidad = msdrLector.GetString("Unidad");
                        GasolinaActual.IdConductor = msdrLector.GetInt32("ID-Conductores");
                        GasolinaActual.Conductor = msdrLector.GetString("Conductor");
                        GasolinaActual.Tipo = msdrLector.GetString("Tipo");
                        GasolinaActual.Litros = msdrLector.GetDouble("Litros");
                        GasolinaActual.Total = msdrLector.GetDouble("Total");
                        GasolinaActual.Tarjeta = msdrLector.GetString("Tarjeta");
                        GasolinaActual.FechaCarga = msdrLector.GetDateTime("Fecha de Carga");

                    }
                }
                txtIdGasolinas.Text = GasolinaActual.IdGasolinas.ToString();
                txtIdUnidad.Text = GasolinaActual.IdUnidad.ToString();
                txtUnidad.Text = GasolinaActual.Unidad;
                txtIdConductor.Text = GasolinaActual.IdConductor.ToString();
                txtConductor.Text = GasolinaActual.Conductor;
                txtTipo.Text = GasolinaActual.Tipo.ToString();
                txtLitros.Text = GasolinaActual.Litros.ToString();
                txtGalones.Text = GasolinaActual.Galones.ToString();
                txtTotal.Text = GasolinaActual.Total.ToString();
                txtTarjeta.Text = GasolinaActual.Tarjeta;
                dtpFechaCarga.Value = GasolinaActual.FechaCarga;

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

        private void FrmGasolinas_Load(object sender, EventArgs e)
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
        void ActualizarPaginasNormal()
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strComando = "call integrajeffschm.sp_listar_gasolinas(@tabinicio,@tabfinal);";
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
                dtgGasolinas.DataSource = dt.Tables[1];

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
                string strComando = "call integrajeffschm.sp_listar_gasolinas_buscar(@tabinicio,@tabfinal,@id,@uni,@cond,@tip,@lit,@gal,@tot,@tar,@fecha,@iduni,@idcond);";
                MySqlCommand mscCommand = new MySqlCommand(strComando, conn);
                mscCommand.Parameters.AddWithValue("@tabinicio", cboPagina.SelectedIndex * intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@tabfinal", intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@id", matrVars[0]);
                mscCommand.Parameters.AddWithValue("@uni", matrVars[1]);
                mscCommand.Parameters.AddWithValue("@cond", matrVars[2]);
                mscCommand.Parameters.AddWithValue("@tip", matrVars[3]);
                mscCommand.Parameters.AddWithValue("@lit", matrVars[4]);
                mscCommand.Parameters.AddWithValue("@gal", matrVars[5]);
                mscCommand.Parameters.AddWithValue("@tot", matrVars[6]);
                mscCommand.Parameters.AddWithValue("@tar", matrVars[7]);
                mscCommand.Parameters.AddWithValue("@fecha", DateTime.Parse(matrdats[0].ToString()));
                mscCommand.Parameters.AddWithValue("@iduni", matrVars[8]);
                mscCommand.Parameters.AddWithValue("@idcond", matrVars[9]);

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
                dtgGasolinas.DataSource = dt.Tables[1];

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
