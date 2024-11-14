using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modelos
{
    public class Cuenta
    {
        public int idCuenta { get; set; }
        public string detalle { get; set; }
        public string codigo { get; set; }
        TipoCuenta tipoCuenta { get; set; }
        public Cuenta() { 
            
        }

        public Cuenta(int idCuenta, string detalle, string codigo, TipoCuenta tipoCuenta)
        {
            this.idCuenta = idCuenta;  
            this.detalle = detalle;
            this.codigo = codigo;
            this.tipoCuenta = tipoCuenta;
        }

    }

}
