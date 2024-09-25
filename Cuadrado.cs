using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Cuadrado : FiguraGeometrica
    {
        private double lado; 

        public Cuadrado(double lado) : base("Cuadrado")
        {
            this.lado = lado;
        }

        public double Lado { set { lado = value; } }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return lado + lado + lado + lado;
        }


        ~Cuadrado()
        {
            Console.WriteLine("Destructor del cuadrado");
        }

    }
}
