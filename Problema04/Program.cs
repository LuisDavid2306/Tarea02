using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero obrero1 = new Obrero(100,"Luis David", 10, 100);
            Obrero.listar(obrero1);
            Console.WriteLine("---- AUMENTAR 8 HORAS TRAB, DISMINUIR 1.5 LA TARIFA ----\n");
            obrero1.HorasTrabajadas += 8;
            obrero1.TarifaxHora *= 0.985;
            Obrero.listar(obrero1);
            Console.ReadKey();  
        }
    }
}
