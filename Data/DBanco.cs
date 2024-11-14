using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos
{
    public class DBanco
    {
        public static Banco GetById(int id)
        {
            Banco result = new Banco();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetByIDBanco", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdBanco", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Moneda moneda = DMoneda.GetById(Convert.ToInt32(reader["MonedaId"]));
                  

                    result = new Banco(
                        Convert.ToInt32(reader["IdBanco"]),
                        reader["NombreBanco"].ToString(),
                        moneda,
                        Convert.ToInt32(reader["TipoCuenta"]),
                        reader["Detalle"].ToString(),
                        reader["CBU"].ToString()
                    );
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw; // new Exception("Error al obtener el banco por ID", ex);
            }
            return result;
        }

        public static List<Banco> GetAll()
        {
            List<Banco> result = new List<Banco>();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllBanco", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Moneda moneda =DMoneda.GetById(Convert.ToInt32(reader["MonedaId"]));
                    var banco = new Banco(
                        Convert.ToInt32(reader["IdBanco"]),
                        reader["NombreBanco"].ToString(),
                        moneda,
                         
                        Convert.ToInt32(reader["TipoCuenta"]),
                        reader["Detalle"].ToString(),
                        reader["Cbu"].ToString()
                    );
                    result.Add(banco);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw;// new Exception("Error al obtener la lista de bancos", ex);
            }
            return result;
        }
    }
}
