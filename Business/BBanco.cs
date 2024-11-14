using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BBanco
    {
        public static List<Banco> Get()
        {
            try
            {
                return DBanco.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
