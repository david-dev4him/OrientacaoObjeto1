using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            UtilizarQuadrado();
            Console.ReadKey();
        }

        static void UtilizarQuadrado()
        {
            Quadrado q = new Quadrado();
            float l, p;
            Console.WriteLine("Informe o lado do quadrado: ");
            l = float.Parse(Console.ReadLine());
            q.Lado = l;
            p = q.Perimetro();
            Console.WriteLine("O perímetro é: " + p);            
        }
    }
}
