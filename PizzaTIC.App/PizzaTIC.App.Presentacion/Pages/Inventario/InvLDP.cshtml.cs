using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaTIC.App.Persistencia;
using PizzaTIC.App.Dominio;
using Microsoft.Data.SqlClient;//to be access DB
using System.Collections.Generic;

namespace PizzaTIC.App.Presentacion
{
    public class InvLDPModel : PageModel
    {
        //Interface, repository and varaibles for InvLineaDeProducto
        private readonly IRepositorioInvLineaDeProducto? _repositorioInvLineaDeProducto;
        public InvLineaDeProducto? invLDPro {get; set;}
        public IEnumerable<InvLineaDeProducto>? listInvLDP {get; set;}

        
        //Interface, repository and varaibles for InvProducto
        private readonly IRepositorioInvProducto? _repositorioInvProducto;
        public InvProducto? invPro {get; set;}
        
        public InvLDPModel (IRepositorioInvLineaDeProducto repositorioInvLineaDeProducto)
        {
            _repositorioInvLineaDeProducto=repositorioInvLineaDeProducto;
        }
       
        
        //list for invPid in table InvLineaDeProductoInvProducto knowing invLDPid
        public List<int> invPid= new List<int>();
        public List<string> invPNombre= new List<string>();



        public string menuName;
        
        
        //entity InvProducto 

        public string submenuName;
        
        public void OnGet()
        {
            ReadAllMenu();
            menuName = ""; 

        }

         public void OnPost()
        {
            //this menuName will store value returned from name="Menu" the textbox in the <form method="post">
            menuName = Request.Form["Menu"]; 
            //read id from query with name in the menu selected
            if (menuName != "0")
            {
                invLDPro = _repositorioInvLineaDeProducto.ReadInvLineaDeProducto(menuName);
            
                //passes the menu name Id to search for products belonging to the menu name selected
                ReadInvP(invLDPro.Id);
                foreach (var item in invPid)
                {
                    invPNombre.Add(ReadInvPName(item)); 
                    Console.WriteLine(item+" "+ReadInvPName(item)); 
                }
            }
            ReadAllMenu();
            
        }

        //method to return  list of linea de productos available
        public void ReadAllMenu()
        {
            listInvLDP = _repositorioInvLineaDeProducto.ReadAllInvLineasDeProductos();
            foreach (var item in listInvLDP)
            {
                Console.WriteLine(item.Id+" "+item.INVLPCodigo+" "+item.INVLPNombre);  
            }

        }

        //method ro return a list of available products from the db given a linea of producto
        public void ReadInvP(int invLDPid)
        {
            //variable for columns' names to extract from table InvLineaDeProductoInvProducto in DB
            //int InvLineaDeProductosId;
            int InvProductosId;

            //string connection to db
            string connectionString = ("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PizzaTICData ; Integrated Security=True");
            //instantiate a connection object 
            SqlConnection con = new SqlConnection(connectionString);
            //open method to DB
            con.Open();
            //define a query SQL instruction to perform in the DB stored in string variable
            //by using the @ character and a name "invLDPid_Column"  for the "sqlParameter" allows to hide and protect sql query and prevent sql injection. 
            string sqlQuery = "SELECT TOP (1000) [InvLineaDeProductosId],[InvProductosId] FROM [PizzaTICData].[dbo].[InvLineaDeProductoInvProducto] WHERE [InvLineaDeProductosId]=@invLDPid_Column";
            //instantiate SqlCommand object
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            //define a variable to manage the defined object sqlParameter
            var invLDPid_Parameter = new SqlParameter("invLDPid_Column", System.Data.SqlDbType.Int);
            //assing a value to the var invLDPid_Parameter related with input variable for the query
            invLDPid_Parameter.Value = invLDPid;
            //add a parameter to the SqlCommand
            cmd.Parameters.Add(invLDPid_Parameter);

            //instantiate SqlDataReader to retrive data 
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {    
                //InvLineaDeProductosId = Convert.ToInt32(dr["InvLineaDeProductosId"]);
                InvProductosId = Convert.ToInt32(dr["InvProductosId"]); 
                invPid.Add(InvProductosId);   
            }
            //close connection to DB
            con.Close();
        }


        //method to extract name of sub-menu InvProducto name and code
        public string ReadInvPName(int invPid)
        {
            string invPName="";
            //string connection to db
            string connectionString = ("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PizzaTICData ; Integrated Security=True");
            //instantiate a connection object 
            SqlConnection con = new SqlConnection(connectionString);
            //open method to DB
            con.Open();
            //define a query SQL instruction to perform in the DB stored in string variable
            //by using the @ character and a name "invPId_Column"  for the "sqlParameter" allows to hide and protect sql query and prevent sql injection. 
            string sqlQuery = "SELECT TOP (1000) [Id],[INVProductoCodigo],[INVProductoNombre],[ProductoId] FROM [PizzaTICData].[dbo].[InvProductos] WHERE [Id]=@invPId_Column";

            //instantiate SqlCommand object
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            //define a variable to manage the defined object sqlParameter
            var invPid_Parameter = new SqlParameter("invPId_Column", System.Data.SqlDbType.Int);
            //assing a value to the var invPid_Parameter related with input variable for the query
            invPid_Parameter.Value = invPid;
            //add a parameter to the SqlCommand
            cmd.Parameters.Add(invPid_Parameter);

            //instantate SqlDataReader to retrive data 
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {    
                invPName = dr["INVProductoNombre"].ToString();
            }
            //close connection to DB
            con.Close();
            return invPName;
        }
    }
} 
