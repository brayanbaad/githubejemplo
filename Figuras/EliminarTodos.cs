using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class EliminarTodos
    {
        static FiguraService figuraServicio;
        public EliminarTodos()
        {
            figuraServicio = new FiguraService();
        }
        public void EliminarTodasLasFiguras()
        {
            Console.Clear();
            string mensaje = figuraServicio.EliminarTodo();
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
    }
}
