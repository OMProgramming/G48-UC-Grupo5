using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaTIC.App.Persistencia;
using PizzaTIC.App.Dominio;

namespace PizzaTIC.App.Presentacion
{
    public class PizzaCreateModel : PageModel
    {
        //Interface, repository and varaibles for Pizza
        private readonly IRepositorioPizza? _repositorioPizza;
       
        [BindProperty]
        public Pizza? pizza {get; set;}

        private readonly IRepositorioComidaTamano? _repositorioComidaTamano;
        [BindProperty]
        public ComidaTamano? comidaTamano {get; set;}
        private readonly IRepositorioCombo? _repositorioCombo;
        [BindProperty]
        public Combo? combo {get; set;}
        public PizzaCreateModel (IRepositorioPizza repositorioPizza, IRepositorioComidaTamano repositorioComidaTamano, IRepositorioCombo repositorioCombo)
        {
            _repositorioPizza=repositorioPizza;
            _repositorioComidaTamano=repositorioComidaTamano;
            _repositorioCombo=repositorioCombo;
        }

        public int comidaTamanoId, comboId;
        public void OnGet()
        {
            Console.WriteLine("Pizza Create: "); 
        }
    }
}
