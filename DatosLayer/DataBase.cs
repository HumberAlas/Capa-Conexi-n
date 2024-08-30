using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosLayer
{
    public class DataBase
    {
        // Propiedad estática para configurar el tiempo de espera de la conexión.
        public static int ConnetionTimeout { get; set; }

        // Propiedad estática para configurar el nombre de la aplicación que se conecta a la base de datos.
        public static string ApplicationName { get; set; }

        // Propiedad que obtiene la cadena de conexión con las configuraciones personalizadas.
        public static String ConnectionString
        {
            get
            {
                // Obtiene la cadena de conexión desde el archivo de configuración (app.config o web.config).
                String CadenaConexion = ConfigurationManager
                    .ConnectionStrings["NWConnection"]
                    .ConnectionString;

                // Utiliza SqlConnectionStringBuilder para manipular la cadena de conexión.
                SqlConnectionStringBuilder conexionBuilder =
                    new SqlConnectionStringBuilder(CadenaConexion);

                // Si ApplicationName está configurado, se actualiza en la cadena de conexión.
                conexionBuilder.ApplicationName =
                    ApplicationName ?? conexionBuilder.ApplicationName;

                // Si ConnetionTimeout está configurado y es mayor a 0, se actualiza el tiempo de espera en la cadena de conexión.
                conexionBuilder.ConnectTimeout = (ConnetionTimeout > 0)
                    ? ConnetionTimeout : conexionBuilder.ConnectTimeout;

                // Retorna la cadena de conexión final con las configuraciones aplicadas.
                return conexionBuilder.ToString();
            }
        }

        // Método estático que crea y abre una conexión SQL utilizando la cadena de conexión configurada.
        public static SqlConnection GetSqlConnection()
        {
            // Crea una nueva instancia de SqlConnection usando la cadena de conexión.
            SqlConnection conexion = new SqlConnection(ConnectionString);

            // Abre la conexión a la base de datos.
            conexion.Open();

            // Retorna la conexión abierta para su uso.
            return conexion;
        }
    }
}
