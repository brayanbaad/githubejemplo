using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class EliminarFigura
    {
        static FiguraService figuraServicio;
        public EliminarFigura()
        {
            figuraServicio = new FiguraService();
        }
        public void Eliminar()
        {
            Console.Clear();
            Console.WriteLine("Digite el ID de la figura a buscar");
            string IDBuscada = Console.ReadLine();
            string figuraBuscada = figuraServicio.ELiminar(IDBuscada);
            Console.WriteLine(figuraBuscada);
            Console.ReadKey();
        }
    }
}
