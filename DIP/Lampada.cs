namespace SOLID.DIP
{
    public class Lampada : IDispositivo
    {
        public bool Ligado { get; set; }

        public void Acionar()
        {
            if (!this.Ligado)
                this.Ligar();
            else
                this.Desligar();
        }

        public void Ligar() {  }

        public void Desligar() { }
    }
}