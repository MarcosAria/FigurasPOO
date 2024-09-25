using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Triangulo : FiguraGeometrica
    {
        private double ladosIguales;
        private double baseT;
        private double altura;


        public Triangulo(double ladosIguales, double baseT, double altura) : base("Triangulo Isosceles")
        {
            this.ladosIguales = ladosIguales;
            this.baseT = baseT;
            this.altura = altura;

        }

        public double Lado {  set { ladosIguales = value; } }
        public double BaseT {  set { baseT = value; } }
        public double Altura { set { altura = value; } }


        public override double CalcularArea()
        {
            return (baseT * altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return (ladosIguales * 2) + baseT;
        }

        ~ Triangulo()
        {
            Console.WriteLine("Destructor del triangulo");
        }


    }
}
