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
    public partial class FrmUnidadesBuscar : Form
    {
        private string[] _strmtrMatrizBusqueda;

        public string[] MatrizBusqueda
        {
            get { return _strmtrMatrizBusqueda; }
            set { _strmtrMatrizBusqueda = value; }
        }

        public FrmUnidadesBuscar()
        {
            InitializeComponent();
        }
        public FrmUnidadesBuscar(string[] enviado)
        {
            InitializeComponent();
            MatrizBusqueda = enviado;
        }

        private void FrmUnidadesBuscar_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MatrizBusqueda[0] = txtIdUnidad.Text;
            MatrizBusqueda[1] = txtNumero.Text;
            MatrizBusqueda[2] = txtTipo.Text;
            MatrizBusqueda[3] = txtDescripcion.Text;
            MatrizBusqueda[4] = txtEstado.Text;
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
