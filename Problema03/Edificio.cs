using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Edificio
    {
        private int codigo;
        private int nroDepartamentos;
        private int nroPisos;
        private double precioDolaresDto;

        public int Codigo { get => codigo; set => codigo = value; }
        public int NroDepartamentos { get => nroDepartamentos; set => nroDepartamentos = value; }
        public int NroPisos { get => nroPisos; set => nroPisos = value; }
        public double PrecioDolaresDto { get => precioDolaresDto; set => precioDolaresDto = value; }

        public Edificio(int codigo, int nroDepartamentos, int nroPisos, double precioDolaresDto)
        {
            Codigo = codigo;
            NroDepartamentos = nroDepartamentos;
            NroPisos = nroPisos;
            PrecioDolaresDto = precioDolaresDto;
        }
        public double PrecioDolaresEdificio()
        {
            return nroDepartamentos * precioDolaresDto;
        }
        public static void Listar(Edificio x)
        {
            Console.Write($"Código: {x.Codigo}\n");
            Console.Write($"Nro de Departamentos: {x.NroDepartamentos}\n");
            Console.Write($"Cantidad de Pisos: {x.NroPisos}\n");
            Console.Write($"Precio del Departamento: {x.precioDolaresDto}\n");
            Console.Write($"Precio del Edificio: {x.PrecioDolaresEdificio()}\n\n");
        }
    }
}
