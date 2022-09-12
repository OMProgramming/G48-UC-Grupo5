using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaTIC.App.Persistencia;
using PizzaTIC.App.Dominio;

namespace PizzaTIC.App.Presentacion
{
    public class ClienteModel : PageModel
    {
        //Interface, repository and varaibles for Cliente
        private readonly IRepositorioCliente? _repositorioCliente;
        public Cliente? cliente {get; set;}
        public IEnumerable<Cliente>? Clientes {get; set;}

        public ClienteModel (IRepositorioCliente repositorioCliente)
        {
            _repositorioCliente=repositorioCliente;
        }
        public async void OnGet()
        {
            Clientes = _repositorioCliente.ReadAllClientes();
        }
        ///delete handler is implemented here
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var clienteToDelete = _repositorioCliente.ReadCliente(id);
            if(clienteToDelete==null)
                {
                    return NotFound();
                }
            else
            {
                _repositorioCliente.DeleteCliente(clienteToDelete.Id);
                return RedirectToPage("Cliente");
            } 
        }
    }
}
