using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Circulo : FiguraGeometrica
    {
        private double radio;

        public Circulo(double radio) : base("Circulo")
        {
            this.radio = radio;
        }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }

        }

        public override double CalcularArea()
        {
            return 3.1416 * (radio * radio);
        }

        public override double CalcularPerimetro()
        {
            return (2 * 3.1416) * radio;
        }


        ~Circulo()
        {
            Console.WriteLine("Destructor del circulo");
        }

    }


}

