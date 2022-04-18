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
    public partial class FrmCruceBuscar : Form
    {
        private string[] _strmtrMatCad;

        public string[] MatCad
        {
            get { return _strmtrMatCad; }
            set { _strmtrMatCad = value; }
        }
        private DateTime[] _dtmmtrMatFec;

        public DateTime[] MatFec
        {
            get { return _dtmmtrMatFec; }
            set { _dtmmtrMatFec = value; }
        }

        public FrmCruceBuscar()
        {
            InitializeComponent();
        }
        public FrmCruceBuscar(string[] enviadocad,DateTime[] enviadodat)
        {
            InitializeComponent();
            MatCad = enviadocad;
            MatFec = enviadodat;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MatFec[0] = dtpFechaCarga.Value;
            MatFec[1] = dtpFechaEntrega.Value;
            MatCad[0] = txtIdCruces.Text;
            MatCad[1] = txtTipoServicio.Text;
            MatCad[2] = txtIdClientes.Text;
            MatCad[3] = txtCliente.Text;
            MatCad[4] = txtIdCajas.Text;
            MatCad[5] = txtNumeroCaja.Text;
            MatCad[6] = txtIdRemisiones.Text;
            MatCad[7] = txtNumeroFactura.Text;
            MatCad[8] = txtEstatusCobroFactura.Text;
            MatCad[9] = txtEstatusCobroCruce.Text;
            MatCad[10] = txtLugarCarga.Text;
            MatCad[11] = txtLugarDescarga.Text;
            MatCad[12] = txtPrecioPesos.Text;
            MatCad[13] = txtPrecioDolares.Text;
            MatCad[14] = txtIdIntermediarios.Text;
            MatCad[15] = txtIntermediario.Text;
            MatCad[16] = txtAsignada.Text;
            MatCad[17] = txtDemora.Text;
            MatCad[18] = txtHorasDemora.Text;
            MatCad[19] = txtIdUnidades.Text;
            MatCad[20] = txtUnidad.Text;
            MatCad[21] = txtIdConductores.Text;
            MatCad[22] = txtConductor.Text;
            MatCad[23] = txtAnotaciones.Text;
            MatCad[24] = txtReferencia.Text;
            this.Close();
        }
    }
}
