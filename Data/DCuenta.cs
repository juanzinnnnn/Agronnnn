using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos
{
    public class DCuenta
    {
        public static Cuenta GetById(int id)
        {
            Cuenta result = null;
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetByIDCuenta", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idCuenta", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoCuenta tipoCuenta = DTipoCuenta.GetById(Convert.ToInt32(reader["TipoCuentaId"]));
                    result = new Cuenta(
                        Convert.ToInt32(reader["IdCuenta"]),
                        reader["Detalle"].ToString(),
                        reader["Codigo"].ToString(),
                        tipoCuenta
                    );
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la cuenta por ID", ex);
            }
            return result;
        }

        public static List<Cuenta> GetAll()
        {
            var result = new List<Cuenta>();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllCuenta", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoCuenta tipoCuenta = DTipoCuenta.GetById(Convert.ToInt32(reader["TipoCuentaId"]));
                    var cuenta = new Cuenta(
                        Convert.ToInt32(reader["IdCuenta"]),
                        reader["Detalle"].ToString(),
                        reader["Codigo"].ToString(),
                        tipoCuenta
                    );
                    result.Add(cuenta);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw; //new Exception("Error al obtener la lista de cuentas", ex);
            }
            return result;
        }
    }
}
