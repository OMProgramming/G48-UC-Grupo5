using System;
using System.Collections.Generic;
using System.Linq;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    public class RepositorioInvProducto : IRepositorioInvProducto
    {
        ///<summary>
        ///Referencia al Contexto de InvProducto
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructor Utiliza
        ///Inyección de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name = "appContext"></param>//
        public RepositorioInvProducto(AppContext appContext)
        {
            _appContext = appContext;
        }
        /*method to Create a InvProducto*/
        InvProducto IRepositorioInvProducto.CreateInvProducto(InvProducto invProducto)
        {
            var invProductoAdicionado = _appContext.InvProductos!.Add(invProducto);
            _appContext.SaveChanges();
            return invProductoAdicionado!.Entity;
        }
        /*method to Read InvProducto*/
        public InvProducto ReadInvProducto(int idInvProducto)
        {
            Console.WriteLine("InvProducto= "+idInvProducto);
            var invProducto = _appContext.InvProductos!.FirstOrDefault(p => p.Id==idInvProducto);
            return invProducto!; 
            
        }
        /*method to list all InvProducto*/
        IEnumerable<InvProducto>IRepositorioInvProducto.ReadAllInvProductos()
        {
            return _appContext.InvProductos!;
        }
        /*method to Update InvProducto*/
        InvProducto IRepositorioInvProducto.UpdateInvProducto(InvProducto invProducto)
        {
            var invProductoEncontrado = _appContext.InvProductos!.FirstOrDefault(p => p.Id==invProducto.Id);
            if (invProductoEncontrado != null)
            {
                invProductoEncontrado.InvLineaDeProductos=invProducto.InvLineaDeProductos;
                invProductoEncontrado.INVProductoCodigo=invProducto.INVProductoCodigo;
                invProductoEncontrado.INVProductoNombre=invProducto.INVProductoNombre;
                invProductoEncontrado.Pizzas=invProducto.Pizzas;
                invProductoEncontrado.Hamburgesas=invProducto.Hamburgesas;
                invProductoEncontrado.Perros=invProducto.Perros;
                invProductoEncontrado.Pasteles=invProducto.Pasteles;
                invProductoEncontrado.Acompanamientos=invProducto.Acompanamientos;
                invProductoEncontrado.JugosNaturales=invProducto.JugosNaturales;
                invProductoEncontrado.BebidasCalientes=invProducto.BebidasCalientes;
                invProductoEncontrado.Postres=invProducto.Postres;
                invProductoEncontrado.Helados=invProducto.Helados;
                invProductoEncontrado.Galletas=invProducto.Galletas;
                invProductoEncontrado.Combo=invProducto.Combo;

                _appContext.SaveChanges();
            }
            return invProductoEncontrado!;
        }
        /*method to Delete InvProducto*/
        void IRepositorioInvProducto.DeleteInvProducto(int idInvProducto)
        {
            var invProductoEncontrado = _appContext.InvProductos!.FirstOrDefault(p => p.Id==idInvProducto);
            if (invProductoEncontrado == null)
                Console.WriteLine("InvProducto no se encontro en db");
            else
            {    
                _appContext.InvProductos!.Remove(invProductoEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }   
    }
}