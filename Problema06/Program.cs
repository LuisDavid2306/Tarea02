using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente("Luis David", "Monchon Alfaro", 20, 1.70, 65);
            Paciente.listar(paciente1);
            Console.WriteLine("---- CAMBIO DE EDAD ----\n");
            paciente1.Edad = 12;
            Paciente.listar(paciente1);
            Console.ReadKey();
        }
    }
}
