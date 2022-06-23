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
    public partial class FrmCruce : Form
    {
        int intCantidadDeRegistros = 50;
        int varPagIndice = 0;
        string[] matrVars = new string[25];
        DateTime[] matrdats = new DateTime[2];
        private Cruces _cruCruceActual;

        public Cruces CruceActual
        {
            get { return _cruCruceActual; }
            set { _cruCruceActual = value; }
        }

        public FrmCruce()
        {
            InitializeComponent();
            CruceActual = new Cruces();
            CruceActual.FechaCarga = DateTime.Parse("2020-01-01");
            CruceActual.FechaEntrega = DateTime.Parse("2020-01-01");
        }

        public FrmCruce(Cruces enviado)
        {
            InitializeComponent();
            CruceActual = enviado;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }



        void ActualizarPaginasNormal()
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strComando = "CALL `integrajeffschm`.`sp_listar_cruces`(@tabinicio, @tabfinal);";
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
                dtgCruce.DataSource = dt.Tables[1];

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
                string strComando = "CALL `integrajeffschm`.`sp_listar_cruces_buscar`(@tabinicio, @tabfinal, @idcru, @tipser, @idcli, @cli, @idcaj, @numcaj, @idremi, @numfact, @estfact, @estcru, @fcarga, @fentr, @lugcar, @lugdes, @prepes, @predol, @idinter, @inter, @asig, @dem, @hordem, @iduni, @uni, @idcond, @cond, @anot, @ref);";
                MySqlCommand mscCommand = new MySqlCommand(strComando, conn);
                mscCommand.Parameters.AddWithValue("@tabinicio", cboPagina.SelectedIndex * intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@tabfinal", intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@idcru", matrVars[0]);
                mscCommand.Parameters.AddWithValue("@tipser", matrVars[1]);
                mscCommand.Parameters.AddWithValue("@idcli", matrVars[2]);
                mscCommand.Parameters.AddWithValue("@cli", matrVars[3]);
                mscCommand.Parameters.AddWithValue("@idcaj", matrVars[4]);
                mscCommand.Parameters.AddWithValue("@numcaj", matrVars[5]);
                mscCommand.Parameters.AddWithValue("@idremi", matrVars[6]);
                mscCommand.Parameters.AddWithValue("@numfact", matrVars[7]);
                mscCommand.Parameters.AddWithValue("@estfact", matrVars[8]);
                mscCommand.Parameters.AddWithValue("@estcru", matrVars[9]);
                mscCommand.Parameters.AddWithValue("@fcarga", DateTime.Parse(matrdats[0].ToString()));
                mscCommand.Parameters.AddWithValue("@fentr", DateTime.Parse(matrdats[1].ToString()));
                mscCommand.Parameters.AddWithValue("@lugcar", matrVars[10]);
                mscCommand.Parameters.AddWithValue("@lugdes", matrVars[11]);
                mscCommand.Parameters.AddWithValue("@prepes", matrVars[12]);
                mscCommand.Parameters.AddWithValue("@predol", matrVars[13]);
                mscCommand.Parameters.AddWithValue("@idinter", matrVars[14]);
                mscCommand.Parameters.AddWithValue("@inter", matrVars[15]);
                mscCommand.Parameters.AddWithValue("@asig", matrVars[16]);
                mscCommand.Parameters.AddWithValue("@dem", matrVars[17]);
                mscCommand.Parameters.AddWithValue("@hordem", matrVars[18]);
                mscCommand.Parameters.AddWithValue("@iduni", matrVars[19]);
                mscCommand.Parameters.AddWithValue("@uni", matrVars[20]);
                mscCommand.Parameters.AddWithValue("@idcond", matrVars[21]);
                mscCommand.Parameters.AddWithValue("@cond", matrVars[22]);
                mscCommand.Parameters.AddWithValue("@anot", matrVars[23]);
                mscCommand.Parameters.AddWithValue("@ref", matrVars[24]);

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
                dtgCruce.DataSource = dt.Tables[1];

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

        private void FrmCruce_Load(object sender, EventArgs e)
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

        private void dtgCruce_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            int intFila = e.RowIndex;
            try
            {
                string strcliente="",strcaja="",strFact="",strInter="",strUnid="",strCond="";
                int intId = int.Parse(dtgCruce.Rows[intFila].Cells[0].Value.ToString());
                bool blnEstFact = false;
                string strQuery = $"select * from vistacruce where `ID-Cruces` = {intId};";
                MySqlCommand mscCommand = new MySqlCommand(strQuery, conn);

                conn.Open();
                MySqlDataReader msdrLector = mscCommand.ExecuteReader();
                if (msdrLector.HasRows)
                {
                    if (msdrLector.Read())
                    {
                        CruceActual.IdCruces = msdrLector.GetInt32("ID-Cruces");
                        CruceActual.TipoServicio = msdrLector.GetString("Tipo de Servicio");
                        CruceActual.IdClientes = msdrLector.GetInt32("ID-Clientes");
                        strcliente = msdrLector.GetString("Cliente");
                        CruceActual.IdCajas = msdrLector.GetInt32("ID-Cajas");
                        strcaja = msdrLector.GetString("Numero de Caja");
                        CruceActual.IdRemisionesYFacturas = msdrLector.GetInt32("ID-Remisiones y Facturas");
                        strFact = msdrLector.GetString("Numero Fact/Remi");
                        CruceActual.EstatusCobro = msdrLector.GetString("Estado de Cobro - Cruce") == "PAGADO";
                        blnEstFact = msdrLector.GetString("Estatus de Cobro - Factura") == "PAGADO";
                        CruceActual.FechaCarga = msdrLector.GetDateTime("Fecha de Carga");
                        CruceActual.FechaEntrega = msdrLector.GetDateTime("Fecha de Entrega");
                        CruceActual.LugarCarga = msdrLector.GetString("Lugar de Carga");
                        CruceActual.LugarDescarga = msdrLector.GetString("Lugar de Descarga");
                        CruceActual.PrecioPesos = msdrLector.GetDouble("Precio Pesos");
                        CruceActual.PrecioDolares = msdrLector.GetDouble("Precio Dolares");
                        CruceActual.IdIntermediarios = msdrLector.GetInt32("ID-intermediarios");
                        strInter = msdrLector.GetString("Intermediario");
                        CruceActual.Asignada = msdrLector.GetString("Asignada") == "Si";
                        CruceActual.Demora = msdrLector.GetString("Demora");
                        CruceActual.HorasDemora = msdrLector.GetInt32("Horas de Demora");
                        CruceActual.Unidades = msdrLector.GetInt32("ID-Unidades");
                        strUnid = msdrLector.GetString("Unidad");
                        CruceActual.Conductores = msdrLector.GetInt32("ID-Conductor");
                        strCond = msdrLector.GetString("Conductor");
                        CruceActual.Anotaciones = msdrLector.GetString("Anotaciones");
                        CruceActual.Referencia = msdrLector.GetString("Referencia");
                    }
                }
                chkAsignada.Checked = CruceActual.Asignada;
                chkEstatusCobro.Checked = CruceActual.EstatusCobro;
                chkEstFact.Checked = blnEstFact;
                txtIdCruces.Text = CruceActual.IdCruces.ToString();
                txtTipoServicio.Text = CruceActual.TipoServicio;
                txtIdClientes.Text = CruceActual.IdClientes.ToString();
                txtClientes.Text = strcliente;
                txtIdCajas.Text = CruceActual.IdCajas.ToString();
                txtCajas.Text = strcaja;
                txtIdRemisiones.Text = CruceActual.IdRemisionesYFacturas.ToString();
                txtFacturas.Text = strFact;
                txtLugarCarga.Text = CruceActual.LugarCarga;
                txtLugarDescarga.Text = CruceActual.LugarDescarga;
                txtPrecioPesos.Text = CruceActual.PrecioPesos.ToString();
                txtPrecioDolares.Text = CruceActual.PrecioDolares.ToString();
                txtIdIntermediarios.Text = CruceActual.IdIntermediarios.ToString();
                txtIntermediarios.Text = strInter;
                txtDemora.Text = CruceActual.Demora;
                txtHorasDemora.Text = CruceActual.HorasDemora.ToString();
                txtIdUnidades.Text = CruceActual.Unidades.ToString();
                txtUnidades.Text = strUnid;
                txtIdConductores.Text = CruceActual.Conductores.ToString();
                txtConductores.Text = strCond;
                txtAnotaciones.Text = CruceActual.Anotaciones;
                txtReferencia.Text = CruceActual.Referencia;
                dtpFechaCarga.Value = CruceActual.FechaCarga;
                dtpFechaEntrega.Value = CruceActual.FechaEntrega;

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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
            FrmCruceBuscar busc = new FrmCruceBuscar(matrVars, matrdats);
            busc.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCruceAgregar agr = new FrmCruceAgregar();
            agr.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmCruceEditar edi = new FrmCruceEditar(CruceActual);
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
                        string strOrder = "DELETE FROM `integrajeffschm`.`cruces` WHERE idCruces = @id;";
                        MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                        mscCommand.Parameters.AddWithValue("@id", CruceActual.IdCruces);
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
                    CruceActual.IdCruces = 0;
                    foreach (Control txt in pnlCruceSeleccionado.Controls)
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

        private void dtgCruce_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dtgCruce.Rows)
            {

                string fctPag = Convert.ToString(row.Cells["Estatus de Cobro - Factura"].Value);
                string cruPag = Convert.ToString(row.Cells["Estado de Cobro - Cruce"].Value);

                if (fctPag.Equals("PAGADO") || cruPag.Equals("PAGADO"))
                {
                    row.DefaultCellStyle.BackColor = Color.CornflowerBlue;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
