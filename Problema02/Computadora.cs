using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Computadora
    {
        private int codigo;
        private string marca;
        private string color;
        private double precioDolares;
        public int Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioDolares { get => precioDolares; set => precioDolares = value; }

        public Computadora(int codigo, string marca, string color, double precioDolares)
        {
            Codigo = codigo;
            Marca = marca;
            Color = color;
            PrecioDolares = precioDolares;
        }

        public double precioSoles() 
        { 
            return precioDolares * 3.35;
        }
        public double precioEuros()
        {
            return precioDolares / 1.20;
        }
        public static void Listar(Computadora computadora)
        {
            Console.Write($"Código: {computadora.Codigo}\n");
            Console.Write($"Marca: {computadora.Marca}\n");
            Console.Write($"Color: {computadora.Color}\n");
            Console.Write($"Precio Dólares: {computadora.PrecioDolares}\n");
            Console.Write($"Precio Soles: {computadora.precioSoles()}\n");
            Console.Write($"Precio Euros: {computadora.precioEuros()}\n\n");
        }
    }
}
