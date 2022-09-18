using System;
using System.Collections.Generic;
using System.Linq;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    public class RepositorioIngrediente : IRepositorioIngrediente
    {
        ///<summary>
        ///Referencia al Contexto de Ingrediente
        ///</summary>
        private readonly AppContext _appContext = new AppContext();
        ///<summary>
        ///Metodo Constructor Utiliza
        ///Inyección de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name = "appContext"></param>//
        /*
        public RepositorioIngrediente(AppContext appContext)
        {
            _appContext = appContext;
        }
        */
        /*method to Create a Ingrediente*/
        Ingrediente IRepositorioIngrediente.CreateIngrediente(Ingrediente ingrediente)
        {
            var ingredienteAdicionado = _appContext.Ingredientes!.Add(ingrediente);
            _appContext.SaveChanges();
            return ingredienteAdicionado!.Entity;
        }
        /*method to Read Ingrediente*/
        public Ingrediente ReadIngrediente(int idIngrediente)
        {
            Console.WriteLine("Ingrediente= "+idIngrediente);
            var ingrediente = _appContext.Ingredientes!.FirstOrDefault(p => p.Id==idIngrediente);
            return ingrediente!; 
            
        }

        /*method to Read Ingrediente*/
        public Ingrediente ReadIngredienteByName(string nameIngrediente)
        {
            Console.WriteLine("Ingrediente= "+nameIngrediente);
            var ingrediente = _appContext.Ingredientes!.FirstOrDefault(p => p.NombreIngrediente==nameIngrediente);
            return ingrediente!; 
            
        }
        /*method to list all Ingrediente*/
        IEnumerable<Ingrediente>IRepositorioIngrediente.ReadAllIngredientes()
        {
            return _appContext.Ingredientes!;
        }
        /*method to Update Ingrediente*/
        Ingrediente IRepositorioIngrediente.UpdateIngrediente(Ingrediente ingrediente)
        {
            var ingredienteEncontrado = _appContext.Ingredientes!.FirstOrDefault(p => p.Id==ingrediente.Id);
            if (ingredienteEncontrado != null)
            {
                ingredienteEncontrado.NombreIngrediente=ingrediente.NombreIngrediente;
                
                _appContext.SaveChanges();
            }
            return ingredienteEncontrado!;
        }
        /*method to Delete Ingrediente*/
        void IRepositorioIngrediente.DeleteIngrediente(int idIngrediente)
        {
            var ingredienteEncontrado = _appContext.Ingredientes!.FirstOrDefault(p => p.Id==idIngrediente);
            if (ingredienteEncontrado == null)
                Console.WriteLine("Ingrediente no se encontro en db");
            else
            {    
                _appContext.Ingredientes!.Remove(ingredienteEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }   
    }
}