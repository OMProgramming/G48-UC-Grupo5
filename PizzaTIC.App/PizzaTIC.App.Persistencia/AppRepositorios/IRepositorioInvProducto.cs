using System.Collections.Generic;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    /*Esta inteface se usa para integrar las firmas de los metodos que se 
    desean aplicar a la tabla InvProducto en la DB
    */
    public interface IRepositorioInvProducto
    {
        InvProducto CreateInvProducto(InvProducto invProducto);
        InvProducto ReadInvProducto(string InvProductoNombre);
        IEnumerable<InvProducto> ReadAllInvProductos();
        InvProducto UpdateInvProducto(InvProducto invInvProducto);
        void DeleteInvProducto(int idInvProducto);
        
    }
}