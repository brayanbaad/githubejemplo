using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class BuscarFigura
    {
        static FiguraService figuraServicio;
        public BuscarFigura()
        {
            figuraServicio = new FiguraService();
        }
        public void Buscar()
        {
            Console.Clear();
            Console.WriteLine("Digite el ID de la figura a buscar");
            string IDBuscada = Console.ReadLine();
            string figuraBuscada = figuraServicio.Buscar(IDBuscada);
            Console.WriteLine(figuraBuscada);
            Console.ReadKey();
        }
    }
}
