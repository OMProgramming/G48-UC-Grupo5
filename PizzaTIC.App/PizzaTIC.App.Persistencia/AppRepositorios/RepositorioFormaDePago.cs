using System;
using System.Collections.Generic;
using System.Linq;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    public class RepositorioFormaDePago : IRepositorioFormaDePago
    {
        ///<summary>
        ///Referencia al Contexto de FormaDePago
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructor Utiliza
        ///Inyección de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name = "appContext"></param>//
        public RepositorioFormaDePago(AppContext appContext)
        {
            _appContext = appContext;
        }
        /*method to Create a FormaDePago*/
        FormaDePago IRepositorioFormaDePago.CreateFormaDePago(FormaDePago formaDePago)
        {
            var formaDePagoAdicionado = _appContext.FormasDePagos!.Add(formaDePago);
            _appContext.SaveChanges();
            return formaDePagoAdicionado!.Entity;
        }
        /*method to Read FormaDePago*/
        public FormaDePago ReadFormaDePago(int idFormaDePago)
        {
            Console.WriteLine("idFormaDePago= "+idFormaDePago);
            var formaDePago = _appContext.FormasDePagos!.FirstOrDefault(p => p.Id==idFormaDePago);
            return formaDePago!; 
            
        }
        /*method to list all FormasDePagos*/
        IEnumerable<FormaDePago>IRepositorioFormaDePago.ReadAllFormasDePagos()
        {
            return _appContext.FormasDePagos!;
        }
        /*method to Update FormaDePago*/
        FormaDePago IRepositorioFormaDePago.UpdateFormaDePago(FormaDePago formaDePago)
        {
            var formaDePagoEncontrado = _appContext.FormasDePagos!.FirstOrDefault(p => p.Id==formaDePago.Id);
            if (formaDePagoEncontrado != null)
            {
                formaDePagoEncontrado.TipoDeTarjeta=formaDePago.TipoDeTarjeta;
                formaDePagoEncontrado.NombreEnTarjeta=formaDePago.NombreEnTarjeta;
                formaDePagoEncontrado.NumeroEnTarjeta=formaDePago.NumeroEnTarjeta;
                formaDePagoEncontrado.FechaDeVencimiento=formaDePago.FechaDeVencimiento;
                formaDePagoEncontrado.CodigoDeSeguridad=formaDePago.CodigoDeSeguridad;

                _appContext.SaveChanges();
            }
            return formaDePagoEncontrado!;
        }
        /*method to Delete FormaDePago*/
        void IRepositorioFormaDePago.DeleteFormaDePago(int idFormaDePago)
        {
            var formaDePagoEncontrado = _appContext.FormasDePagos!.FirstOrDefault(p => p.Id==idFormaDePago);
            if (formaDePagoEncontrado == null)
                Console.WriteLine("formaDePago no se encontro en db");
            else
            {    
                _appContext.FormasDePagos!.Remove(formaDePagoEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }   
    }
}