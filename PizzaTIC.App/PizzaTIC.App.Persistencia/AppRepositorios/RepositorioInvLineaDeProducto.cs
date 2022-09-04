using System;
using System.Collections.Generic;
using System.Linq;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    public class RepositorioInvLineaDeProducto : IRepositorioInvLineaDeProducto
    {
        ///<summary>
        ///Referencia al Contexto de InvLineaDeProducto
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructor Utiliza
        ///Inyección de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name = "appContext"></param>//
        public RepositorioInvLineaDeProducto(AppContext appContext)
        {
            _appContext = appContext;
        }
        /*method to Create a InvLineaDeProducto*/
        InvLineaDeProducto IRepositorioInvLineaDeProducto.CreateInvLineaDeProducto(InvLineaDeProducto invLineaDeProducto)
        {
            var invLineaDeProductoAdicionado = _appContext.InvLineaDeProductos!.Add(invLineaDeProducto);
            _appContext.SaveChanges();
            return invLineaDeProductoAdicionado!.Entity;
        }
        /*method to Read InvLineaDeProducto*/
        public InvLineaDeProducto ReadInvLineaDeProducto(int idInvLineaDeProducto)
        {
            Console.WriteLine("InvLineaDeProducto= "+idInvLineaDeProducto);
            var invLineaDeProducto = _appContext.InvLineaDeProductos!.FirstOrDefault(p => p.Id==idInvLineaDeProducto);
            return invLineaDeProducto!; 
            
        }
        /*method to list all InvLineaDeProducto*/
        IEnumerable<InvLineaDeProducto>IRepositorioInvLineaDeProducto.ReadAllInvLineasDeProductos()
        {
            return _appContext.InvLineaDeProductos!;
        }
        /*method to Update InvLineDeProducto*/
        InvLineaDeProducto IRepositorioInvLineaDeProducto.UpdateInvLineaDeProducto(InvLineaDeProducto invLineaDeProducto)
        {
            var invLineaDeProductoEncontrado = _appContext.InvLineaDeProductos!.FirstOrDefault(p => p.Id==invLineaDeProducto.Id);
            if (invLineaDeProductoEncontrado != null)
            {
                invLineaDeProductoEncontrado.INVLPCodigo=invLineaDeProducto.INVLPCodigo;
                invLineaDeProductoEncontrado.INVLPNombre=invLineaDeProducto.INVLPNombre;
                invLineaDeProductoEncontrado.InvProductos=invLineaDeProducto.InvProductos;

                _appContext.SaveChanges();
            }
            return invLineaDeProductoEncontrado!;
        }
        /*method to Delete InvLineaDeProducto*/
        void IRepositorioInvLineaDeProducto.DeleteInvLineaDeProducto(int idInvLineaDeProducto)
        {
            var invLineaDeProductoEncontrado = _appContext.InvLineaDeProductos!.FirstOrDefault(p => p.Id==idInvLineaDeProducto);
            if (invLineaDeProductoEncontrado == null)
                Console.WriteLine("InvLineaDeProducto no se encontro en db");
            else
            {    
                _appContext.InvLineaDeProductos!.Remove(invLineaDeProductoEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }   
    }
}