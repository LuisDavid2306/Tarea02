using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema06
{
    internal class Paciente
    {
        private string nombre;
        private string apellido;
        private int edad;
        private double talla;
        private double peso;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Talla { get => talla; set => talla = value; }
        public double Peso { get => peso; set => peso = value; }

        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Talla = talla;
            Peso = peso;
        }
        public string identificarMayor()
        {
            if (Edad >= 18)
            {
                return "Mayor Edad";
            }
            else {
                return "Menor Edad";
            }
        }
        public static void listar(Paciente x)
        {
            Console.Write($"Nombre: {x.Nombre}\n");
            Console.Write($"Apellido: {x.Apellido}\n");
            Console.Write($"Edad: {x.Edad}\n");
            Console.Write($"Talla: {x.Talla}\n");
            Console.Write($"Peso: {x.Peso}\n");
            Console.Write($"{x.identificarMayor()}\n\n");
        }
    }
}
