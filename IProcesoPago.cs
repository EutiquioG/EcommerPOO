namespace EcommercePOO.Interfaces
{
    public interface IProcesoPago
    {
        void IniciarPago(double monto);

        bool VerificarPago();

        void ConfirmarPago();
    }
}