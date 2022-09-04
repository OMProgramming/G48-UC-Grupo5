using System.Collections.Generic;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    /*Esta inteface se usa para integrar las firmas de los metodos que se 
    desean aplicar a la tabla ComidaTamano en la DB
    */
    public interface IRepositorioComidaTamano
    {
        ComidaTamano CreateComidaTamano(ComidaTamano comidaTamano);
        ComidaTamano ReadComidaTamano(int idComidaTamano);
        IEnumerable<ComidaTamano> ReadAllComidasTamanos();
        ComidaTamano UpdateComidaTamano(ComidaTamano comidaTamano);
        void DeleteComidaTamano(int idComidaTamano);
    }
}