using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaTIC.App.Persistencia;
using PizzaTIC.App.Dominio;

namespace PizzaTIC.App.Presentacion
{
    public class ClienteEditModel : PageModel
    {
        //Interface, repository and varaibles for Cliente
        private readonly IRepositorioCliente? _repositorioCliente;
        [BindProperty]
        public Cliente? cliente {get; set;}
        public ClienteEditModel (IRepositorioCliente repositorioCliente)
        {
            _repositorioCliente=repositorioCliente;
        }
        public IActionResult OnGet(int id)
        {
            cliente = _repositorioCliente.ReadCliente(id);
            return Page();
        }
        //post handler needed
        
        public async Task<ActionResult> OnPost()
        {
            
            if (ModelState.IsValid)
            {
                cliente= _repositorioCliente.UpdateCliente(cliente);
                return RedirectToPage("Cliente");
            }
            return Page();
            
        }
        
    }
}
