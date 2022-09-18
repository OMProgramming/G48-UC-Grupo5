using System;
using System.Collections.Generic;
using System.Linq;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    public class RepositorioPizza : IRepositorioPizza
    {
        ///<summary>
        ///Referencia al Contexto de Pizza
        ///</summary>
        private readonly AppContext _appContext = new AppContext();
        ///<summary>
        ///Metodo Constructor Utiliza
        ///Inyección de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name = "appContext"></param>//
        /*
        public RepositorioPizza(AppContext appContext)
        {
            _appContext = appContext;
        }
        */
        /*method to Create a Pizza*/
        Pizza IRepositorioPizza.CreatePizza(Pizza pizza)
        {
            var pizzaAdicionado = _appContext.Pizzas!.Add(pizza);
            _appContext.SaveChanges();
            return pizzaAdicionado!.Entity;
        }
        /*method to Read Pizza*/
        public Pizza ReadPizza(int idPizza)
        {
            Console.WriteLine("Pizza= "+idPizza);
            var pizza = _appContext.Pizzas!.FirstOrDefault(p => p.Id==idPizza);
            return pizza!; 
            
        }
        /*method to list all Pizza*/
        IEnumerable<Pizza>IRepositorioPizza.ReadAllPizzas()
        {
            return _appContext.Pizzas!;
        }

        /*method to Update Pizza*/
        Pizza IRepositorioPizza.UpdatePizza(Pizza pizza)
        {
            //Console.WriteLine("HERE: "+pizza.Id);
            var pizzaEncontrado = _appContext.Pizzas!.FirstOrDefault(p => p.Id==pizza.Id);
            if (pizzaEncontrado != null)
            {
                //pizzaEncontrado.InvProductos=pizza.Id;
                //Console.WriteLine("HERE: "+pizza.INVProductoCodigo);
                pizzaEncontrado.InvProductos=pizza.InvProductos;
                pizzaEncontrado.PizzaNombre=pizza.PizzaNombre;
                pizzaEncontrado.PizzaDescripcion=pizza.PizzaDescripcion;
                pizzaEncontrado.Ingredientes=pizza.Ingredientes;
                pizzaEncontrado.comidaTamano=pizza.comidaTamano;
                pizzaEncontrado.Combo=pizza.Combo;

                _appContext.SaveChanges();
            }
            return pizzaEncontrado!;
        }
        /*method to Delete Pizza*/
        void IRepositorioPizza.DeletePizza(int idPizza)
        {
            var pizzaEncontrado = _appContext.Pizzas!.FirstOrDefault(p => p.Id==idPizza);
            if (pizzaEncontrado == null)
                Console.WriteLine("Pizza no se encontro en db");
            else
            {    
                _appContext.Pizzas!.Remove(pizzaEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }   
    }
}