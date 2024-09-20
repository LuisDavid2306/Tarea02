using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema08
{
    internal class Asesor
    {
        private int codigo;
        private string nombre;
        private int horasTrabajadas;
        private double tarifaxHora;
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public double TarifaxHora { get => tarifaxHora; set => tarifaxHora = value; }
        public Asesor(int codigo, string nombre, int horasTrabajadas, double tarifaxHora)
        {
            Codigo = codigo;
            Nombre = nombre;
            HorasTrabajadas = horasTrabajadas;
            TarifaxHora = tarifaxHora;
        }
        public double getSueldoBruto()
        {
            return horasTrabajadas * tarifaxHora;
        }
        public double getDescuento()
        {
            return getSueldoBruto() * 0.15;
        }
        public double getSueldoNeto()
        {
            return getSueldoBruto() - getDescuento();
        }
        public static void listar(Asesor x)
        {
            Console.Write($"Codigo: {x.Codigo}\n");
            Console.Write($"Nombre: {x.Nombre}\n");
            Console.Write($"Horas Trabajadas: {x.HorasTrabajadas}\n");
            Console.Write($"Tarifa x Hora: {x.TarifaxHora}\n");
            Console.Write($"Sueldo Bruto: {x.getSueldoBruto()}\n");
            Console.Write($"Descuento: {x.getDescuento()}\n");
            Console.Write($"Sueldo Neto: {x.getSueldoNeto()}\n\n");
        }
    }
}
