using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using Modelos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Datos
{
    public class DMovimientosBancarios
    {
      
        public static List<MovimientosBancario> GetAll()
        {
            List<MovimientosBancario> result = new List<MovimientosBancario>();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllMovimientosBancario", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Banco banco = DBanco.GetById(Convert.ToInt32(reader["idBanco"]));
                    Cuenta cuenta = DCuenta.GetById(Convert.ToInt32(reader["idCuenta"]));

                    var mb = new MovimientosBancario(
                    Convert.ToInt32(reader["idMovimiento"]),
                    (DateTime)(reader["Fecha"]),
                    banco,
                    cuenta,
                    Convert.ToDouble(reader["Debe"]),
                    Convert.ToDouble(reader["Haber"])
            
                    );

                    result.Add(mb);
                }

                connection.Close();
            
            }
            catch (Exception ex)
            {
                throw  new Exception("Error al obtener los movimientos bancarios", ex);
            }
            return result;
        }

        public static void Insert(DateTime Fecha, int BancoId, int CuentaId, double Debe, double Haber)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("InsertMovimientoBancario", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

               
                command.Parameters.AddWithValue("@Fecha", Fecha);
                command.Parameters.AddWithValue("@BancoId", BancoId);
                command.Parameters.AddWithValue("@CuentaId", CuentaId);
                command.Parameters.AddWithValue("@Debe", Debe);
                command.Parameters.AddWithValue("@Haber", Haber);

                connection.Open();
                command.ExecuteNonQuery();  
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el movimiento bancario", ex);
            }
        }

        public static void Update(int IdMovimiento, DateTime Fecha, int BancoId, int CuentaId, double Debe, double Haber)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(conexion))
                {
                    using (SqlCommand command = new SqlCommand("UpdateMovimientoBancario", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure; 

                    
                        command.Parameters.AddWithValue("@IdMovimiento", IdMovimiento);
                        command.Parameters.AddWithValue("@Fecha", Fecha );
                        command.Parameters.AddWithValue("@BancoId", BancoId);
                        command.Parameters.AddWithValue("@CuentaId", CuentaId );
                        command.Parameters.AddWithValue("@Debe", Debe);
                        command.Parameters.AddWithValue("@Haber", Haber);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el movimiento bancario", ex);
            }
        }


        public static void Delete(int idMovimiento)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(conexion))
                {
                    SqlCommand command = new SqlCommand("DeleteMovimientoBancario", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdMovimiento", idMovimiento);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el movimiento bancario", ex);
            }
        }





    }
}
