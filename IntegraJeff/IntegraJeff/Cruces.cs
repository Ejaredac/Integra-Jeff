using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    class Cruces
    {
        #region ID-Cruces
        private int _intIdCruces;
        /// <summary>
        /// Es la llave primaria de registro del cruce.
        /// </summary>
        public int IdCruces
        {
            get { return _intIdCruces; }
            set { _intIdCruces = value; }
        }
        #endregion

        #region Tipo de Servicio
        private string _strTipoServicio;
        public string TipoServicio
        {
            get { return _strTipoServicio; }
            set { _strTipoServicio = value; }
        }
        #endregion

        #region ID-Clientes
        private int _intIdClientes;
        public int IdClientes
        {
            get { return _intIdClientes; }
            set { _intIdClientes = value; }
        }
        #endregion

        #region ID-Cajas
        private int _intIdCajas;
        public int IdCajas
        {
            get { return _intIdCajas; }
            set { _intIdCajas = value; }
        }
        #endregion

        #region ID-Remisiones y Facturas
        private int _intIdRemisionesYFacturas;
        public int IdRemisionesYFacturas
        {
            get { return _intIdRemisionesYFacturas; }
            set { _intIdRemisionesYFacturas = value; }
        } 
        #endregion

        private DateTime _dtmFechaCarga;
        public DateTime FechaCarga
        {
            get { return _dtmFechaCarga; }
            set { _dtmFechaCarga = value; }
        }

        private DateTime _dtmFechaEntrega;

        public DateTime FechaEntrega
        {
            get { return _dtmFechaEntrega; }
            set { _dtmFechaEntrega = value; }
        }

        private string _strLugarCarga;
        public string LugarCarga
        {
            get { return _strLugarCarga; }
            set { _strLugarCarga = value; }
        }

        private string _strLugarDescarga;

        public string LugarDescarga
        {
            get { return _strLugarDescarga; }
            set { _strLugarDescarga = value; }
        }

        private double _dblPrecioPesos;

        public double PrecioPesos
        {
            get { return _dblPrecioPesos; }
            set { _dblPrecioPesos = value; }
        }

        private double _dblPrecioDolares;

        public double PrecioDolares
        {
            get { return _dblPrecioDolares; }
            set { _dblPrecioDolares = value; }
        }

        private int _intIdIntermediarios;
        public int IdIntermediarios
        {
            get { return _intIdIntermediarios; }
            set { _intIdIntermediarios = value; }
        }

        private bool _blnAsignada;

        public bool Asignada
        {
            get { return _blnAsignada; }
            set { _blnAsignada = value; }
        }

        private string _strDemora;

        public string Demora
        {
            get { return _strDemora; }
            set { _strDemora = value; }
        }

        private int _intIdUnidades;

        public int Unidades
        {
            get { return _intIdUnidades; }
            set { _intIdUnidades = value; }
        }

        private int _intIdConductores;

        public int Conductores
        {
            get { return _intIdConductores; }
            set { _intIdConductores = value; }
        }

        private string _strAnotaciones;

        public string Anotaciones
        {
            get { return _strAnotaciones; }
            set { _strAnotaciones = value; }
        }

    }
}
