namespace SOLID.DIP
{
    public class Interruptor
    {
        private readonly IDispositivo _dispositivo;

        public Interruptor(IDispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }

        public void AcionarDispositivo()
        {
            _dispositivo.Acionar();
        }
    }
}