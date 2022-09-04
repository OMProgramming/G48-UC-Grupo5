using System.Collections.Generic;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    /*Esta inteface se usa para integrar las firmas de los metodos que se 
    desean aplicar a la tabla clientes en la DB
    */
    public interface IRepositorioCliente
    {
        Cliente CreateCliente(Cliente cliente);
        Cliente ReadCliente(int idCliente);
        IEnumerable<Cliente> ReadAllClientes();
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int idCliente);
        
    }
}