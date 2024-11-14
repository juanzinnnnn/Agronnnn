using Datos;
using Modelos;



using System.Collections.Generic;

namespace Negocio
{
    public class BMovimientoBancario
    {

        public static List<MovimientosBancario> Get()
        {
            try
            {
                return DMovimientosBancarios.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Insert(DateTime Fecha, int BancoId, int CuentaId, double Debe, double Haber)
        {
            try
            {
                DMovimientosBancarios.Insert(Fecha, BancoId, CuentaId, Debe, Haber);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Delete(int idMovimiento)
        {
            try
            {
                DMovimientosBancarios.Delete(idMovimiento);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update(int IdMovimiento, DateTime Fecha, int BancoId, int CuentaId, double Debe, double Haber)
        {
            try
            {
                DMovimientosBancarios.Update(IdMovimiento, Fecha, BancoId, CuentaId, Debe, Haber);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

