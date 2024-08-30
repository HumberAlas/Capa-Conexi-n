using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosLayer
{
    public class CustomerRepository
    {
        // Método para obtener todos los registros de clientes de la base de datos.
        public List<Customers> ObtenerTodos()
        {
            // Abre una conexión a la base de datos utilizando la clase DataBase.
            using (var conexion = DataBase.GetSqlConnection())
            {
                // Construye la consulta SQL para seleccionar todos los campos relevantes de la tabla Customers.
                String selectFrom = "";
                selectFrom = selectFrom + "SELECT " + "\n";
                selectFrom = selectFrom + "      [CompanyName] " + "\n";
                selectFrom = selectFrom + "      ,[ContactName] " + "\n";
                selectFrom = selectFrom + "      ,[ContactTitle] " + "\n";
                selectFrom = selectFrom + "      ,[Address] " + "\n";
                selectFrom = selectFrom + "      ,[City] " + "\n";
                selectFrom = selectFrom + "      ,[Region] " + "\n";
                selectFrom = selectFrom + "      ,[PostalCode] " + "\n";
                selectFrom = selectFrom + "      ,[Country] " + "\n";
                selectFrom = selectFrom + "      ,[Phone] " + "\n";
                selectFrom = selectFrom + "      ,[Fax] " + "\n";
                selectFrom = selectFrom + "  FROM [dbo].[Customers]";

                // Ejecuta la consulta SQL y obtiene los datos mediante SqlCommand.
                using (SqlCommand comando = new SqlCommand(selectFrom, conexion))
                {
                    SqlDataReader reader = comando.ExecuteReader();
                    List<Customers> Customers = new List<Customers>();

                    // Itera a través de cada registro devuelto por la consulta.
                    while (reader.Read())
                    {
                        // Crea un objeto Customers y lo llena con los datos del SqlDataReader.
                        Customers customers = new Customers();
                        customers.CompanyName = reader["CompanyName"] == DBNull.Value ? "" : (String)reader["CompanyName"];
                        customers.ContactName = reader["ContactName"] == DBNull.Value ? "" : (String)reader["ContactName"];
                        customers.ContactTitle = reader["ContactTitle"] == DBNull.Value ? "" : (String)reader["ContactTitle"];
                        customers.Address = reader["Address"] == DBNull.Value ? "" : (String)reader["Address"];
                        customers.City = reader["City"] == DBNull.Value ? "" : (String)reader["City"];
                        customers.Region = reader["Region"] == DBNull.Value ? "" : (String)reader["Region"];
                        customers.PostalCode = reader["PostalCode"] == DBNull.Value ? "" : (String)reader["PostalCode"];
                        customers.Country = reader["Country"] == DBNull.Value ? "" : (String)reader["Country"];
                        customers.Phone = reader["Phone"] == DBNull.Value ? "" : (String)reader["Phone"];
                        customers.Fax = reader["Fax"] == DBNull.Value ? "" : (String)reader["Fax"];

                        // Añade el objeto Customers a la lista de clientes.
                        Customers.Add(customers);
                    }
                    // Retorna la lista de clientes obtenida.
                    return Customers;
                }
            }

        }

        // Método para obtener un cliente específico por su ID.
        public Customers ObtenerPorID(string id)
        {
            // Abre una conexión a la base de datos.
            using (var conexion = DataBase.GetSqlConnection())
            {
                // Construye la consulta SQL para seleccionar un cliente por su ID.
                String selectForID = "";
                selectForID = selectForID + "SELECT [CustomerID] " + "\n";
                selectForID = selectForID + "      ,[CompanyName] " + "\n";
                selectForID = selectForID + "      ,[ContactName] " + "\n";
                selectForID = selectForID + "      ,[ContactTitle] " + "\n";
                selectForID = selectForID + "      ,[Address] " + "\n";
                selectForID = selectForID + "      ,[City] " + "\n";
                selectForID = selectForID + "      ,[Region] " + "\n";
                selectForID = selectForID + "      ,[PostalCode] " + "\n";
                selectForID = selectForID + "      ,[Country] " + "\n";
                selectForID = selectForID + "      ,[Phone] " + "\n";
                selectForID = selectForID + "      ,[Fax] " + "\n";
                selectForID = selectForID + "  FROM [dbo].[Customers] " + "\n";
                selectForID = selectForID + $"  Where CustomerID = @customerId";

                // Ejecuta la consulta SQL con el parámetro de ID del cliente.
                using (SqlCommand comando = new SqlCommand(selectForID, conexion))
                {
                    comando.Parameters.AddWithValue("customerId", id);
                    var reader = comando.ExecuteReader();
                    Customers customers = null;

                    // Si se encuentra un registro, se crea un objeto Customers con los datos obtenidos.
                    if (reader.Read())
                    {
                        customers = LeerDelDataReader(reader);
                    }
                    // Retorna el cliente encontrado o null si no se encontró.
                    return customers;
                }
            }
        }

        // Método auxiliar para leer los datos de un SqlDataReader y crear un objeto Customers.
        public Customers LeerDelDataReader(SqlDataReader reader)
        {
            // Crea un nuevo objeto Customers y lo llena con los datos del SqlDataReader.
            Customers customers = new Customers();
            customers.CompanyName = reader["CompanyName"] == DBNull.Value ? "" : (String)reader["CompanyName"];
            customers.ContactName = reader["ContactName"] == DBNull.Value ? "" : (String)reader["ContactName"];
            customers.ContactTitle = reader["ContactTitle"] == DBNull.Value ? "" : (String)reader["ContactTitle"];
            customers.Address = reader["Address"] == DBNull.Value ? "" : (String)reader["Address"];
            customers.City = reader["City"] == DBNull.Value ? "" : (String)reader["City"];
            customers.Region = reader["Region"] == DBNull.Value ? "" : (String)reader["Region"];
            customers.PostalCode = reader["PostalCode"] == DBNull.Value ? "" : (String)reader["PostalCode"];
            customers.Country = reader["Country"] == DBNull.Value ? "" : (String)reader["Country"];
            customers.Phone = reader["Phone"] == DBNull.Value ? "" : (String)reader["Phone"];
            customers.Fax = reader["Fax"] == DBNull.Value ? "" : (String)reader["Fax"];

            // Retorna el objeto Customers con los datos llenados.
            return customers;
        }
    }
}

