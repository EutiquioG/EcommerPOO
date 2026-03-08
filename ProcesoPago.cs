namespace EcommercePOO.Pagos
{
    public interface ProcesoPago
    {
        void IniciarPago(double monto);

        bool VerificarPago();

        void ConfirmarPago();
    }
}