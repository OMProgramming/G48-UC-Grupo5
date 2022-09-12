using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaTIC.App.Persistencia;
using PizzaTIC.App.Dominio;

namespace PizzaTIC.App.Presentacion
{
    public class PizzaEditModel : PageModel
    {
//Interface, repository and varaibles for Pizza
        private readonly IRepositorioPizza? _repositorioPizza;
        [BindProperty]
        public Pizza? pizza {get; set;}
        public PizzaEditModel (IRepositorioPizza repositorioPizza)
        {
            _repositorioPizza=repositorioPizza;
        }
        public IActionResult OnGet(int id)
        {
            pizza = _repositorioPizza.ReadPizza(id);
            return Page();
        }
        //post handler needed
        
        public async Task<ActionResult> OnPost()
        {
            
            if (ModelState.IsValid)
            {
                pizza= _repositorioPizza.UpdatePizza(pizza);
                var name="Pizza";
                return RedirectToPage("ProdDisponible", name);
            }
            return Page();
            
        }
        
    }
}