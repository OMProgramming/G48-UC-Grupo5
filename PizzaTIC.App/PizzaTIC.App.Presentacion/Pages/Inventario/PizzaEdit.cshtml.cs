using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using PizzaTIC.App.Persistencia;
using PizzaTIC.App.Dominio;
using Microsoft.Data.SqlClient;//to be access DB

namespace PizzaTIC.App.Presentacion
{
    public class PizzaEditModel : PageModel
    {
    //Interface, repository and varaibles for Pizza
        private readonly IRepositorioPizza? _repositorioPizza;
       
        [BindProperty]
        public Pizza? pizza {get; set;}

        private readonly IRepositorioIngrediente? _repositorioIngrediente;
       
        [BindProperty]
        public Ingrediente? ingrediente {get; set;}
        public IEnumerable<Ingrediente> listIngredientes {get; set;}

        private readonly IRepositorioComidaTamano? _repositorioComidaTamano;
        [BindProperty]
        public ComidaTamano? comidaTamano {get; set;}
        private readonly IRepositorioCombo? _repositorioCombo;
        [BindProperty]
        public Combo? combo {get; set;}
        public PizzaEditModel (IRepositorioPizza repositorioPizza, IRepositorioComidaTamano repositorioComidaTamano, IRepositorioCombo repositorioCombo, IRepositorioIngrediente repositorioIngrediente)
        {
            _repositorioPizza=repositorioPizza;
            _repositorioIngrediente=repositorioIngrediente;
            _repositorioComidaTamano=repositorioComidaTamano;
            _repositorioCombo=repositorioCombo;
        }
        public string selectedIngrediente="";
        public int comidaTamanoId, comboId;
        public List<int> listIngredientesId = new List<int>();
        public List<Ingrediente> listIngredientesPizza = new List<Ingrediente>();
        public Ingrediente newIngrediente = new Ingrediente();
        public Ingrediente newIngredienteToAdd = new Ingrediente();
        public List<Ingrediente> ingredientesNotInPizza = new List<Ingrediente>();
        public void OnGet(int id)
        {
            ReadcomidaTamanoId_ComboId (id);
            pizza = _repositorioPizza.ReadPizza(id);
            LoadMethodsOnGet(id);
            
            //return Page();
        }


        public void OnPost()
        {
            //this menuName will store value returned from name="Menu" the textbox in the <form method="post">
            selectedIngrediente = Request.Form["newIngrediente"]; 
            Console.WriteLine("OnPost New Ingrediente: "+ selectedIngrediente);
            newIngredienteToAdd = _repositorioIngrediente.ReadIngredienteByName(selectedIngrediente);
            Console.WriteLine("OnPost New Ingrediente Id to Add: "+ newIngredienteToAdd.Id);

            LoadMethodsOnGet(pizza.Id);

        }

        //post handler needed
        
        public async Task<ActionResult> OnPostEditPizza()
        { 
            pizza= _repositorioPizza.UpdatePizza(pizza);
            Console.WriteLine("OnPost: "+ comidaTamano.Id);
            return RedirectToPage("ProdDisponible", new { name  = "Pizza" });
        }

        
        public async Task<ActionResult> OnPostAddIngrediente(int id)
        { 
            Console.WriteLine("OnPost Add Ingrediente: "+ id);
            AddIngredienteToPizza(id, pizza.Id);
            ReadcomidaTamanoId_ComboId (pizza.Id);
            //updates number of ingredientes in comidaTamano
            UpdateNumberOfIngredientes();
            return RedirectToPage("PizzaEdit", new { id  = pizza.Id });
        }

        public async Task<ActionResult> OnPostEditIngrediente(int id)
        { 
            Console.WriteLine("OnPost Edit Ingrediente Id: "+ id);
            Console.WriteLine("OnPost Edit Ingrediente Nombre: "+ ingrediente.NombreIngrediente);
            //ingrediente= _repositorioIngrediente.UpdateIngrediente(ingrediente);
            ReadcomidaTamanoId_ComboId (pizza.Id);
            return RedirectToPage("PizzaEdit", new { id  = pizza.Id });
        }

        public async Task<IActionResult> OnPostEditTamano(int id)
        {
            Console.WriteLine("OnPost Comida Tamaño: "+ id);
            comidaTamano = _repositorioComidaTamano.UpdateComidaTamano(comidaTamano);
            return RedirectToPage("PizzaEdit", new { id  = pizza.Id });
        }
        
        public async Task<IActionResult> OnPostCreateTamano()
        {
            Console.WriteLine("OnPost NUEVO Tamaño: ");//comidaTamano.Id);
            _repositorioComidaTamano.CreateComidaTamano(comidaTamano);
            return RedirectToPage("PizzaEdit", new { id  = pizza.Id });
        }

        public async Task<IActionResult> OnPostEditCombo(int id)
        {
            Console.WriteLine("OnPost Comida Combo: "+ id);//comidaTamano.Id);
            combo = _repositorioCombo.UpdateCombo(combo);
            return RedirectToPage("PizzaEdit", new { id  = pizza.Id });
        }

        public async Task<IActionResult> OnPostCreateCombo()
        {
            Console.WriteLine("OnPost NUEVO Combo: ");//comidaTamano.Id);
            _repositorioCombo.CreateCombo(combo);
            UpdatecomidaTamanoId_ComboId (pizza.Id, comidaTamano.Id, combo.Id);
            
            return RedirectToPage("PizzaEdit", new { id  = pizza.Id });
        }

        public void LoadMethodsOnGet(int pizzaId)
        {
            //reads al the available ingredients in the DB
            listIngredientes=_repositorioIngrediente.ReadAllIngredientes();
            //reads id ingredientes already asigned to the pizza
            ReadIngredientesId_Pizza (pizzaId);
            //newIngrediente=newIngredienteToAdd;
            Console.WriteLine("Ingredientes : "+ listIngredientesId.Count()); 
            foreach(var item in listIngredientesId)
            {
                Console.WriteLine("IngredienteId : "+ item);
                ingrediente = _repositorioIngrediente.ReadIngrediente(item);
                listIngredientesPizza.Add(ingrediente);
                
            }
            //remove ingredientes already assigned to pizza from list of ingredientes to add
            foreach (var ingred_B in listIngredientes)
            {
                ingredientesNotInPizza.Add(ingred_B);//converts IEnumerable listIngredientes to List
            }
            foreach (var ingred_A in listIngredientesPizza)
            {
                foreach (var ingred_B in listIngredientes)
                {
                    if (ingred_A==ingred_B)
                    {
                        ingredientesNotInPizza.Remove(ingred_B);//extracts existing ingrediente
                    }
                }
            }

            ReadcomidaTamanoId_ComboId (pizzaId);
            if (comidaTamanoId>0)
            {
                comidaTamano = _repositorioComidaTamano.ReadComidaTamano(comidaTamanoId);
                Console.WriteLine("Pizza TamañoId: "+ comidaTamano.Id); 
            }
            
            if (comboId>0)
            {
                combo = _repositorioCombo.ReadCombo(comboId);
                Console.WriteLine("Pizza ComboId: "+ combo.Id); 
            }

        }
        //method to extract all columns from table Pizzas 
        public void ReadcomidaTamanoId_ComboId (int invPizzaId)
        {
            //string connection to db
            string connectionString = ("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PizzaTICData ; Integrated Security=True");
            //instantiate a connection object 
            SqlConnection con = new SqlConnection(connectionString);
            //open method to DB
            con.Open();
            //define a query SQL instruction to perform in the DB stored in string variable
            //by using the @ character and a name "invPizzaId_Column"  for the "sqlParameter" allows to hide and protect sql query and prevent sql injection. 
            string sqlQuery = "SELECT TOP (1000) [Id],[PizzaNombre],[PizzaDescripcion],[comidaTamanoId],[Combo],[ComboId] FROM [PizzaTICData].[dbo].[Pizzas] WHERE [Id]=@invPizzaId_Column";
            
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
            
            if (dr.Read())
            {   
                if ((dr["comidaTamanoId"].ToString())!="") 
                {
                    comidaTamanoId = Convert.ToInt32(dr["comidaTamanoId"]);
                }
                else
                {
                    comidaTamanoId = 0;//doesn't exist a comidaTamanoId in DB
                }
                if((dr["ComboId"].ToString())!="")
                {
                    comboId = Convert.ToInt32(dr["ComboId"]);
                }
                else
                {
                    comboId =0;//doesn't exist a ComboId in DB
                }
            }
            //close connection to DB
            con.Close();
            return;
        }

        //updates number of ingredienetes in pizza selected (db table comidaTamano) 
        public void UpdateNumberOfIngredientes()
        {
            comidaTamano.NumeroIngredientes=comidaTamano.NumeroIngredientes+1;
            Console.WriteLine("Update ComidaTamano Numero Ingredientes to: "+ comidaTamano.NumeroIngredientes); 
            comidaTamano = _repositorioComidaTamano.UpdateComidaTamano(comidaTamano);
            comidaTamano = _repositorioComidaTamano.ReadComidaTamano(comidaTamanoId);

        }
        public void UpdatecomidaTamanoId_ComboId (int invPizzaId, int comidaTamanoId, int comboId)
        {
            //string connection to db
            string connectionString = ("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PizzaTICData ; Integrated Security=True");
            //instantiate a connection object 
            SqlConnection con = new SqlConnection(connectionString);
            //open method to DB
            con.Open();
            //define a query SQL instruction to perform in the DB stored in string variable
            //by using the @ character and a name "invPizzaId_Column"  for the "sqlParameter" allows to hide and protect sql query and prevent sql injection. 
            string sqlQuery = "UPDATE [PizzaTICData].[dbo].[Pizzas] SET [comidaTamanoId]="+ comidaTamanoId + ", [ComboId]="+ comboId + " WHERE [Id] = @invPizzaId_Column";
            Console.WriteLine("sqlQuery: "+ sqlQuery);
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
        
            //close connection to DB
            con.Close();
            return;
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
        
        //adds an ingrediente to the list of assigned ingredientes in a selected pizza
        public void AddIngredienteToPizza(int ingredienteId, int pizzaId)
        {
            //string connection to db
            string connectionString = ("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PizzaTICData ; Integrated Security=True");
            //instantiate a connection object 
            SqlConnection con = new SqlConnection(connectionString);
            //open method to DB
            con.Open();
            //define a query SQL instruction to perform in the DB stored in string variable
            //by using the @ character and a name "invPizzaId_Column"  for the "sqlParameter" allows to hide and protect sql query and prevent sql injection. 
            string sqlQuery = "INSERT INTO [PizzaTICData].[dbo].[IngredientePizza] ([IngredientesId], [PizzasId]) VALUES (@col_ingredienteId,@col_pizzaId)";
            
            //instantiate SqlCommand object
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            //define a variable to manage the defined object sqlParameter
            var ingredienteId_Parameter = new SqlParameter("col_ingredienteId", System.Data.SqlDbType.Int);
            //assing a value to the var invPid_Parameter related with input variable for the query
            ingredienteId_Parameter.Value = ingredienteId;
            //add a parameter to the SqlCommand
            cmd.Parameters.Add(ingredienteId_Parameter);
            //define a variable to manage the defined object sqlParameter
            var pizzaId_Parameter = new SqlParameter("col_pizzaId", System.Data.SqlDbType.Int);
            //assing a value to the var invPid_Parameter related with input variable for the query
            pizzaId_Parameter.Value = pizzaId;
            //add a parameter to the SqlCommand
            cmd.Parameters.Add(pizzaId_Parameter);
            //instantate SqlDataReader to retrive data 
            SqlDataReader dr = cmd.ExecuteReader();
  
            //close connection to DB
            con.Close();
            return;
        }
    }
}