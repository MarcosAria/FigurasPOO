using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class FiguraGeometrica
    {
        private string nombre;

        public FiguraGeometrica(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get { return nombre; } }

        public virtual double CalcularArea()
        {
            return 0.0;
        }

        public virtual double CalcularPerimetro() { return 0.0; }
    }
}
