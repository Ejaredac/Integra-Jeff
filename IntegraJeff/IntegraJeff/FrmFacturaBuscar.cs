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
    public partial class FrmFacturaBuscar : Form
    {
        private string[] _strmtrMatrizCad;

        public string[] MatrizCad
        {
            get { return _strmtrMatrizCad; }
            set { _strmtrMatrizCad = value; }
        }
        private DateTime[] _dtmmtrMatrizFech;

        public DateTime[] MatrizFech
        {
            get { return _dtmmtrMatrizFech; }
            set { _dtmmtrMatrizFech = value; }
        }

        public FrmFacturaBuscar()
        {
            InitializeComponent();
        }
        public FrmFacturaBuscar(string[] strenviado, DateTime[] dtmenviado)
        {
            InitializeComponent();
            MatrizCad = strenviado;
            MatrizFech = dtmenviado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MatrizCad[0] = txtIdRemisionesYFacturas.Text;
            MatrizCad[1] = txtNombreCliente.Text;
            MatrizCad[2] = txtNumeroFactura.Text;
            MatrizFech[0] = dtpFechaFactura.Value;
            MatrizCad[3] = txtDolares.Text;
            MatrizCad[4] = txtTipoCambio.Text;
            MatrizCad[5] = txtSubtotalPesos.Text;
            MatrizCad[6] = txtIva.Text;
            MatrizCad[7] = txtRetencion.Text;
            MatrizCad[8] = txtTotalPesos.Text;
            MatrizFech[1] = dtpFechaPago.Value;
            MatrizFech[2] = dtpFechaVencimiento.Value;
            MatrizCad[9] = txtEstatusCobro.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
