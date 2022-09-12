using System.Collections.Generic;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    /*Esta inteface se usa para integrar las firmas de los metodos que se 
    desean aplicar a la tabla InvLineaDeProducto en la DB
    */
    public interface IRepositorioInvLineaDeProducto
    {
        InvLineaDeProducto CreateInvLineaDeProducto(InvLineaDeProducto invLineaDeProducto);
        InvLineaDeProducto ReadInvLineaDeProducto(string InvLDPNombre);
        IEnumerable<InvLineaDeProducto> ReadAllInvLineasDeProductos();
        InvLineaDeProducto UpdateInvLineaDeProducto(InvLineaDeProducto invLineaDeProducto);
        void DeleteInvLineaDeProducto(int idInvLineaDeProducto);
        
    }
}