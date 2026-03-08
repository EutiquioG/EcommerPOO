using System;
using EcommercePOO.Interfaces;

namespace EcommercePOO.Pagos
{
    public class PagoTarjeta : IProcesoPago
    {
        public void IniciarPago(double monto)
        {
            Console.WriteLine("Pago iniciado con Tarjeta por $" + monto);
        }

        public bool VerificarPago()
        {
            Console.WriteLine("Verificando tarjeta...");
            return true;
        }

        public void ConfirmarPago()
        {
            Console.WriteLine("Pago confirmado con Tarjeta");
        }
    }
}