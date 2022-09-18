using System;
using System.Collections.Generic;
using System.Linq;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    public class RepositorioCombo : IRepositorioCombo
    {
        ///<summary>
        ///Referencia al Contexto de Combo
        ///</summary>
        private readonly AppContext _appContext = new AppContext();
        ///<summary>
        ///Metodo Constructor Utiliza
        ///Inyección de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name = "appContext"></param>//
        /*
        public RepositorioPizza(AppContext appContext)
        {
            _appContext = appContext;
        }
        */
        /*method to Create a Combo*/
        Combo IRepositorioCombo.CreateCombo(Combo combo)
        {
            var comboAdicionado = _appContext.Combo!.Add(combo);
            _appContext.SaveChanges();
            return comboAdicionado!.Entity;
        }
        /*method to Read Combo*/
        public Combo ReadCombo(int idCombo)
        {
            Console.WriteLine("Combo= "+idCombo);
            var combo = _appContext.Combo!.FirstOrDefault(p => p.Id==idCombo);
            return combo!; 
            
        }
        /*method to list all Combo*/
        IEnumerable<Combo>IRepositorioCombo.ReadAllCombos()
        {
            return _appContext.Combo!;
        }
        /*method to Update Combo*/
        Combo IRepositorioCombo.UpdateCombo(Combo combo)
        {
            //Console.WriteLine("HERE: "+combo.Id);
            var comboEncontrado = _appContext.Combo!.FirstOrDefault(p => p.Id==combo.Id);
            if (comboEncontrado != null)
            {
                comboEncontrado.ComboNombre=combo.ComboNombre;
                comboEncontrado.ComboDescripcion=combo.ComboDescripcion;

                _appContext.SaveChanges();
            }
            return comboEncontrado!;
        }
        /*method to Delete Combo*/
        void IRepositorioCombo.DeleteCombo(int idCombo)
        {
            var comboEncontrado = _appContext.Combo!.FirstOrDefault(p => p.Id==idCombo);
            if (comboEncontrado == null)
                Console.WriteLine("Combo no se encontro en db");
            else
            {    
                _appContext.Combo!.Remove(comboEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }   
    }
}