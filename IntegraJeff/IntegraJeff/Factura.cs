using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    public class Factura
    {
        #region Id - Remisiones y Facturas
        private int _intIdRemisionesFactura;

        public int IdRemisionesFactura
        {
            get { return _intIdRemisionesFactura; }
            set { _intIdRemisionesFactura = value; }
        }
        #endregion

        #region Nombre del Cliente
        private string _strNombreCliente;

        public string NombreCliente
        {
            get { return _strNombreCliente; }
            set { _strNombreCliente = value; }
        }
        #endregion

        #region Numero
        private string _strNumero;

        public string Numero
        {
            get { return _strNumero; }
            set { _strNumero = value; }
        }
        #endregion

        #region Fecha de Factura
        private DateTime _dtmFechaFactura;

        public DateTime FechaFactura
        {
            get { return _dtmFechaFactura; }
            set { _dtmFechaFactura = value; }
        }
        #endregion

        #region Dolares
        private double _dblDolares;

        public double Dolares
        {
            get { return _dblDolares; }
            set { _dblDolares = value; }
        }
        #endregion

        #region Tipo de Cambio
        private double _dblTipoCambio;

        public double TipoCambio
        {
            get { return _dblTipoCambio; }
            set { _dblTipoCambio = value; }
        }
        #endregion

        #region Subtotal en Pesos
        private double _dblSubtotalPesos;

        public double SubtotalPesos
        {
            get { return _dblSubtotalPesos; }
            set { _dblSubtotalPesos = value; }
        }
        #endregion

        #region Iva
        private double _dblIva;

        public double Iva
        {
            get { return _dblIva; }
            set { _dblIva = value; }
        }
        #endregion

        #region Retencion
        private double _dblRetencion;

        public double Retencion
        {
            get { return _dblRetencion; }
            set { _dblRetencion = value; }
        }
        #endregion

        #region Total en Pesos
        private double _dblTotalPesos;

        public double TotalPesos
        {
            get { return _dblTotalPesos; }
            set { _dblTotalPesos = value; }
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

        #region Fecha de Vencimiento del Pago
        private DateTime _dtmFechaVencimiento;

        public DateTime FechaVencimiento
        {
            get { return _dtmFechaVencimiento; }
            set { _dtmFechaVencimiento = value; }
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

    }
}
