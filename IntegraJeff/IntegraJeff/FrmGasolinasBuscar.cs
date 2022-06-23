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
    public partial class FrmGasolinasBuscar : Form
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
        public FrmGasolinasBuscar()
        {
            InitializeComponent();
        }
        public FrmGasolinasBuscar(string[] strenviado, DateTime[] dtmenviado)
        {
            InitializeComponent();
            MatrizCad = strenviado;
            MatrizFech = dtmenviado;
        }

        private void FrmGasolinasBuscar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MatrizCad[0] = txtIdGasolinas.Text;
            MatrizCad[1] = txtUnidad.Text;
            MatrizCad[2] = txtConductor.Text;
            MatrizCad[3] = txtTipo.Text;
            MatrizCad[4] = txtLitros.Text;
            MatrizCad[5] = txtGalones.Text;
            MatrizCad[6] = txtTotal.Text;
            MatrizCad[7] = txtTarjeta.Text;
            MatrizCad[8] = txtIdUnidad.Text;
            MatrizCad[9] = txtIdConductor.Text;
            MatrizFech[0] = dtpFechaCarga.Value;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
