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
    public partial class FrmFactura : Form
    {
        int intCantidadDeRegistros = 50;
        int varPagIndice = 0;
        string[] matrVars = new string[10];
        DateTime[] matrdats = new DateTime[3];
        private Factura _fctFacturaActual;

        public Factura FacturaActual
        {
            get { return _fctFacturaActual; }
            set { _fctFacturaActual = value; }
        }

        public FrmFactura()
        {
            InitializeComponent();
            FacturaActual = new Factura();
            FacturaActual.FechaFactura = DateTime.Parse("2020-01-01");
            FacturaActual.FechaPago = DateTime.Parse("2020-01-01");
            FacturaActual.FechaVencimiento = DateTime.Parse("2020-01-01");
        }
        public FrmFactura(Factura enviado)
        {
            InitializeComponent();
            FacturaActual = enviado;
            //btnEliminar.Enabled = false;
            //btnAgregar.Enabled = false;
            //btnEditar.Enabled = false;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
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

        private void dtgFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            int intFila = e.RowIndex;
            try
            {
                int intId = int.Parse(dtgFactura.Rows[intFila].Cells[0].Value.ToString());
                string strQuery = $"select * from remisionesyfacturas where idRemisionesYFacturas = {intId};";
                MySqlCommand mscCommand = new MySqlCommand(strQuery, conn);

                conn.Open();
                MySqlDataReader msdrLector = mscCommand.ExecuteReader();
                if (msdrLector.HasRows)
                {
                    if (msdrLector.Read())
                    {
                        FacturaActual.IdRemisionesFactura = msdrLector.GetInt32("idRemisionesYFacturas");
                        FacturaActual.NombreCliente = msdrLector.GetString("NombreCliente");
                        FacturaActual.Numero = msdrLector.GetString("Numero");
                        FacturaActual.FechaFactura = msdrLector.GetDateTime("FechaFactura");
                        FacturaActual.Dolares = msdrLector.GetDouble("Dolares");
                        FacturaActual.TipoCambio= msdrLector.GetDouble("TipoCambio");
                        FacturaActual.SubtotalPesos= msdrLector.GetDouble("SubtotalPesos");
                        FacturaActual.Iva= msdrLector.GetDouble("Iva");
                        FacturaActual.Retencion= msdrLector.GetDouble("Retencion");
                        FacturaActual.TotalPesos= msdrLector.GetDouble("TotalPesos");
                        FacturaActual.FechaPago= msdrLector.GetDateTime("FechaPago");
                        FacturaActual.FechaVencimiento= msdrLector.GetDateTime("FechaVencimiento");
                        FacturaActual.EstatusCobro= msdrLector.GetBoolean("EstatusCobro");
                    }
                }
                chkEstatusCobro.Checked = FacturaActual.EstatusCobro;
                txtIdRemisionesYFacturas.Text = FacturaActual.IdRemisionesFactura.ToString();
                txtNombreCliente.Text = FacturaActual.NombreCliente;
                txtNumeroFactura.Text = FacturaActual.Numero;
                dtpFechaFactura.Value = FacturaActual.FechaFactura;
                txtDolares.Text = FacturaActual.Dolares.ToString();
                txtTipoCambio.Text = FacturaActual.TipoCambio.ToString();
                txtSubtotalPesos.Text = FacturaActual.SubtotalPesos.ToString();
                txtIva.Text = FacturaActual.Iva.ToString();
                txtRetencion.Text = FacturaActual.Retencion.ToString();
                txtTotalPesos.Text = FacturaActual.TotalPesos.ToString();
                dtpFechaPago.Value = FacturaActual.FechaPago;
                dtpFechaVencimiento.Value = FacturaActual.FechaVencimiento;
                
                
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

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmFacturaBuscar busc = new FrmFacturaBuscar(matrVars, matrdats);
            busc.ShowDialog();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmFacturaAgregar agr = new FrmFacturaAgregar();
            agr.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmFacturaEditar edi = new FrmFacturaEditar(FacturaActual);
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
                        string strOrder = "DELETE FROM `integrajeffschm`.`remisionesyfacturas` WHERE idRemisionesYFacturas = @id";
                        MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                        mscCommand.Parameters.AddWithValue("@id", FacturaActual.IdRemisionesFactura);
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
                    FacturaActual.IdRemisionesFactura = 0;
                    foreach (Control txt in pnlFacturaSeleccionada.Controls)
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
        void ActualizarPaginasNormal()
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strComando = "CALL `integrajeffschm`.`sp_listar_facturas`(@tabinicio, @tabfinal);";
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
                dtgFactura.DataSource = dt.Tables[1];

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
                string strComando = "CALL `integrajeffschm`.`sp_listar_facturas_buscar`(@tabinicio, @tabfinal, @id, @nomb, @num, @ffact, @dol, @tpc, @stp, @iva, @ret, @totp, @fpag, @fven, @est);";
                MySqlCommand mscCommand = new MySqlCommand(strComando, conn);
                mscCommand.Parameters.AddWithValue("@tabinicio", cboPagina.SelectedIndex * intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@tabfinal", intCantidadDeRegistros);
                mscCommand.Parameters.AddWithValue("@id", matrVars[0]);
                mscCommand.Parameters.AddWithValue("@nomb", matrVars[1]);
                mscCommand.Parameters.AddWithValue("@num", matrVars[2]);
                mscCommand.Parameters.AddWithValue("@ffact", DateTime.Parse(matrdats[0].ToString()));
                mscCommand.Parameters.AddWithValue("@dol", matrVars[3]);
                mscCommand.Parameters.AddWithValue("@tpc", matrVars[4]);
                mscCommand.Parameters.AddWithValue("@stp", matrVars[5]);
                mscCommand.Parameters.AddWithValue("@iva", matrVars[6]);
                mscCommand.Parameters.AddWithValue("@ret", matrVars[7]);
                mscCommand.Parameters.AddWithValue("@totp", matrVars[8]);
                mscCommand.Parameters.AddWithValue("@fpag", DateTime.Parse(matrdats[1].ToString()));
                mscCommand.Parameters.AddWithValue("@fven", DateTime.Parse(matrdats[2].ToString()));
                mscCommand.Parameters.AddWithValue("@est", matrVars[9]);

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
                dtgFactura.DataSource = dt.Tables[1];

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
