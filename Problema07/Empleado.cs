using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema07
{
    internal class Empleado
    {
        private int codigo;
        private string nombre;
        private int celular;
        private double sueldo;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Celular { get => celular; set => celular = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public Empleado(int codigo, string nombre, int celular, double sueldo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Celular = celular;
            Sueldo = sueldo;
        }
        public string getdescripcion()
        {
            if (sueldo > 3500)
            {
                return "Sueldo mayor a 3500";
            }
            else if (sueldo == 3500)
            {
                return "Sueldo igual a 3500";
            }
            else
            {
                return "Sueldo menor a 3500";
            }
        }
        public static void listar(Empleado x)
        {
            Console.Write($"Codigo: {x.Codigo}\n");
            Console.Write($"Nombre: {x.Nombre}\n");
            Console.Write($"Nro Celular: {x.Celular}\n");
            Console.Write($"Sueldo soles: {x.Sueldo}\n");
            Console.Write($"Descripcion: {x.getdescripcion()}\n\n");
        }
    }
}
