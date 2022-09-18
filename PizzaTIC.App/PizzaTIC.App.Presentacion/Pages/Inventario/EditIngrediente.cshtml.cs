using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using PizzaTIC.App.Persistencia;
using PizzaTIC.App.Dominio;
using Microsoft.Data.SqlClient;//to be access DB

namespace PizzaTIC.App.Presentacion
{
    public class EditIngredienteModel : PageModel
    {
        private readonly IRepositorioPizza? _repositorioPizza;
       
        [BindProperty]
        public Pizza? pizza {get; set;}

        private readonly IRepositorioIngrediente? _repositorioIngrediente;
       
        [BindProperty]
        public Ingrediente? ingrediente {get; set;}
        public IEnumerable<Ingrediente> listIngredientes {get; set;}

        public EditIngredienteModel (IRepositorioPizza repositorioPizza, IRepositorioIngrediente repositorioIngrediente)
        {
            _repositorioPizza=repositorioPizza;
            _repositorioIngrediente=repositorioIngrediente;
        }
        public int count=0;
        public List<int> listIngredientesId = new List<int>();
        public List<Ingrediente> listIngre_Pizza = new List<Ingrediente>();
        public void OnGet(int id)
        {
            listIngredientes = _repositorioIngrediente.ReadAllIngredientes();
 
            Console.WriteLine("OnGet Edit Ingrediente for Pizza Id: "+ id);
            pizza = _repositorioPizza.ReadPizza(id);
            //stores ingredientes already in pizza
            ReadIngredientesId_Pizza (pizza.Id);
            foreach (var ingId in listIngredientesId)
            {
                ingrediente = _repositorioIngrediente.ReadIngrediente(ingId);
                listIngre_Pizza.Add(ingrediente);
            }
            

        }
        public async Task<IActionResult> OnPostSelectedIngrediente(int ingredienteId)
        {
            Console.WriteLine("OnPost Ingrediente Selected: ");
            ingrediente = _repositorioIngrediente.ReadIngrediente(ingredienteId);
            count = count + 1;
            return RedirectToPage("EditIngrediente", new { id  = pizza.Id });
        }

        public async Task<IActionResult> OnPostEditIngrediente(int intgId)
        {
            Console.WriteLine("OnPost Ingrediente to Edit: " + intgId);
            //ingrediente = _repositorioIngrediente.UpdateIngrediente(ingrediente);
            return RedirectToPage("EditIngrediente", new { id  = pizza.Id });
        }


        //Reads id(s) of Ingredientes for pizzaId known in table [IngredientePizza] in db
        public void ReadIngredientesId_Pizza (int invPizzaId)
        {
            //string connection to db
            string connectionString = ("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PizzaTICData ; Integrated Security=True");
            //instantiate a connection object 
            SqlConnection con = new SqlConnection(connectionString);
            //open method to DB
            con.Open();
            //define a query SQL instruction to perform in the DB stored in string variable
            //by using the @ character and a name "invPizzaId_Column"  for the "sqlParameter" allows to hide and protect sql query and prevent sql injection. 
            string sqlQuery = "SELECT TOP (1000) [IngredientesId],[PizzasId] FROM [PizzaTICData].[dbo].[IngredientePizza] WHERE [PizzasId]=@invPizzaId_Column";
            
            //instantiate SqlCommand object
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            //define a variable to manage the defined object sqlParameter
            var invPizzaId_Parameter = new SqlParameter("invPizzaId_Column", System.Data.SqlDbType.Int);
            //assing a value to the var invPid_Parameter related with input variable for the query
            invPizzaId_Parameter.Value = invPizzaId;
            //add a parameter to the SqlCommand
            cmd.Parameters.Add(invPizzaId_Parameter);

            //instantate SqlDataReader to retrive data 
            SqlDataReader dr = cmd.ExecuteReader();
            int ingredienteId=0;
            while (dr.Read())
            {   
                if ((dr["PizzasId"].ToString())!="") 
                {
                    ingredienteId = Convert.ToInt32(dr["IngredientesId"]);
                    listIngredientesId.Add(ingredienteId);
                }

            }
            //close connection to DB
            con.Close();
            return;
        }
    }
    
}
