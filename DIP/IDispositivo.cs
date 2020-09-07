namespace SOLID.DIP
{
    public interface IDispositivo
    {
        bool Ligado { get; set; }
        void Acionar();
        void Ligar();
        void Desligar();
    }
}