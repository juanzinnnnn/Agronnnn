using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Moneda
    {
        public int idMoneda { get; set; }
        public string descripcion { get; set; }
        public string codAFIP { get; set; }

        public Moneda()
        {

        }

        public Moneda(int idMoneda, string descripcion, string codAFIP)
        {
            this.idMoneda = idMoneda;
            this.descripcion = descripcion;
            this.codAFIP = codAFIP;
        }
    }
}
