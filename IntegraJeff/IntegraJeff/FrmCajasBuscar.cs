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
    public partial class FrmCajasBuscar : Form
    {
        private string[] strmtrMatrizBusqueda;

        public string[] MatrizBusqueda
        {
            get { return strmtrMatrizBusqueda; }
            set { strmtrMatrizBusqueda = value; }
        }

        public FrmCajasBuscar()
        {
            InitializeComponent();
        }
        public FrmCajasBuscar(string[] matriz)
        {
            InitializeComponent();
            MatrizBusqueda = matriz;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MatrizBusqueda[0] = txtIDCaja.Text;
            MatrizBusqueda[1] = txtNumeroDeCaja.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MatrizBusqueda[0] = "";
            MatrizBusqueda[1] = "";
            this.Close();
        }

        private void FrmCajasBuscar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
