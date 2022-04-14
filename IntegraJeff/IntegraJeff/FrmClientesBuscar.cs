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
    public partial class FrmClientesBuscar : Form
    {
        private string[] _strmtrMatriz;

        public string[] Matriz
        {
            get { return _strmtrMatriz; }
            set { _strmtrMatriz = value; }
        }

        public FrmClientesBuscar()
        {
            InitializeComponent();
        }
        public FrmClientesBuscar(string[] enviado)
        {
            InitializeComponent();
            Matriz = enviado;
        }
        private void FrmClientesBuscar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Matriz[0] = txtIdClientes.Text;
            Matriz[1] = txtNombre.Text;
            Matriz[2] = txtDireccion.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Matriz.Length; i++)
            {
                Matriz[i] = "";
            }
            this.Close();
        }

        private void FrmClientesBuscar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
