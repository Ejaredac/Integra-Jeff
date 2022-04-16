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
    public partial class FrmMantenimientosBuscar : Form
    {
        private string[] _strmtrMatrizString;

        public string[] MatrizString
        {
            get { return _strmtrMatrizString; }
            set { _strmtrMatrizString = value; }
        }
        private DateTime[] _dtmmtrMatrizDates = new DateTime[2];

        public DateTime[] MatrizDates
        {
            get { return _dtmmtrMatrizDates; }
            set { _dtmmtrMatrizDates = value; }
        }


        public FrmMantenimientosBuscar()
        {
            InitializeComponent();
        }
        public FrmMantenimientosBuscar(string[] strenviado, DateTime[] dtpenviado)
        {
            InitializeComponent();
            MatrizString = strenviado;
            MatrizDates = dtpenviado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MatrizString[0] = txtIdMantenimiento.Text;
                MatrizString[1] = txtIdUnidad.Text;
                MatrizString[2] = txtNumeroUnidad.Text;
                MatrizString[3] = txtCosto.Text;
                MatrizString[4] = txtMecanico.Text;
                MatrizString[5] = txtDescripcion.Text;
                MatrizDates[0] = dtpFechaReparacion.Value;
                MatrizDates[1] = dtpFechaPago.Value;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
