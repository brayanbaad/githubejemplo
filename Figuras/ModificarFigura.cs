using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class ModificarFigura
    {
        static FiguraService figuraServicio;
        public ModificarFigura()
        {
            figuraServicio = new FiguraService();
        }
        public void Modificar()
        {
            int op;
            Console.Clear();
            Console.WriteLine("Digite la ID de la figura que desea modificar: ");
            string IDBuscada = Console.ReadLine();
            Figura figura = figuraServicio.Modificar(IDBuscada);
            if(figura == null)
            {
                Console.WriteLine($"La figura con ID {IDBuscada} no existe");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Figura encontrada!");
                if (figura.TipoFigura.Equals("Cuadrilátero"))
                {
                    do
                    {
                        Console.WriteLine($"Qué campo del Cuadrilátero {figura.NombreFigura} desea editar?");
                        Console.WriteLine("1.- ID de la figura");
                        Console.WriteLine("2.- Nombre de la figura");
                        Console.WriteLine("3.- Tipo de la figura");
                        Console.WriteLine("4.- Lado A de la figura");
                        Console.WriteLine("5.- Lado B de la figura");
                        Console.WriteLine("6.- SALIR\n");

                        op = Convert.ToInt32(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                CambiarID(figura);
                                break;

                            case 2:
                                CambiarNombre(figura);
                                break;

                            case 3:
                                CambiarTipoAlCuadrilatero(figura);
                                break;

                            case 4:
                                CambiarLadoA();
                                break;

                            case 5:
                                CambiarLadoB();
                                break;
                        }
                    } while (op != 6);
                    void CambiarLadoA()
                    {
                        Console.WriteLine("Digite el nuevo valor del Lado A");
                        figura.LadoA = Convert.ToDecimal(Console.ReadLine());
                    }
                    void CambiarLadoB()
                    {
                        Console.WriteLine("Digite el nuevo valor del Lado B");
                        figura.LadoB = Convert.ToDecimal(Console.ReadLine());
                    }
                }
                else if (figura.TipoFigura.Equals("Triángulo"))
                {
                    do
                    {
                        Console.WriteLine($"Qué campo del Triangulo {figura.NombreFigura} desea editar?");
                        Console.WriteLine("1.- ID de la figura");
                        Console.WriteLine("2.- Nombre de la figura");
                        Console.WriteLine("3.- Tipo de la figura");
                        Console.WriteLine("4.- Base de la figura");
                        Console.WriteLine("5.- Altura de la figura");
                        Console.WriteLine("6.- SALIR\n");

                        op = Convert.ToInt32(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                CambiarID(figura);
                                break;

                            case 2:
                                CambiarNombre(figura);
                                break;

                            case 3:
                                CambiarTipoAlTriangulo(figura);
                                break;

                            case 4:
                                CambiarBase();
                                break;

                            case 5:
                                CambiarAltura();
                                break;
                        }
                    } while (op != 6);
                    void CambiarBase()
                    {
                        Console.WriteLine("Digite el nuevo valor de la Base");
                        figura.LadoA = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Los datos han sido actualizados correctamente");
                        Console.ReadKey();
                    }
                    void CambiarAltura()
                    {
                        Console.WriteLine("Digite el nuevo valor de la Altura");
                        figura.LadoB = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Los datos han sido actualizados correctamente");
                        Console.ReadKey();
                    }
                }
                else if (figura.TipoFigura.Equals("Circulo"))
                {
                    do
                    {
                        Console.WriteLine($"Qué campo del Circulo {figura.NombreFigura} desea editar?");
                        Console.WriteLine("1.- ID de la figura");
                        Console.WriteLine("2.- Nombre de la figura");
                        Console.WriteLine("3.- Tipo de la figura");
                        Console.WriteLine("4.- Radio de la figura");
                        Console.WriteLine("5.- SALIR\n");

                        op = Convert.ToInt32(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                CambiarID(figura);
                                break;

                            case 2:
                                CambiarNombre(figura);
                                break;

                            case 3:
                                CambiarTipoAlCirculo(figura);
                                break;

                            case 4:
                                CambiarRadio();
                                break;
                        }
                    } while (op != 5);
                    void CambiarRadio()
                    {
                        Console.WriteLine("Digite el nuevo valor del radio");
                        figura.LadoA = Convert.ToDecimal(Console.ReadLine());
                        figura.LadoB = figura.LadoA * 2;
                        Console.WriteLine("Los datos han sido actualizados correctamente");
                        Console.ReadKey();
                    }
                }
                else if (figura.TipoFigura.Equals("Rombo"))
                {
                    do
                    {
                        Console.WriteLine($"Qué campo del Rombo {figura.NombreFigura} desea editar?");
                        Console.WriteLine("1.- ID de la figura");
                        Console.WriteLine("2.- Nombre de la figura");
                        Console.WriteLine("3.- Tipo de la figura");
                        Console.WriteLine("4.- Diagonal Mayor de la figura");
                        Console.WriteLine("5.- Diagonal Menor de la figura");
                        Console.WriteLine("6.- SALIR\n");

                        op = Convert.ToInt32(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                CambiarID(figura);
                                break;

                            case 2:
                                CambiarNombre(figura);
                                break;

                            case 3:
                                CambiarTipoAlRombo(figura);
                                break;

                            case 4:
                                CambiarDiagonalMayor();
                                break;

                            case 5:
                                CambiarDiagonalMenor();
                                break;
                        }
                    } while (op != 6);
                    void CambiarDiagonalMayor()
                    {
                        Console.WriteLine("Digite el nuevo valor de la Diagonal Mayor");
                        figura.LadoA = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Los datos han sido actualizados correctamente");
                        Console.ReadKey();
                    }
                    void CambiarDiagonalMenor()
                    {
                        Console.WriteLine("Digite el nuevo valor de la Diagonal Menor");
                        figura.LadoB = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Los datos han sido actualizados correctamente");
                        Console.ReadKey();
                    }
                }
                else if(figura.TipoFigura.Equals("Polígono regular"))
                {
                    do
                    {
                        Console.WriteLine($"Qué campo del Polígono Regular {figura.NombreFigura} desea editar?");
                        Console.WriteLine("1.- ID de la figura");
                        Console.WriteLine("2.- Nombre de la figura");
                        Console.WriteLine("3.- Tipo de la figura");
                        Console.WriteLine("4.- Cantidad y longitud de lados de la figura");
                        Console.WriteLine("5.- SALIR\n");

                        op = Convert.ToInt32(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                CambiarID(figura);
                                break;

                            case 2:
                                CambiarNombre(figura);
                                break;

                            case 3:
                                CambiarTipoAlPoligonoRegular(figura);
                                break;

                            case 4:
                                CambiarCantidadYLongitudDeLados();
                                break;

                            
                        }
                    } while (op != 5);
                    void CambiarCantidadYLongitudDeLados()
                    { 
                        Console.WriteLine("Por favor digite el nuevo número de lados que posee el polígono: ");
                        Console.Write("Número de lados: ");
                        int numeroLados = Convert.ToInt32(Console.ReadLine());
                        if(numeroLados < 3)
                        {
                            Console.WriteLine("ERROR. No existe un polígono de menos de 3 lados. Por favor ingrese un valor lógico");
                        }
                        else
                        {
                            Console.WriteLine("Por favor digite la nueva medida de un lado de el polígono: ");
                            Console.Write("Longitud de lado: ");
                            decimal longitudLado = Convert.ToDecimal(Console.ReadLine());
                            if (longitudLado <= 0)
                            {
                                Console.WriteLine("ERROR. Ingrese una longitud lógica");
                            }
                            else
                            {
                                figura.LadoA = Convert.ToDecimal(Convert.ToDecimal(numeroLados) * longitudLado);
                                Console.WriteLine("Los datos han sido actualizados correctamente");
                                Console.ReadKey();
                            }
                        }
                    }
                }
            }
        }
        public void CambiarID(Figura figura)
        {
            Console.WriteLine("Digite la nueva ID:");
            string nuevaID = Console.ReadLine();
            if(figuraServicio.Modificar(nuevaID) != null)
            {
                Console.WriteLine("ERROR. Ya esa ID está registrada");
            }
            else
            {
                figura.IDFigura = nuevaID;
                Console.WriteLine("Los datos han sido actualizados correctamente");
                Console.ReadKey();
            }
        }
        public void CambiarNombre(Figura figura)
        {
            Console.WriteLine("Digite El nuevo nombre");
            figura.NombreFigura = Console.ReadLine();
            Console.WriteLine("Los datos han sido actualizados correctamente");
            Console.ReadKey();
        }
        public void CambiarTipoAlCuadrilatero(Figura figura)
        {
            int opcion;
            Console.WriteLine("Escoja el nuevo tipo de la figura");
            Console.WriteLine("1.- Triángulo");
            Console.WriteLine("2.- Circulo");
            Console.WriteLine("3.- Rombo");
            Console.WriteLine("4.- Polígono regular");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ConvertirATriangulo(figura);
                break;

                case 2:
                    ConvertirACirculo(figura);
                break;

                case 3:
                    ConvertirARombo(figura);
                break;

                case 4:
                    ConvertirAPoligonoRegular(figura);
                break;
            }
        }
        public void CambiarTipoAlTriangulo(Figura figura)
        {
            int opcion;
            Console.WriteLine("Escoja el nuevo tipo de la figura");
            Console.WriteLine("1.- Cuadrilátero");
            Console.WriteLine("2.- Circulo");
            Console.WriteLine("3.- Rombo");
            Console.WriteLine("4.- Polígono regular");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ConvertirACuadrilatero(figura);
                    break;

                case 2:
                    ConvertirACirculo(figura);
                    break;

                case 3:
                    ConvertirARombo(figura);
                    break;

                case 4:
                    ConvertirAPoligonoRegular(figura);
                    break;
            }
            

        }
        public void CambiarTipoAlCirculo(Figura figura)
        {
            int opcion;
            Console.WriteLine("Escoja el nuevo tipo de la figura");
            Console.WriteLine("1.- Cuadrilátero");
            Console.WriteLine("2.- Triángulo");
            Console.WriteLine("3.- Rombo");
            Console.WriteLine("4.- Polígono regular");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ConvertirACuadrilatero(figura);
                    break;

                case 2:
                    ConvertirATriangulo(figura);
                    break;

                case 3:
                    ConvertirARombo(figura);
                    break;

                case 4:
                    ConvertirAPoligonoRegular(figura);
                    break;
            }
        }
        public void CambiarTipoAlRombo(Figura figura)
        {
            int opcion;
            Console.WriteLine("Escoja el nuevo tipo de la figura");
            Console.WriteLine("1.- Cuadrilátero");
            Console.WriteLine("2.- Triángulo");
            Console.WriteLine("3.- Circulo");
            Console.WriteLine("4.- Polígono regular");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ConvertirACuadrilatero(figura);
                    break;

                case 2:
                    ConvertirATriangulo(figura);
                    break;

                case 3:
                    ConvertirACirculo(figura);
                    break;

                case 4:
                    ConvertirAPoligonoRegular(figura);
                    break;
            }
        }
        public void CambiarTipoAlPoligonoRegular(Figura figura)
        {
            int opcion;
            Console.WriteLine("Escoja el nuevo tipo de la figura");
            Console.WriteLine("1.- Cuadrilátero");
            Console.WriteLine("2.- Triángulo");
            Console.WriteLine("3.- Circulo");
            Console.WriteLine("4.- Rombo");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ConvertirACuadrilatero(figura);
                    break;

                case 2:
                    ConvertirATriangulo(figura);
                    break;

                case 3:
                    ConvertirACirculo(figura);
                    break;

                case 4:
                    ConvertirARombo(figura);
                    break;
            }
        }
        public void ConvertirACuadrilatero(Figura figura)
        {
            figura.TipoFigura = "Cuadrilátero";
            Figura nuevaFigura = new Cuadrado();
            nuevaFigura.IDFigura = figura.IDFigura;
            nuevaFigura.NombreFigura = figura.NombreFigura;
            nuevaFigura.TipoFigura = figura.TipoFigura;
            nuevaFigura.LadoA = figura.LadoA;
            nuevaFigura.LadoB = figura.LadoB;
            figuraServicio.ELiminar(figura.IDFigura);
            figuraServicio.Guardar(nuevaFigura);
            Console.WriteLine("Los datos han sido actualizados correctamente");
            Console.ReadKey();
        }
        public void ConvertirATriangulo(Figura figura)
        {
            figura.TipoFigura = "Triángulo";
            Figura nuevaFigura = new Triangulo();
            nuevaFigura.IDFigura = figura.IDFigura;
            nuevaFigura.NombreFigura = figura.NombreFigura;
            nuevaFigura.TipoFigura = figura.TipoFigura;
            nuevaFigura.LadoA = figura.LadoA;
            nuevaFigura.LadoB = figura.LadoB;
            figuraServicio.ELiminar(figura.IDFigura);
            figuraServicio.Guardar(nuevaFigura);
            Console.WriteLine("Los datos han sido actualizados correctamente");
            Console.ReadKey();
        }
        public void ConvertirACirculo(Figura figura)
        {
            figura.TipoFigura = "Circulo";
            Figura nuevaFigura = new Circulo();
            nuevaFigura.IDFigura = figura.IDFigura;
            nuevaFigura.NombreFigura = figura.NombreFigura;
            nuevaFigura.TipoFigura = figura.TipoFigura;
            nuevaFigura.LadoA = figura.LadoA;
            nuevaFigura.LadoB = figura.LadoA * 2;
            figuraServicio.ELiminar(figura.IDFigura);
            figuraServicio.Guardar(nuevaFigura);
            Console.WriteLine("Los datos han sido actualizados correctamente");
            Console.ReadKey();
        }
        public void ConvertirARombo(Figura figura)
        {
            figura.TipoFigura = "Rombo";
            Figura nuevaFigura = new Rombo();
            nuevaFigura.IDFigura = figura.IDFigura;
            nuevaFigura.NombreFigura = figura.NombreFigura;
            nuevaFigura.TipoFigura = figura.TipoFigura;
            nuevaFigura.LadoA = figura.LadoA;
            nuevaFigura.LadoB = figura.LadoB;
            figuraServicio.ELiminar(figura.IDFigura);
            figuraServicio.Guardar(nuevaFigura);
            Console.WriteLine("Los datos han sido actualizados correctamente");
            Console.ReadKey();
        }
        public void ConvertirAPoligonoRegular(Figura figura)
        {
            figura.TipoFigura = "Polígono regular";
            Figura nuevaFigura = new PoligonoRegular();
            nuevaFigura.IDFigura = figura.IDFigura;
            nuevaFigura.NombreFigura = figura.NombreFigura;
            nuevaFigura.TipoFigura = figura.TipoFigura;
            Console.WriteLine("Los polígonos son un caso especial dentro del programa, por lo cual, es necesario que el usuario digite los datos a continuación:\n");
            Console.WriteLine("Por favor digite el número de lados que posee el polígono: ");
            Console.Write("Número de lados: ");
            int numeroLados = Convert.ToInt32(Console.ReadLine());
            if(numeroLados < 3)
            {
                Console.WriteLine("ERROR. No existe un polígono de menos de 3 lados. Por favor ingrese un valor lógico");
            }
            else
            {
                Console.WriteLine("Por favor digite la medida de un lado de el polígono: ");
                Console.Write("Longitud de lado: ");
                decimal longitudLado = Convert.ToDecimal(Console.ReadLine());
                if(longitudLado <= 0)
                {
                    Console.WriteLine("ERROR. Ingrese una longitud lógica");
                }
                else
                {
                    nuevaFigura.LadoA = Convert.ToDecimal(Convert.ToDecimal(numeroLados) * longitudLado);
                    decimal angulo = 360 / (2 * numeroLados);
                    double apotema = Math.Abs(Convert.ToDouble(longitudLado) / (2 * (Math.Tan(Convert.ToDouble(angulo)))));
                    nuevaFigura.LadoB = Convert.ToDecimal(apotema);
                    figuraServicio.ELiminar(figura.IDFigura);
                    figuraServicio.Guardar(nuevaFigura);
                    Console.WriteLine("Los datos han sido actualizados correctamente");
                    Console.ReadKey();
                }
            }
        }
    }
}