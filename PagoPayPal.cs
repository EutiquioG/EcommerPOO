using System;
using EcommercePOO.Interfaces;

namespace EcommercePOO.Pagos
{
    public class PagoPayPal : IProcesoPago
    {
        public void IniciarPago(double monto)
        {
            Console.WriteLine("Pago iniciado con PayPal por $" + monto);
        }

        public bool VerificarPago()
        {
            Console.WriteLine("Verificando cuenta PayPal...");
            return true;
        }

        public void ConfirmarPago()
        {
            Console.WriteLine("Pago confirmado con PayPal");
        }
    }
}