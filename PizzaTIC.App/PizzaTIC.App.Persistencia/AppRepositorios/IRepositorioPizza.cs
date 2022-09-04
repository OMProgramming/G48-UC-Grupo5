using System.Collections.Generic;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    /*Esta inteface se usa para integrar las firmas de los metodos que se 
    desean aplicar a la tabla Pizza en la DB
    */
    public interface IRepositorioPizza
    {
        Pizza CreatePizza(Pizza pizza);
        Pizza ReadPizza(int idPizza);
        IEnumerable<Pizza> ReadAllPizzas();
        Pizza UpdatePizza(Pizza pizza);
        void DeletePizza(int idPizza);
        
    }
}