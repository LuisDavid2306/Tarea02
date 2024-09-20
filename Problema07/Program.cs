using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(100, "Luis David", 978838598, 3500);
            Empleado.listar(empleado1);
            Console.WriteLine("---- CAMBIO DE CELULAR POR 999888777 Y AUMENTO DE SUELDO EN 200 ----\n");
            empleado1.Celular = 999888777;
            empleado1.Sueldo += 200;
            Empleado.listar(empleado1);
            Console.ReadKey();

        }
    }
}
