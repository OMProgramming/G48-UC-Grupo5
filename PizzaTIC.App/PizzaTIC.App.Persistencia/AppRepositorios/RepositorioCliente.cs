using System;
using System.Collections.Generic;
using System.Linq;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
        ///<summary>
        ///Referencia al Contexto del Cliente
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructor Utiliza
        ///Inyección de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name = "appContext"></param>//
        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }
        /*method to Create a Cliente*/
        Cliente IRepositorioCliente.CreateCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.Clientes!.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado!.Entity;
        }
        /*method to Read cliente*/
        public Cliente ReadCliente(int idCliente)
        {
            Console.WriteLine("idCliente= "+idCliente);
            var cliente = _appContext.Clientes!.FirstOrDefault(p => p.Id==idCliente);
            return cliente!; 
            
        }
        /*method to list all clientes*/
        IEnumerable<Cliente>IRepositorioCliente.ReadAllClientes()
        {
            return _appContext.Clientes!;
        }
        /*method to Update Cliente*/
        Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
        {
            var clienteEncontrado = _appContext.Clientes!.FirstOrDefault(p => p.Id==cliente.Id);
            if (clienteEncontrado != null)
            {
                clienteEncontrado.UserName=cliente.UserName;
                clienteEncontrado.Password=cliente.Password;
                clienteEncontrado.Nombres=cliente.Nombres;
                clienteEncontrado.Apellidos=cliente.Apellidos;
                clienteEncontrado.Direccion=cliente.Direccion;
                clienteEncontrado.Ciudad=cliente.Ciudad;
                clienteEncontrado.Departamento=cliente.Departamento;
                clienteEncontrado.Pais=cliente.Pais;
                clienteEncontrado.Telefono=cliente.Telefono;
                clienteEncontrado.Email=cliente.Email;
                clienteEncontrado.formaDePago=cliente.formaDePago;
                //clienteEncontrado.Pedidos=cliente.Pedidos;

                _appContext.SaveChanges();
            }
            return clienteEncontrado!;
        }
        /*method to Delete cliente*/
        void IRepositorioCliente.DeleteCliente(int idCliente)
        {
            var clienteEncontrado = _appContext.Clientes!.FirstOrDefault(p => p.Id==idCliente);
            if (clienteEncontrado == null)
                Console.WriteLine("Cliente no se encontro en db");
            else
            {
                _appContext.Clientes!.Remove(clienteEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }    
    }

}