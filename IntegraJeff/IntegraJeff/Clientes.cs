using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    public class Cliente
    {
        #region ID-Clientes
        private int _intIDCliente;

        public int IDCliente
        {
            get { return _intIDCliente; }
            set { _intIDCliente = value; }
        }
        #endregion

        #region Nombre
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        #endregion

        #region Direccion
        private string _strDireccion;

        public string Direccion
        {
            get { return _strDireccion; }
            set { _strDireccion = value; }
        } 
        #endregion

    }
}
