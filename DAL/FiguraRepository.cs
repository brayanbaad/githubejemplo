using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FiguraRepository
    {
        private List<Figura> ListaFiguras;
        public FiguraRepository()
        {
            ListaFiguras = new List<Figura>();
        }
        public  void Guardar(Figura figura)
        {
            ListaFiguras.Add(figura);
        }
        public void Eliminar(Figura figura)
        {
            ListaFiguras.Remove(figura);
        }
        public List<Figura> ConsultarTodos()
        {
            return ListaFiguras;
        }
        public Figura Buscar(string ID)
        {
            foreach (var item in ListaFiguras)
            {
                if (item.IDFigura.Equals(ID))
                {
                    return item;
                }
            }
            return null;
        }
        public void EliminarTodo()
        {
            ListaFiguras.Clear();
        }
    }
}