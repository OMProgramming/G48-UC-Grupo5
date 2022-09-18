using System.Collections.Generic;
using PizzaTIC.App.Dominio;
namespace PizzaTIC.App.Persistencia
{
    /*Esta inteface se usa para integrar las firmas de los metodos que se 
    desean aplicar a la tabla Combos en la DB
    */
    public interface IRepositorioCombo
    {
        Combo CreateCombo(Combo combo);
        Combo ReadCombo(int idCombo);
        IEnumerable<Combo> ReadAllCombos();
        Combo UpdateCombo(Combo combo);
        void DeleteCombo(int idCombo);
        
    }
}