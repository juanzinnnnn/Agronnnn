using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BCuenta
    {
        public static List<Cuenta> Get()
        {
            try
            {
                return DCuenta.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
