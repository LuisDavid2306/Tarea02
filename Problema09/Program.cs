using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pelota = new Pelota("Adidas", 60, 10, 10, 100);
            Pelota.listar(pelota);
            Console.WriteLine("---- DISMINUIR EN 25% EL PRECIO Y AUMENTAR 1 CM AL DIAMETRO ----\n");
            pelota.Precio *= 0.75;
            pelota.DiametroCentimetros += 1;
            Pelota.listar(pelota);
            Console.ReadKey();
        }
    }
}
