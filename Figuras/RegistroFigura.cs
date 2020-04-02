using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class RegistroFigura
    {
        static FiguraService figuraServicio;
        public RegistroFigura()
        {
            figuraServicio = new FiguraService();
        }
        public void RegistroTotalFigura()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            foreach (var item in figuraServicio.Consultar())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("-------------------------------------");
            Console.ReadKey();
        }
    }
}
