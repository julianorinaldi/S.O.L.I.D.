namespace SOLID.NO_DIP
{
    public class Interruptor

    {
        private Ventilador _ventilador;

        public void Acionar()
        {
            if (!_ventilador.Ligado)
                _ventilador.Ligar();
            else
                _ventilador.Desligar();
        }
    }
}