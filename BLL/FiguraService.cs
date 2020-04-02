using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class FiguraService
    {
        static FiguraRepository figuraRepositorio;
        
        public FiguraService()
        {
            figuraRepositorio = new FiguraRepository();
        }
        public string Guardar(Figura figura)
        {
            try
            {
                
                if (figuraRepositorio.Buscar(figura.IDFigura) == null)
                {
                    figuraRepositorio.Guardar(figura);
                    return $"El {figura.NombreFigura} ha sido guardado correctamente";
                }
                else
                {
                    return $"Lo sentimos, los datos de {figura.NombreFigura} ya se encuentran registrado";
                }
            }
            catch (Exception error)
            {
                return $"Error de la Aplicación: {error.Message}";
            }
        }

        public string ELiminar(string ID)
        {
            
            try
            {
                Figura figura = figuraRepositorio.Buscar(ID);

                if (figura != null)
                {
                    figuraRepositorio.Eliminar(figura);
                    return $"El {figura.NombreFigura} ha sido eliminado correctamente";
                }
                else
                {
                    return $"Lo sentimos, la figura con ID: {ID} no se encuentran registrada";
                }
            }
            catch (Exception error)
            {
                return $"Error de la Aplicación: {error.Message}";
            }
        }

        public List<Figura> Consultar()
        {
            return figuraRepositorio.ConsultarTodos();
        }

        public string Buscar(string ID)
        {
            Figura figura = figuraRepositorio.Buscar(ID);

            if(figura == null)
            {
                return $"La figura con ID {ID} no existe";
            }
            else
            {
                return figura.ToString();
            }
        }
        public Figura Modificar(string ID)
        {
            return figuraRepositorio.Buscar(ID);
        }
        public string EliminarTodo()
        {
            try
            {
                List<Figura> ListaFiguras = new List<Figura>();
                ListaFiguras = figuraRepositorio.ConsultarTodos();
                if (ListaFiguras != null)
                {
                    figuraRepositorio.EliminarTodo();
                    return $"La lista de registro de figuras ha sido borrada con éxito";
                }
                else
                {
                    return $"La lista está vacía, no hay nada que borrar";
                }
            }
            catch (Exception error)
            {
                return $"Error de la Aplicación: {error.Message}";
            }
        }
    }
}