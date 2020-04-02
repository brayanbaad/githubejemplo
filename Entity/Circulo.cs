using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Circulo : Figura
    {
        const double PI = 3.1415;
        public override decimal AreaFigura { get => Convert.ToDecimal(Convert.ToDouble(LadoA) * Convert.ToDouble(LadoA) * PI); set => base.AreaFigura = value; }

    }
}
