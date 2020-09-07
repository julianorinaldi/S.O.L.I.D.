using System;

namespace SOLID.LSP
{
    public class ParalelogramaService
    {
        private static void ObterAreaParalelogramo(Paralelograma obj)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(obj.Altura + " * " + obj.Largura);
            Console.WriteLine();
            Console.WriteLine(obj.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado(5);
            var ret = new Retangulo(10, 5);

            ObterAreaParalelogramo(quad);
            ObterAreaParalelogramo(ret);
        }
    }
}