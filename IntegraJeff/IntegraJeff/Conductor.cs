using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    class Conductor
    {
        #region ID-Conductor
        private int _intIDConductor;

        public int IDConductor
        {
            get { return _intIDConductor; }
            set { _intIDConductor = value; }
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
