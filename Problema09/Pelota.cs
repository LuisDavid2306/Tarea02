using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema09
{
    internal class Pelota
    {
        private string marca;
        private double pesoGramos;
        private double pesoLibras;
        private double diametroCentimetros;
        private double precio;
        public string Marca { get => marca; set => marca = value; }
        public double PesoGramos { get => pesoGramos; set => pesoGramos = value; }
        public double PesoLibras { get => pesoLibras; set => pesoLibras = value; }
        public double DiametroCentimetros { get => diametroCentimetros; set => diametroCentimetros = value; }
        public double Precio { get => precio; set => precio = value; }
        public Pelota(string marca, double pesoGramos, double pesoLibras, double diametroCentimetros, double precio)
        {
            Marca = marca;
            PesoGramos = pesoGramos;
            PesoLibras = pesoLibras;
            DiametroCentimetros = diametroCentimetros;
            Precio = precio;
        }
        public double getRadio()
        {
            return DiametroCentimetros / 2;
        }
        public double getVolumen()
        {
            return 4 * 3.1416 * getRadio() * getRadio() * getRadio() / 3;
        }
        public double getDecuento()
        {
            return Precio * 0.10;
        }
        public double getImportePagar()
        {
            return Precio - getDecuento();
        }
        public static void listar(Pelota x)
        {
            Console.Write($"Marca: {x.Marca}\n");
            Console.Write($"Peso (gr.): {x.PesoGramos}\n");
            Console.Write($"Peso (lb.): {x.PesoLibras}\n");
            Console.Write($"Diametro (cm.): {x.DiametroCentimetros}\n");
            Console.Write($"Precio: {x.Precio}\n");
            Console.Write($"Radio: {x.getRadio()}\n");
            Console.Write($"Volumen: {x.getVolumen()}\n");
            Console.Write($"Descuento: {x.getDecuento()}\n");
            Console.Write($"Importe a pagar: {x.getImportePagar()}\n\n");
        }
    }
}
