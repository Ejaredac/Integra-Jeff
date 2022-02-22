using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    class Usuario
    {
        
        private string _strNombreUsuario;
        /// <summary>
        /// <para>
        /// Nombre de usuario que se alberga, es necesario para la contraseña.
        /// </para>
        /// </summary>
        public string NombreUsuario
        {
            get { return _strNombreUsuario; }
            set { _strNombreUsuario = value; }
        }


        private string _strEmail;
        /// <summary>
        /// Email que se usa para el ingreso de sesión del sistema.
        /// </summary>
        public string Email
        {
            get { return _strEmail; }
            set { _strEmail = value; }
        }


        private string _strContrasenna;
        /// <summary>
        /// Contraseña de acceso que permite al usuario entrar al sistema con su perfil.
        /// </summary>
        public string Contrasenna
        {
            get { return _strContrasenna; }
            set { _strContrasenna = value; }
        }


        private DateTime _dtmFechaCreacion;
        /// <summary>
        /// Fecha en la que se creo el usuario
        /// </summary>
        public DateTime FechaCreacion
        {
            get { return _dtmFechaCreacion; }
            set { _dtmFechaCreacion = value; }
        }


        private int _intIdUsuario;
        /// <summary>
        /// Id de identificacion del usuario en la bd.
        /// </summary>
        public int IdUsuario
        {
            get { return _intIdUsuario; }
            set { _intIdUsuario = value; }
        }


        private bool _blnConfirmado;
        /// <summary>
        /// Con este parametro se sabe si un usuario esta confirmado o no.
        /// </summary>
        public bool Confirmado
        {
            get { return _blnConfirmado; }
            set { _blnConfirmado = value; }
        }


        private string _strRol;
        /// <summary>
        /// Este parametro indica el rol del usuario
        /// </summary>
        public string Rol
        {
            get { return _strRol; }
            set { _strRol = value; }
        }

    }
}
