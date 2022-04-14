using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    public class Caja
    {
        private int _intIDCaja;

        public int IDCaja
        {
            get { return _intIDCaja; }
            set { _intIDCaja = value; }
        }

        private string _strNumeroCaja;

        public string NumeroCaja
        {
            get { return _strNumeroCaja; }
            set { _strNumeroCaja = value; }
        }


    }
}
