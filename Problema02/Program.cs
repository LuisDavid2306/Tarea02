using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Program
    {
        static void Main()
        {
            Computadora pc1 = new Computadora(100, "HP", "Negro", 100);
            Computadora.Listar(pc1);
            Console.WriteLine("---- DISMINUIR EN 10% EL PRECIO DE DOLARES ----\n");
            pc1.PrecioDolares *= 0.90;
            Computadora.Listar(pc1);
            Console.ReadKey();
        }
    }
}
