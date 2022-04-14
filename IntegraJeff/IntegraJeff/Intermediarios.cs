using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    class Intermediario
    {
        #region ID-Intermediario
        private int _intIDIntermediario;

        public int IDIntermediario
        {
            get { return _intIDIntermediario; }
            set { _intIDIntermediario = value; }
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

    }
}
