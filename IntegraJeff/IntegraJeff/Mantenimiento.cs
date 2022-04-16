using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    public class Mantenimiento
    {
        #region Id-Mantenimiento
        private int _intIDMantenimiento;

        public int IdMantenimiento
        {
            get { return _intIDMantenimiento; }
            set { _intIDMantenimiento = value; }
        }
        #endregion

        #region Id-Unidades
        private int _intIdUnidades;

        public int IdUnidades
        {
            get { return _intIdUnidades; }
            set { _intIdUnidades = value; }
        }
        #endregion

        #region Costo
        private double _dblCosto;

        public double Costo
        {
            get { return _dblCosto; }
            set { _dblCosto = value; }
        }
        #endregion

        #region Mecanico
        private string _strMecanico;

        public string Mecanico
        {
            get { return _strMecanico; }
            set { _strMecanico = value; }
        }
        #endregion

        #region Descripcion
        private string _strDescripcion;

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }
        #endregion

        #region Fecha de Reparacion
        private DateTime _dtmFechaReparacion;

        public DateTime FechaReparacion
        {
            get { return _dtmFechaReparacion; }
            set { _dtmFechaReparacion = value; }
        }
        #endregion

        #region Fecha de Pago
        private DateTime _dtmFechaPago;

        public DateTime FechaPago
        {
            get { return _dtmFechaPago; }
            set { _dtmFechaPago = value; }
        } 
        #endregion

    }
}
