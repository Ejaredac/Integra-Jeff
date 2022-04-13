using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    public class Cruces
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
        /// <summary>
        /// Es el tipo de servicio que se va a usar.
        /// </summary>
        public string TipoServicio
        {
            get { return _strTipoServicio; }
            set { _strTipoServicio = value; }
        }
        #endregion

        #region ID-Clientes
        private int _intIdClientes;
        /// <summary>
        /// ID-de los clientes
        /// </summary>
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

        #region Estatus de Cobro
        private bool _blnEstatusCobro;

        public bool EstatusCobro
        {
            get { return _blnEstatusCobro; }
            set { _blnEstatusCobro = value; }
        }

        #endregion

        #region Fecha de Carga
        private DateTime _dtmFechaCarga;
        public DateTime FechaCarga
        {
            get { return _dtmFechaCarga; }
            set { _dtmFechaCarga = value; }
        }
        #endregion

        #region Fecha de Entrega
        private DateTime _dtmFechaEntrega;

        public DateTime FechaEntrega
        {
            get { return _dtmFechaEntrega; }
            set { _dtmFechaEntrega = value; }
        }
        #endregion

        #region Lugar de Carga

        private string _strLugarCarga;
        public string LugarCarga
        {
            get { return _strLugarCarga; }
            set { _strLugarCarga = value; }
        }

        #endregion

        #region Lugar de Descarga
        private string _strLugarDescarga;

        public string LugarDescarga
        {
            get { return _strLugarDescarga; }
            set { _strLugarDescarga = value; }
        }

        #endregion

        #region Precio en Pesos

        private double _dblPrecioPesos;

        public double PrecioPesos
        {
            get { return _dblPrecioPesos; }
            set { _dblPrecioPesos = value; }
        }

        #endregion

        #region Precio en Dolares
        private double _dblPrecioDolares;

        public double PrecioDolares
        {
            get { return _dblPrecioDolares; }
            set { _dblPrecioDolares = value; }
        }

        #endregion

        #region ID-Intermediarios
        private int _intIdIntermediarios;
        public int IdIntermediarios
        {
            get { return _intIdIntermediarios; }
            set { _intIdIntermediarios = value; }
        }

        #endregion

        #region Asignada
        private bool _blnAsignada;

        public bool Asignada
        {
            get { return _blnAsignada; }
            set { _blnAsignada = value; }
        }
        #endregion

        #region Demora
        private string _strDemora;

        public string Demora
        {
            get { return _strDemora; }
            set { _strDemora = value; }
        }
        #endregion

        #region Horas de Demora
        private int _intHorasDemora;

        public int HorasDemora
        {
            get { return _intHorasDemora; }
            set { _intHorasDemora = value; }
        }
        #endregion

        #region ID-Unidades
        private int _intIdUnidades;

        public int Unidades
        {
            get { return _intIdUnidades; }
            set { _intIdUnidades = value; }
        }
        #endregion

        #region ID-Conductores
        private int _intIdConductores;

        public int Conductores
        {
            get { return _intIdConductores; }
            set { _intIdConductores = value; }
        }
        #endregion

        #region Anotaciones
        private string _strAnotaciones;

        public string Anotaciones
        {
            get { return _strAnotaciones; }
            set { _strAnotaciones = value; }
        }
        #endregion

        #region Referencia
        private string _strReferencia;

        public string Referencia
        {
            get { return _strReferencia; }
            set { _strReferencia = value; }
        } 
        #endregion


    }
}
