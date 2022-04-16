using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    public class Unidad
    {
        #region Id-Unidad
        private int _intIdUnidad;

        public int IdUnidad
        {
            get { return _intIdUnidad; }
            set { _intIdUnidad = value; }
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

        #region Tipo
        private string _strTipo;

        public string Tipo
        {
            get { return _strTipo; }
            set { _strTipo = value; }
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

        #region Estado
        private string _strEstado;

        public string Estado
        {
            get { return _strEstado; }
            set { _strEstado = value; }
        } 
        #endregion

    }
}
