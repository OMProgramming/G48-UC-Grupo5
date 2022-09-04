using System.Collections.Generic;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    /*Esta inteface se usa para integrar las firmas de los metodos que se 
    desean aplicar a la tabla FormaDePago en la DB
    */
    public interface IRepositorioFormaDePago
    {
        FormaDePago CreateFormaDePago(FormaDePago formaDePago);
        FormaDePago ReadFormaDePago(int idFormaDePago);
        IEnumerable<FormaDePago> ReadAllFormasDePagos();
        FormaDePago UpdateFormaDePago(FormaDePago formaDePago);
        void DeleteFormaDePago(int idFormaDePago);
        
    }
}