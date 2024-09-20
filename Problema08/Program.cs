using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor asesor1 = new Asesor(100, "Luis David", 100, 10.5);
            Asesor.listar(asesor1);
            Console.WriteLine("---- AUMENTAR EN 10 LAS HORAS Y DISMINUIR 15% EN LA TARIFA ----\n");
            asesor1.HorasTrabajadas += 10;
            asesor1.TarifaxHora *= 0.85;
            Asesor.listar(asesor1);
            Console.ReadKey();
        }
    }
}
