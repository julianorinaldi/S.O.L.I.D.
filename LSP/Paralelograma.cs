namespace SOLID.LSP
{
    public abstract class Paralelograma
    {
        protected Paralelograma(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Altura { get; private set; }
        public double Largura { get; private set ; }
        public double Area { get { return Altura * Largura; } } 
    }
}