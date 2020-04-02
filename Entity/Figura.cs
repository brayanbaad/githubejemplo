using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Figura
    {
        public string IDFigura { get; set; }
        public string NombreFigura { get; set; }
        public string TipoFigura { get; set; }
        public decimal LadoA { get; set; }
        public decimal LadoB { get; set; }
        public virtual decimal AreaFigura { get; set; }
        public override string ToString()
        {
            return $"El {NombreFigura} con ID {IDFigura} es de tipo {TipoFigura} y tiene una área de: {AreaFigura} U^2";
        }
    }
}
