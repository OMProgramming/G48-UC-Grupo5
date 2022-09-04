using System.Collections.Generic;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    /*Esta inteface se usa para integrar las firmas de los metodos que se 
    desean aplicar a la tabla Ingredientes en la DB
    */
    public interface IRepositorioIngrediente
    {
        Ingrediente CreateIngrediente(Ingrediente ingrediente);
        Ingrediente ReadIngrediente(int idIngrediente);
        IEnumerable<Ingrediente> ReadAllIngredientes();
        Ingrediente UpdateIngrediente(Ingrediente ingrediente);
        void DeleteIngrediente(int idIngrediente);
    }
}