using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea02
{
    internal class Celular
    {
        private int numero;
        private string usuario;
        private int segConsumidos;
        private double precioxSegundo;
        public int Numero { get => numero; set => numero = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public int SegConsumidos { get => segConsumidos; set => segConsumidos = value; }
        public double PrecioxSegundo { get => precioxSegundo; set => precioxSegundo = value; }
        public Celular(int numero, string usuario, int segConsumidos, double precioxSegundo)
        {
            Numero = numero;
            Usuario = usuario;
            SegConsumidos = segConsumidos;
            PrecioxSegundo = precioxSegundo;
        }
        public double getCostoxConsumo()
        {
            return PrecioxSegundo * SegConsumidos;
        }
        public double getImpuesto()
        {
            return getCostoxConsumo() * 0.18;
        }
        public double getPagoTotal()
        {
            return getCostoxConsumo() + getImpuesto();
        }
        public static void Listar(Celular celular)
        {
            Console.Write($"Usuario: {celular.Usuario}\n");
            Console.Write($"Número: {celular.Numero}\n");
            Console.Write($"Segundos Consumidos: {celular.SegConsumidos}\n");
            Console.Write($"Precio x Segundos: {celular.PrecioxSegundo}\n");
            Console.Write($"------------------------------\n");
            Console.Write($"Costo x Consumo: {celular.getCostoxConsumo()}\n");
            Console.Write($"IGV: {celular.getImpuesto()}\n");
            Console.Write($"Total a Pagar: {celular.getPagoTotal()}\n\n");
        } 
    }
}
