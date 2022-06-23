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
    public partial class FrmMantenimientosEditar : Form
    {
        private Mantenimiento _mntMantenimientoActual;

        public Mantenimiento MantenimientoActual
        {
            get { return _mntMantenimientoActual; }
            set { _mntMantenimientoActual = value; }
        }

        
        public FrmMantenimientosEditar()
        {
            InitializeComponent();
        }
        public FrmMantenimientosEditar(Mantenimiento enviado)
        {
            InitializeComponent();
            MantenimientoActual = enviado;
        }
        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtIdUnidad_TextChanged(object sender, EventArgs e)
        {
            txtIdUnidad.Text = (string.IsNullOrEmpty(txtIdUnidad.Text)) ? "0" : txtIdUnidad.Text;
        }

        private void txtIdUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            txtCosto.Text = (string.IsNullOrEmpty(txtCosto.Text)) ? "0" : txtCosto.Text;
        }

        private void btnSeleccionarUnidad_Click(object sender, EventArgs e)
        {
            Unidad sel = new Unidad();
            FrmUnidades uni = new FrmUnidades(sel);
            uni.ShowDialog();
            txtIdUnidad.Text = sel.IdUnidad.ToString();
        }

        private void FrmMantenimientosEditar_Load(object sender, EventArgs e)
        {
            txtCosto.Text = MantenimientoActual.Costo.ToString();
            txtDescripcion.Text = MantenimientoActual.Descripcion;
            txtIdMantenimiento.Text = MantenimientoActual.IdMantenimiento.ToString();
            txtIdUnidad.Text = MantenimientoActual.IdUnidades.ToString();
            txtMecanico.Text = MantenimientoActual.Mecanico;
            dtpFechaPago.Value = MantenimientoActual.FechaPago;
            dtpFechaReparacion.Value = MantenimientoActual.FechaReparacion;
            txtIdMantenimiento.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConexionBD.Conexion;
            try
            {
                string strOrder = @"UPDATE `integrajeffschm`.`mantenimientos`
SET
`idUnidades` = @iduni,
`Costo` = @cos,
`Mecanico` = @mec,
`Descripcion` = @des,
`FechaReparacion` = @frep,
`FechaPago` = @fpag
WHERE `idMantenimientos` = @id;";
                MySqlCommand mscCommand = new MySqlCommand(strOrder, conn);
                mscCommand.Parameters.AddWithValue("@id", MantenimientoActual.IdMantenimiento);
                mscCommand.Parameters.AddWithValue("@iduni",int.Parse(txtIdUnidad.Text));
                mscCommand.Parameters.AddWithValue("@cos",double.Parse(txtCosto.Text));
                mscCommand.Parameters.AddWithValue("@mec",txtMecanico.Text);
                mscCommand.Parameters.AddWithValue("@des",txtDescripcion.Text);
                mscCommand.Parameters.AddWithValue("@frep",dtpFechaReparacion.Value.Date);
                mscCommand.Parameters.AddWithValue("@fpag",dtpFechaPago.Value.Date);
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
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
