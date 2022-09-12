using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaTIC.App.Persistencia;
using PizzaTIC.App.Dominio;

namespace PizzaTIC.App.Presentacion
{
    public class ClienteCreateModel : PageModel
    {
        //Interface, repository and varaibles for Cliente
        private readonly IRepositorioCliente? _repositorioCliente;
        [BindProperty] //this property will bind property below to OnPost Method
        public Cliente? cliente {get; set;}
        public IEnumerable<Cliente>? Clientes {get; set;}

        public ClienteCreateModel (IRepositorioCliente repositorioCliente)
        {
            _repositorioCliente=repositorioCliente;
        }
        public void OnGet()
        {
        
        }
        //A post handler to retrive it from DB is an Task<ActionResult> because we are redirect to a new page
        //handler always starts with word On. This is a Post handler
        //public async Task<ActionResult> OnPost(Cliente ClienteObj). This is the OnPost method declaration if
        //the [BindProperty] property were not especified above
        public async Task<ActionResult> OnPost()
        {
            if(ModelState.IsValid)//if ModelState is valid we wnat to add the parameter Cliente to DB
            {
                _repositorioCliente.CreateCliente(cliente);
                return RedirectToPage("Cliente");
            }
            else
            {
                return Page();
            }
        }
    }
}
