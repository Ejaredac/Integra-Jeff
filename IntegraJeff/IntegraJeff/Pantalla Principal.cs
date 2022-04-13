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
    public partial class Pantalla_Principal : Form
    {
        #region Ventanas
        private Form activeform = null;
        #endregion
        #region Propiedades y Atributos
        private Usuario _usrActUsuario;

        public Usuario ActUsuario
        {
            get { return _usrActUsuario; }
            set { _usrActUsuario = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor default
        /// </summary>
        public Pantalla_Principal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor para darle un usuario a la pantalla principal
        /// </summary>
        /// <param name="user">Usuario a dar</param>
        public Pantalla_Principal(Usuario user)
        {
            InitializeComponent();
            ActUsuario = user;
            
        }
        
        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
            pctUsuario.Text = ActUsuario.NombreUsuario;
          
        }
        #endregion

        private void Pantalla_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pctUsuario_Click(object sender, EventArgs e)
        {
            if (ActUsuario.Rol.Equals("Empleado"))
            {
                openChildForm(new FrnUsuarioEmpleado(ActUsuario));
            }
            if (ActUsuario.Rol.Equals("Administrador"))
            {
                openChildForm(new FrmUsuarioAdmin(ActUsuario));
            }
        }

        private void openChildForm(Form childform)
        {
            if (activeform !=null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlDatos.Controls.Add(childform);
            pnlDatos.Tag = childform;
            childform.BringToFront();
            if (!childform.Visible)
            {
                childform.Show();
            }
            
        }

        private void btnCruces_Click(object sender, EventArgs e)
        {

        }

        private void btnCajas_Click(object sender, EventArgs e)
        {

        }
    }
}
