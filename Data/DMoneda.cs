using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos
{
    public class DMoneda
    {
        public static Moneda GetById(int id)
        {
            Moneda result = null;
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetByIDMoneda", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdMoneda", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new Moneda(
                        Convert.ToInt32(reader["IdMoneda"]),
                        reader["Descripcion"].ToString(),
                        reader["CodAFIP"].ToString()
                    );
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la moneda por ID", ex);
            }
            return result;
        }

        public static List<Moneda> GetAll()
        {
            var result = new List<Moneda>();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllMoneda", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var moneda = new Moneda(
                        Convert.ToInt32(reader["IdMoneda"]),
                        reader["Descripcion"].ToString(),
                        reader["CodAFIP"].ToString()
                    );
                    result.Add(moneda);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de monedas", ex);
            }
            return result;
        }
    }
}
