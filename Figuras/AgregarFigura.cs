using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class AgregarFigura
    {
        static FiguraService figuraServicio = new FiguraService();
        
        public void AgregarNuevaFigura()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("Elija la figura de la que desea calcular el área: \n");
                Console.WriteLine("1.- Cuadrilátero");
                Console.WriteLine("2.- Triángulo");
                Console.WriteLine("3.- Circulo");
                Console.WriteLine("4.- Rombo");
                Console.WriteLine("5.- Polígono regular");
                Console.WriteLine("6.- SALIR\n");

                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        RecoleccionDatos(op);
                    break;

                    case 2:
                        RecoleccionDatos(op);
                    break;

                    case 3:
                        RecoleccionDatos(op);
                    break;

                    case 4:
                        RecoleccionDatos(op);
                    break;

                    case 5:
                        RecoleccionDatos(op);
                    break;
                }
            } while (op != 6);
        }
        public static void RecoleccionDatos(int op)
        {
            
            if (op == 1)
            {
                Console.Clear();
                Figura figura = new Cuadrado();
                Console.WriteLine("Por favor digite el ID de la figura: ");
                figura.IDFigura = Console.ReadLine();
                Console.WriteLine("Por favor digite el nombre de la figura: ");
                figura.NombreFigura = Console.ReadLine();
                figura.TipoFigura = "Cuadrilátero";
                Console.WriteLine("Por favor digite la base y la altura de la figura: ");
                Console.Write("Base: "); figura.LadoA = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Altura: "); figura.LadoB = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(figura.ToString());
                string mensaje = figuraServicio.Guardar(figura);
                Console.WriteLine(mensaje);
                Console.ReadKey();
            }
            else if (op == 2)
            {
                Console.Clear();
                Figura figura = new Triangulo();
                Console.WriteLine("Por favor digite el ID de la figura: ");
                figura.IDFigura = Console.ReadLine();
                Console.WriteLine("Por favor digite el nombre de la figura: ");
                figura.NombreFigura = Console.ReadLine();
                figura.TipoFigura = "Triángulo";
                Console.WriteLine("Por favor digite la base y la altura de la figura: ");
                Console.Write("Base: "); figura.LadoA = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Altura: "); figura.LadoB = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(figura.ToString());
                string mensaje = figuraServicio.Guardar(figura);
                Console.WriteLine(mensaje);
                Console.ReadKey();
            }
            else if(op == 3)
            {
                Console.Clear();
                Figura figura = new Circulo();
                Console.WriteLine("Por favor digite el ID de la figura: ");
                figura.IDFigura = Console.ReadLine();
                Console.WriteLine("Por favor digite el nombre de la figura: ");
                figura.NombreFigura = Console.ReadLine();
                figura.TipoFigura = "Circulo";
                Console.WriteLine("Por favor digite el radio de la figura: ");
                Console.Write("Radio: "); figura.LadoA = Convert.ToDecimal(Console.ReadLine());
                figura.LadoB = figura.LadoA*2;
                Console.WriteLine(figura.ToString());
                string mensaje = figuraServicio.Guardar(figura);
                Console.WriteLine(mensaje);
                Console.ReadKey();
            }
            else if(op == 4)
            {
                Console.Clear();
                Figura figura = new Rombo();
                Console.WriteLine("Por favor digite el ID de la figura: ");
                figura.IDFigura = Console.ReadLine();
                Console.WriteLine("Por favor digite el nombre de la figura: ");
                figura.NombreFigura = Console.ReadLine();
                figura.TipoFigura = "Rombo";
                Console.WriteLine("Por favor digite la diagonal mayor y la diagonal menor de la figura: ");
                Console.Write("Diagonal Mayor: "); figura.LadoA = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Diagonal Menor: "); figura.LadoB = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(figura.ToString());
                string mensaje = figuraServicio.Guardar(figura);
                Console.WriteLine(mensaje);
                Console.ReadKey();
            }
            else if(op == 5)
            {
                Console.Clear();
                Figura figura = new PoligonoRegular();
                Console.WriteLine("Por favor digite el ID de la figura: ");
                figura.IDFigura = Console.ReadLine();
                Console.WriteLine("Por favor digite el nombre de la figura: ");
                figura.NombreFigura = Console.ReadLine();
                figura.TipoFigura = "Polígono regular";
                Console.WriteLine("Por favor digite el número de lados que posee el polígono: ");
                Console.Write("Número de lados: ");
                int numeroLados = Convert.ToInt32(Console.ReadLine());
                if(numeroLados < 3)
                {
                    Console.WriteLine("ERROR. No existe un polígono de menos de 3 lados. Por favor ingrese un valor lógico");
                }
                else
                {
                    Console.WriteLine("Por favor digite la medida de un lado del polígono: ");
                    Console.Write("Longitud de lado: ");
                    decimal longitudLado = Convert.ToDecimal(Console.ReadLine());
                    if(longitudLado <= 0)
                    {
                        Console.WriteLine("ERROR. Ingrese una longitud lógica");
                    }
                    else
                    {
                        figura.LadoA = Convert.ToDecimal(Convert.ToDecimal(numeroLados) * longitudLado);
                        decimal angulo = 360 / (2 * numeroLados);
                        double apotema = Math.Abs(Convert.ToDouble(longitudLado) / (2 * (Math.Tan(Convert.ToDouble(angulo)))));
                        Console.WriteLine(apotema);
                        figura.LadoB = Convert.ToDecimal(apotema);
                        Console.WriteLine(figura.ToString());
                        string mensaje = figuraServicio.Guardar(figura);
                        Console.WriteLine(mensaje);
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}