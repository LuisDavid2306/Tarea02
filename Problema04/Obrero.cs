using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Obrero
    {
        private int codigo;
        private string nombre;
        private int horasTrabajadas;
        private double tarifaxHora;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public double TarifaxHora { get => tarifaxHora; set => tarifaxHora = value; }

        public Obrero(int codigo, string nombre, int horasTrabajadas, double tarifaxHora)
        {
            Codigo = codigo;
            Nombre = nombre;
            HorasTrabajadas = horasTrabajadas;
            TarifaxHora = tarifaxHora;
        }
        public double getSueldoBruto()
        {
            return HorasTrabajadas * TarifaxHora;
        }
        public double getDescuentoAfp()
        {
            return getSueldoBruto()*0.10;
        }
        public double getDescuentoEps()
        {
            return getSueldoBruto() * 0.05;
        }
        public double getSueldoNeto()
        {
            return getSueldoBruto()-getDescuentoAfp()-getDescuentoEps();
        }
        public static void listar(Obrero x)
        {
            Console.Write($"Código: {x.Codigo}\n");
            Console.Write($"Nombre: {x.Nombre}\n");
            Console.Write($"Horas Trabajadas: {x.HorasTrabajadas}\n");
            Console.Write($"Tarifa x Hora: {x.TarifaxHora}\n");
            Console.Write($"------------------------\n");
            Console.Write($"Sueldo Bruto: {x.getSueldoBruto()}\n");
            Console.Write($"Descuento AFP: {x.getDescuentoAfp()}\n");
            Console.Write($"Descuento EPS: {x.getDescuentoEps()}\n");
            Console.Write($"Sueldo Neto: {x.getSueldoNeto()}\n\n");
        }
    }
}
