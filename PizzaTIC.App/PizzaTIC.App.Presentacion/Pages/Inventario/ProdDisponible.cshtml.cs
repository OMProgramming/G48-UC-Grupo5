using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaTIC.App.Persistencia;
using PizzaTIC.App.Dominio;
using System.Collections.Generic;

namespace PizzaTIC.App.Presentacion
{
    public class ProdDisponibleModel : PageModel
    {
        
        //Interface, repository and varaibles for Pizza
        private readonly IRepositorioPizza? _repositorioPizza;
        public Pizza? pizza {get; set;}
        public IEnumerable<Pizza>? listPizzas {get; set;}

        //constructor
        public ProdDisponibleModel (IRepositorioPizza repositorioPizza)
        {
            _repositorioPizza=repositorioPizza;
        }

        public string title;

        public void OnGet(string name)
        {
            Console.WriteLine("item:"+name); 
            title=name;
            ReadProducto(name);
        }
    


        public void ReadProducto(string prodName)
        {
            switch (prodName) 
            {
                case "Pizza": // statement sequence
                    Console.WriteLine("Pizzas :"+prodName);
                    listPizzas = _repositorioPizza.ReadAllPizzas();
                    break;

                case "Hamburgesa": // statement sequence
                    Console.WriteLine("Hamburgesas :"+prodName); 
                    break;

                case "Perro": // statement sequence
                    Console.WriteLine("Perros :"+prodName); 
                    break;
                
                case "Pastel": // statement sequence
                    break;
                
                case "Acompañante": // statement sequence
                    break;

                case "Jugo Natural": // statement sequence
                    break;

                case "Refresco": // statement sequence
                    break;

                case "Bebida Caliente": // statement sequence
                    break;

                case "Postre": // statement sequence
                    break;

                case "Helado": // statement sequence
                    break;
                
                case "Galleta": // statement sequence
                    break;

                case "Combo Pizza Personal": // statement sequence
                    break;
                
                case "Combo Pizza Pequeña": // statement sequence
                    break;

                case "Combo Pizza Mediana": // statement sequence
                    break;

                case "Combo Pizza Grande": // statement sequence
                    break;

                case "Combo Pizza Extra Grande": // statement sequence
                    break;
                    
                default:    // default statement sequence
                    break;

            }
        }
    }
}
