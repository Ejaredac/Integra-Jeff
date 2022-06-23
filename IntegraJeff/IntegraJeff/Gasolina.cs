using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    public class Gasolina
    {
        private int _intIdGasolinas;

        public int IdGasolinas
        {
            get { return _intIdGasolinas; }
            set { _intIdGasolinas = value; }
        }

        private string _strUnidad;

        public string Unidad
        {
            get { return _strUnidad; }
            set { _strUnidad = value; }
        }

        private int _intIdUnidad;

        public int IdUnidad
        {
            get { return _intIdUnidad; }
            set { _intIdUnidad = value; }
        }

        private string _strConductor;

        public string Conductor
        {
            get { return _strConductor; }
            set { _strConductor = value; }
        }

        private int _intIdConductor;

        public int IdConductor
        {
            get { return _intIdConductor; }
            set { _intIdConductor = value; }
        }

        private string _strTipo;

        public string Tipo
        {
            get { return _strTipo; }
            set { _strTipo = value; }
        }

        private double _dblLitros;

        public double Litros
        {
            get { return _dblLitros; }
            set { _dblLitros = value; }
        }

        public double Galones
        {
            get { return (_dblLitros / 3.78541); }
            set { _dblLitros = (value * 3.78541); }
        }

        private double _dblTotal;

        public double Total
        {
            get { return _dblTotal; }
            set { _dblTotal = value; }
        }

        private string _strTarjeta;

        public string Tarjeta
        {
            get { return _strTarjeta; }
            set { _strTarjeta = value; }
        }

        private DateTime _dtmFechaCarga;

        public DateTime FechaCarga
        {
            get { return _dtmFechaCarga; }
            set { _dtmFechaCarga = value; }
        }

        


    }
}
