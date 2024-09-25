using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{ 

    public class Menu
    {
        private List<Opcion> opciones;
        private FiguraGeometrica figuraActual;

        public Menu()
        {
            opciones = new List<Opcion>()
        {
            new Opcion("Crear Círculo", CrearCirculo),
            new Opcion("Crear Triángulo Isósceles", CrearTrianguloIsosceles),
            new Opcion("Crear Cuadrado", CrearCuadrado),
            new Opcion("Mostrar Área y Perímetro", MostrarAreaYPerimetro),
            new Opcion("Salir", () => Environment.Exit(0))
        };

            while (true)
            {
                MostrarMenu();
                SeleccionarOpcion();
            }
        }

        public void MostrarMenu()
        {
            Console.Clear();
            foreach (Opcion opcion in opciones)
            {
                Console.WriteLine($"{opciones.IndexOf(opcion)}. {opcion.Message}");
            }
            Console.Write("Seleccione una opción: ");
        }

        public void SeleccionarOpcion()
        {
            if (int.TryParse(Console.ReadLine(), out int numOpcion) && numOpcion >= 0 && numOpcion < opciones.Count)
            {
                Console.Clear();
                opciones[numOpcion].Action.Invoke();
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                Console.ReadKey();
            }
        }

        private void CrearCirculo()
        {
            Console.Write("Ingrese el radio del círculo: ");
            if (double.TryParse(Console.ReadLine(), out double radio))
            {
                figuraActual = new Circulo(radio);
                Console.WriteLine("Círculo creado con éxito.");
            }
            else
            {
                Console.WriteLine("Valor no válido.");
            }
            Console.ReadKey();
        }

        private void CrearTrianguloIsosceles()
        {
            Console.Write("Ingrese la longitud de los lados iguales: ");
            if (double.TryParse(Console.ReadLine(), out double ladoIgual))
            {
                Console.Write("Ingrese la base: ");
                if (double.TryParse(Console.ReadLine(), out double baseT))
                {
                    Console.Write("Ingrese la altura: ");
                    if (double.TryParse(Console.ReadLine(), out double altura))
                    {
                        figuraActual = new Triangulo(ladoIgual, baseT, altura);
                        Console.WriteLine("Triángulo isósceles creado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Valor de la altura no válido.");
                    }

                }
                else
                {
                    Console.WriteLine("Valor de la base no válido.");
                }
            }
            else
            {
                Console.WriteLine("Valor de los lados iguales no válido.");
            }
            Console.ReadKey();
        }

        private void CrearCuadrado()
        {
            Console.Write("Ingrese la longitud de un lado del cuadrado: ");
            if (double.TryParse(Console.ReadLine(), out double lado))
            {
                figuraActual = new Cuadrado(lado);
                Console.WriteLine("Cuadrado creado con éxito.");
            }
            else
            {
                Console.WriteLine("Valor no válido.");
            }
            Console.ReadKey();
        }

        private void MostrarAreaYPerimetro()
        {
            if (figuraActual != null)
            {
                double area = figuraActual.CalcularArea();
                double perimetro = figuraActual.CalcularPerimetro();
                Console.WriteLine($"Área: {area}");
                Console.WriteLine($"Perímetro: {perimetro}");
            }
            else
            {
                Console.WriteLine("Primero debe crear una figura.");
            }
            Console.ReadKey();
        }
    }
}
