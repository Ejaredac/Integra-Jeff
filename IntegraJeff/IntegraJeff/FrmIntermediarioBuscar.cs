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
    public partial class FrmIntermediarioBuscar : Form
    {
        private string[] _strmtrMatrizBusqueda;

        public string[] MatrizBusqueda
        {
            get { return _strmtrMatrizBusqueda; }
            set { _strmtrMatrizBusqueda = value; }
        }

        public FrmIntermediarioBuscar()
        {
            InitializeComponent();
        }
        public FrmIntermediarioBuscar(string[] enviado)
        {
            InitializeComponent();
            MatrizBusqueda = enviado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MatrizBusqueda[0] = txtIdIntermediario.Text;
            MatrizBusqueda[1] = txtNombre.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MatrizBusqueda.Length; i++)
            {
                MatrizBusqueda[i] = "";
            }
            this.Close();
        }
    }
}
