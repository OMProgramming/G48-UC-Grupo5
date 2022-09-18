using System;
using System.Collections.Generic;
using System.Linq;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    public class RepositorioComidaTamano : IRepositorioComidaTamano
    {
        ///<summary>
        ///Referencia al Contexto de ComidaTamano
        ///</summary>
        private readonly AppContext _appContext = new AppContext();
        ///<summary>
        ///Metodo Constructor Utiliza
        ///Inyección de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name = "appContext"></param>//
        /*
        public RepositorioComidaTamano(AppContext appContext)
        {
            _appContext = appContext;
        }
        */
        /*method to Create a ComidaTamano*/
        ComidaTamano IRepositorioComidaTamano.CreateComidaTamano(ComidaTamano comidaTamano)
        {
            var comidaTamanoAdicionado = _appContext.ComidaTamanos!.Add(comidaTamano);
            _appContext.SaveChanges();
            return comidaTamanoAdicionado!.Entity;
        }
        /*method to Read ComidaTamano*/
        public ComidaTamano ReadComidaTamano(int idComidaTamano)
        {
            Console.WriteLine("ComidaTamano= "+idComidaTamano);
            var comidaTamano = _appContext.ComidaTamanos!.FirstOrDefault(p => p.Id==idComidaTamano);
            return comidaTamano!; 
            
        }
        /*method to list all ComidaTamano*/
        IEnumerable<ComidaTamano>IRepositorioComidaTamano.ReadAllComidasTamanos()
        {
            return _appContext.ComidaTamanos!;
        }
        /*method to Update ComidaTamano*/
        ComidaTamano IRepositorioComidaTamano.UpdateComidaTamano(ComidaTamano comidaTamano)
        {
            Console.WriteLine("ComidaTamano.Id= "+comidaTamano.Id);
            var comidaTamanoEncontrado = _appContext.ComidaTamanos!.FirstOrDefault(p => p.Id==comidaTamano.Id);
            if (comidaTamanoEncontrado != null)
            {
                comidaTamanoEncontrado.ComidaTamanoNombre=comidaTamano.ComidaTamanoNombre;
                comidaTamanoEncontrado.NumeroIngredientes=comidaTamano.NumeroIngredientes;
                comidaTamanoEncontrado.PrecioUnitario=comidaTamano.PrecioUnitario;
                comidaTamanoEncontrado.Peso=comidaTamano.Peso;
                comidaTamanoEncontrado.Ancho=comidaTamano.Ancho;
                comidaTamanoEncontrado.Largo=comidaTamano.Largo;
                comidaTamanoEncontrado.Alto=comidaTamano.Alto;
                comidaTamanoEncontrado.TipoEmpaque=comidaTamano.TipoEmpaque;

                _appContext.SaveChanges();
            }
            return comidaTamanoEncontrado!;
        }
        /*method to Delete ComidaTamano*/
        void IRepositorioComidaTamano.DeleteComidaTamano(int idComidaTamano)
        {
            var comidaTamanoEncontrado = _appContext.ComidaTamanos!.FirstOrDefault(p => p.Id==idComidaTamano);
            if (comidaTamanoEncontrado == null)
                Console.WriteLine("ComidaTamano no se encontro en db");
            else
            {    
                _appContext.ComidaTamanos!.Remove(comidaTamanoEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }   
    }
}