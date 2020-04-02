using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Cuadrado : Figura
    {
        public override decimal AreaFigura { get => (LadoA*LadoB); set => base.AreaFigura = value; }

    }
}
