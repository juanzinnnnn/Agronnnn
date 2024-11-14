namespace Modelos


{
    public class MovimientosBancario
    {
        public int IdMovimiento { get; set; }
        public DateTime Fecha { get; set; }
        public Banco Banco { get; set; }
        public Cuenta Cuenta { get; set; }
        public double? Debe { get; set; }
        public double? Haber { get; set; }

        public string? DetalleCuenta
        {
            get
            {
                if (Cuenta != null)
                    return Cuenta.detalle;
                else
                    return null;
            }
        }

        public string? NombreBanco
        {
            get
            {
                if (Banco != null)
                    return Banco.nombreBanco;
                else
                    return null;
            }
        }

        public int? CuentaId
        {
            get
            {
                if (Cuenta != null)
                    return Cuenta.idCuenta;
                else
                    return null;
            }
        }

        public int? BancoId
        {
            get
            {
                if (Banco != null)
                    return Banco.idBanco;
                else
                    return null;
            }
        }

        public MovimientosBancario(int idMovimiento, DateTime fecha, Banco banco, Cuenta cuenta, double? debe, double? haber)
        {
            IdMovimiento = idMovimiento;
            Fecha = fecha;
            Banco = banco;
            Cuenta = cuenta;
            Debe = debe;
            Haber = haber;
        }
    }
}
