using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraJeff
{
    static class ConexionBD
    {
        private static MySqlConnection _cnConexion;
        /// <summary>
        /// Esta es la conexión a la base de datos que conecta con el servidor.
        /// </summary>
        public static MySqlConnection Conexion
        {
            get { return _cnConexion; }
            set { _cnConexion = value; }
        }


        private static string _strDireccion;
        /// <summary>
        /// Esta propiedad alberga la direccion IP a la que se conectará a la base de datos.
        /// </summary>
        public static string Direccion
        {
            get { return _strDireccion; }
            set { _strDireccion = value; }
        }

        /// <summary>
        /// <para>
        /// Configura la propiedad "Direccion" para establecerla con la de la base de datos y tambien hace una conexión con la base de datos.
        /// </para>
        /// </summary>
        /// <param name="ip">Direccion IP a configurar</param>
        /// <param name="bd">Nombre de la base de datos</param>
        /// <param name="usuario">Nombre del usuario</param>
        /// <param name="contrasenna">Contraseña a ingresar</param>
        public static void Configurar(string ip, string bd, string usuario, string contrasenna)
        {
            string connectionstring = $"datasource={ip};port=3306;user={usuario};password={contrasenna};database={bd};";
            Direccion = ip;
            MySqlConnection cnNuevaConexion = new MySqlConnection(connectionstring);
            cnNuevaConexion.Open();
            cnNuevaConexion.Close();
            _cnConexion = cnNuevaConexion;
        }

        /// <summary>
        /// Ya con la Direccion configurada se usa nuevamente para establecer conexion con la base de datos e inclusive cambiar de usuario y rol.
        /// </summary>
        /// <param name="bd">Nombre de la base de datos</param>
        /// <param name="usuario">Nombre del usuario</param>
        /// <param name="contrasenna">Contraseña a ingresar</param>
        public static void Configurar(string bd, string usuario, string contrasenna)
        {
            string connectionstring = $"datasource={Direccion};port=3306;user={usuario};password={contrasenna};database={bd};";
            MySqlConnection cnNuevaConexion = new MySqlConnection(connectionstring);
            cnNuevaConexion.Open();
            cnNuevaConexion.Close();
            _cnConexion = cnNuevaConexion;
        }
    }
}
