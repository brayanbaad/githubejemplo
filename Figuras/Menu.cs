using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Menu
    {
        AgregarFigura agregar = new AgregarFigura();
        RegistroFigura registro = new RegistroFigura();
        BuscarFigura buscar = new BuscarFigura();
        ModificarFigura modificar = new ModificarFigura();
        EliminarFigura eliminar = new EliminarFigura();
        EliminarTodos eliminarTodos = new EliminarTodos();
        public void MenuPrincipal()
        {
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("Qué desea hacer? \n");
                Console.WriteLine("1.- Calcular el área de una nueva figura");
                Console.WriteLine("2.- Registro de todas las figuras");
                Console.WriteLine("3.- Buscar una figura");
                Console.WriteLine("4.- Modificar los datos de una figura");
                Console.WriteLine("5.- Eliminar una figura ya registrada");
                Console.WriteLine("6.- Eliminar todas las figuras");
                Console.WriteLine("7.- SALIR\n");

                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        agregar.AgregarNuevaFigura();
                    break;

                    case 2:
                        registro.RegistroTotalFigura();
                    break;

                    case 3:
                        buscar.Buscar();
                    break;

                    case 4:
                        modificar.Modificar(); 
                    break;

                    case 5:
                        eliminar.Eliminar(); 
                    break;

                    case 6:
                        eliminarTodos.EliminarTodasLasFiguras();
                    break;
                }
            } while (op != 7);
        }
    }
}
