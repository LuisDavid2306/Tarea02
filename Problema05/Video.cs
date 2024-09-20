using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema05
{
    internal class Video
    {
        private int codigo;
        private string nombre;
        private double duracion;
        private double precioSoles;
        private double tipoCambio;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public double PrecioSoles { get => precioSoles; set => precioSoles = value; }
        public double TipoCambio { get => tipoCambio; set => tipoCambio = value; }

        public Video(int codigo, string nombre, double duracion, double precioSoles, double tipoCambio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Duracion = duracion;
            PrecioSoles = precioSoles;
            TipoCambio = tipoCambio;
        }
        public static void listar(Video x)
        {
            Console.Write($"Código: {x.Codigo}\n");
            Console.Write($"Nombre: {x.Nombre}\n");
            Console.Write($"Duracion: {x.Duracion}\n");
            Console.Write($"Precio Soles: {x.PrecioSoles}\n");
            Console.Write($"Tipo de Cambio: {x.TipoCambio}\n\n");
        }
    }
}
