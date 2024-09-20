using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea02;

namespace Problema01
{
    internal class Program
    {
        static void Main()
        {
            Celular usuario1 = new Celular(978838598,"Luis David", 60, 0.5);

            Celular.Listar(usuario1);
            Console.WriteLine("---- AUMENTAR EN 20 LOS SEGUNDOS CONSUMIDOS Y DISMINUIR EN 5% EL PRECIO X SEGUNDO ----\n");
            usuario1.SegConsumidos += 20;
            usuario1.PrecioxSegundo *= 0.95;
            Celular.Listar(usuario1);
            Console.ReadKey();
        }
    }
}
