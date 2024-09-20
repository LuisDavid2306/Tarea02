using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Program
    {
        static void Main()
        {
            Edificio edificio1 = new Edificio(100, 10, 2, 500);
            Edificio.Listar(edificio1);
            Console.WriteLine("---- AUMENTO DEL 20% AL PRECIO DEL DPTO ----\n");
            edificio1.PrecioDolaresDto += edificio1.PrecioDolaresDto * 0.20;
            Edificio.Listar(edificio1);
            Console.ReadKey();
        }
    }
}
