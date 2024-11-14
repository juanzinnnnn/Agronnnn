using Modelos;
using System.Data.SqlClient;

using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos
{
    public class DTipoCuenta
    {
        public static TipoCuenta GetById(int id)
        {
            TipoCuenta result = new TipoCuenta();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetByIDTipoCuenta", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idTipoCuenta", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new TipoCuenta(
                        Convert.ToInt32(reader["idTipoCuenta"]),
                        reader["descripcion"].ToString(),
                        Convert.ToInt32(reader["rubroPatrimonial"])
                    );
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el tipo de cuenta por ID", ex);
            }
            return result;
        }

        public static List<TipoCuenta> GetAll()
        {
            var result = new List<TipoCuenta>();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllTipoCuenta", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var tipoCuenta = new TipoCuenta(
                        Convert.ToInt32(reader["idTipoCuenta"]),
                        reader["descripcion"].ToString(),
                        Convert.ToInt32(reader["rubroPatrimonial"])
                    );
                    result.Add(tipoCuenta);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de tipos de cuenta", ex);
            }
            return result;
        }
    }
}
