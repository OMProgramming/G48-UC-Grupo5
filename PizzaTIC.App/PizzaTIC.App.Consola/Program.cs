// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using PizzaTIC.App.Dominio;
using PizzaTIC.App.Persistencia;
using System.Collections.Generic;

namespace PizzaTIC.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContext());
        private static IRepositorioFormaDePago _repoFormaDePago = new RepositorioFormaDePago(new Persistencia.AppContext());
        private static IRepositorioInvLineaDeProducto _repoInvLineaDeProducto = new RepositorioInvLineaDeProducto(new Persistencia.AppContext());
        private static IRepositorioInvProducto _repoInvProducto = new RepositorioInvProducto(new Persistencia.AppContext());
        private static IRepositorioPizza _repoPizza = new RepositorioPizza(new Persistencia.AppContext());
        private static IRepositorioIngrediente _repoIngrediente = new RepositorioIngrediente(new Persistencia.AppContext());
        private static IRepositorioComidaTamano _repoComidaTamano = new RepositorioComidaTamano(new Persistencia.AppContext());
        static void Main(string[] arg)
        {
            Console.WriteLine("Hello, World Entity Framework!");
                //CreateCliente();
                //var ExistCliente = new Cliente();
                //ExistCliente = ReadCliente(1);//stores ExistCliente with  Cliente clienteId=1
                //ReadAllClientes();
                //var ExistformaDePago = new FormaDePago();
                //ExistformaDePago = ReadFormaDePago(1);
                /*
                ExistCliente.formaDePago=ExistformaDePago;//set formaDePagoId=1 in db Table Cliente 
                ExistCliente.Ciudad="Taparcal";
                UpdateCliente(ExistCliente);
                ExistCliente = ReadCliente(1);
                */
                //CreateFormaDePago();
                
                //var ExistformaDePago = new FormaDePago();
                //ExistformaDePago= ReadFormaDePago(1);
                //ExistformaDePago.TipoDeTarjeta="Credito";
                //ExistformaDePago.CodigoDeSeguridad="123";
                //ExistformaDePago.FechaDeVencimiento= new DateTime(2024,12,02);
                
                //ReadAllFormasDePagos();
                //UpdateFormaDePago(ExistformaDePago);
                //ExistformaDePago = ReadFormaDePago(1);
                //DeleteFormaDePago(2);//deletes record id=2 in db
                
                //CreateInvLineaDeProducto();
                /*
                var exitInvLineaDeProducto = new InvLineaDeProducto();
                exitInvLineaDeProducto= ReadInvLineaDeProducto(12);
                exitInvLineaDeProducto.INVLPNombre="Combinados";
                //exitInvLineaDeProducto.INVLPCodigo="CBS";
                UpdateInvLineaDeProducto(exitInvLineaDeProducto);
                */
            /*
            var exitInvLineaDeProducto = new InvLineaDeProducto();
            exitInvLineaDeProducto= ReadInvLineaDeProducto(12);
            List<InvProducto> invProducto = new List<InvProducto>();
            invProducto.Add(ReadInvProducto(12));//pizza
            invProducto.Add(ReadInvProducto(13));//hamburgesa
            invProducto.Add(ReadInvProducto(14));//perro
            invProducto.Add(ReadInvProducto(15));
            invProducto.Add(ReadInvProducto(16));
            //invProducto.Add(ReadInvProducto(4));//pastel
            Console.WriteLine(invProducto.ElementAt(0).INVProductoNombre);
            Console.WriteLine(invProducto.ElementAt(1).INVProductoNombre);
            Console.WriteLine(invProducto.ElementAt(2).INVProductoNombre);
            //Console.WriteLine(invProducto.ElementAt(3).INVProductoNombre);
            exitInvLineaDeProducto.InvProductos=invProducto;
            UpdateInvLineaDeProducto(exitInvLineaDeProducto);
            */
            //DeleteInvLineaDeProducto(11);
            /*
            //CreateInvProducto();
            var extInvProducto = new InvProducto();
            extInvProducto= ReadInvProducto(1);
            List<Pizza> listOfPizzas = new List<Pizza>();
            for(int i=1; i<27; i++)
            {
                if (i!=16){
                listOfPizzas.Add(ReadPizza(i));
                
                }
            }
            for(int i=0; i<25; i++)
            {
                Console.WriteLine(listOfPizzas.ElementAt(i).Id+" "+listOfPizzas.ElementAt(i).PizzaNombre);
            }
            extInvProducto.Pizzas=listOfPizzas;
            UpdateInvProducto(extInvProducto);
            */

            /*
            var extInvLineaDeProducto = new InvLineaDeProducto();
            extInvLineaDeProducto=ReadInvLineaDeProducto(8);
            //var objCollection = (ICollection<object>) new List<object>
            var extInvProducto = (ICollection<InvProducto>) new List<InvProducto>();
            extInvProducto=extInvLineaDeProducto.InvProductos!;
            Console.WriteLine(extInvProducto.FirstOrDefault<InvProducto>);
            //var extPizza = (ICollection<Pizza>) new List<Pizza>();
            //extPizza = extInvProducto.Count;
            //Console.WriteLine(extPizza);
            //UpdateInvProducto(extInvProducto);
            */
            //DeleteInvLineaDeProducto(5);
            
            //CreatePizza();
            /*
            var extPizza = new Pizza();
            extPizza=ReadPizza(26);//****************
            List<Ingrediente> ingrePizza = new List<Ingrediente>();
            ingrePizza.Add(ReadIngrediente(1));//queso
            ingrePizza.Add(ReadIngrediente(11));//Pollo
            ingrePizza.Add(ReadIngrediente(12));//Res
            ingrePizza.Add(ReadIngrediente(14));//Cerdo
            ingrePizza.Add(ReadIngrediente(15));//aceitunas
            ingrePizza.Add(ReadIngrediente(17));//aceitunas
            Console.WriteLine(ingrePizza.ElementAt(0).NombreIngrediente);
            Console.WriteLine(ingrePizza.ElementAt(1).NombreIngrediente);
            Console.WriteLine(ingrePizza.ElementAt(2).NombreIngrediente);
            Console.WriteLine(ingrePizza.ElementAt(3).NombreIngrediente);
            Console.WriteLine(ingrePizza.ElementAt(4).NombreIngrediente);
            Console.WriteLine(ingrePizza.ElementAt(5).NombreIngrediente);
            extPizza.Ingredientes=ingrePizza;
            extPizza.comidaTamano=ReadComidaTamano(25);// ************ toppings
            UpdatePizza(extPizza);
            */
            
            //var extPizza = new Pizza();
            //extPizza=ReadPizza(1);
            //
            //extComidaTamano=extPizza.comidaTamano;
            //Console.WriteLine(extComidaTamano);
            //Console.WriteLine(extPizza.Ingredientes.ElementAt(0).NombreIngrediente);
            //Console.WriteLine(ingrePizza.ElementAt(0).NombreIngrediente);
            //CreateIngrediente();
            //var exitIngrediente = new Ingrediente();
            //exitIngrediente=ReadIngrediente(16);
            //exitIngrediente.NombreIngrediente="Rodajas de Tomate";
            //exitIngrediente.Calorias=25;
            //UpdateIngrediente(exitIngrediente);
            /*
            exitIngrediente.NombreIngrediente="Cerdo";
            UpdateIngrediente(exitIngrediente);
            ReadIngrediente(7);
            */
            
            /*
            extPizza=ReadPizza(8);
            Console.WriteLine("ANTES "+extPizza.Id);
            extPizza.Id=8;
            extPizza.INVProductoCodigo="PIZ";
            Console.WriteLine("DESPUES "+extPizza.Id);
            

            
            Console.WriteLine(extPizza.Ingredientes.ElementAt(0).NombreIngrediente);
            Console.WriteLine(extPizza.Ingredientes.ElementAt(1).NombreIngrediente);

            var exitComidaTamano = new ComidaTamano();
            exitComidaTamano=ReadComidaTamano(2);
            extPizza.comidaTamano=exitComidaTamano;
            UpdatePizza(extPizza);
            //ReadAllPizzas();
            */
            
            //Console.WriteLine(extPizza.Ingredientes.ElementAt(0).NombreIngrediente);
            //Console.WriteLine(extPizza.Ingredientes.ElementAt(1).NombreIngrediente);
            //Console.WriteLine(extPizza.Ingredientes.Count);//number of ingredientes
            //Console.WriteLine(extPizza.comidaTamano.NumeroIngredientes);
           


            //CreateComidaTamano();

        }
        /*method to Create a Cliente*/
        private static void CreateCliente()
        {
            var cliente = new Cliente
            {
                UserName = "ClauGomez",
                Password = "comidafresca22",
                Nombres = "Claudia Marcela ",
                Apellidos = "Gomez Lopez", 
                Direccion = "Carrera 5 No 3-9",
                Ciudad = "Pereira",
                Departamento = "Risaralda",
                Pais = "Colombia",
                Telefono = "4001695",
                Email = "claudia_lopez@gmail.com"
            };
            _repoCliente.CreateCliente(cliente);
        }
        /*Method Read Cliente*/
        private static Cliente ReadCliente (int idCliente)
        {
            var cliente = _repoCliente.ReadCliente(idCliente);
            Console.WriteLine(cliente.Nombres +" "+ cliente.Apellidos+" "+cliente.Ciudad+" "+cliente.formaDePago);
            return cliente;
        }
        private static void ReadAllClientes()
        {
            var cliente = _repoCliente.ReadAllClientes();
            Console.WriteLine(cliente);
        }
        /*Method Update Cliente*/
        private static void UpdateCliente(Cliente cliente)
        {
            _repoCliente.UpdateCliente(cliente);
        }
        /*Method Delete Cliente*/
        private static void DeleteCliente (int idCliente)
        {
            _repoCliente.DeleteCliente(idCliente);
        }

         /*method to Create a FormaDePago*/
        private static void CreateFormaDePago()
        {
            var formaDePago = new FormaDePago
            {
                TipoDeTarjeta = "Debito",
                NombreEnTarjeta = "Marcela Lopez",
                NumeroEnTarjeta = 867904578659,
                FechaDeVencimiento = new DateTime(2026,12,01), 
                CodigoDeSeguridad = "567"
            };
            _repoFormaDePago.CreateFormaDePago(formaDePago);
        }
        /*Method Read FormaDePago*/
        private static FormaDePago ReadFormaDePago (int idFormaDePago)
        {
            var formaDePago = _repoFormaDePago.ReadFormaDePago(idFormaDePago);
            Console.WriteLine(formaDePago.NombreEnTarjeta +" "+ formaDePago.TipoDeTarjeta);
            return formaDePago;
        }
        /*Method Read AllFormasDePagos*/
        private static void ReadAllFormasDePagos()
        {
            var formaDePago = _repoFormaDePago.ReadAllFormasDePagos();
            Console.WriteLine(formaDePago);
        }
        /*Method Update FormaDePago*/
        private static void UpdateFormaDePago(FormaDePago formaDePago)
        {
            _repoFormaDePago.UpdateFormaDePago(formaDePago);
        }
        /*Method Delete FormaDePago*/
        private static void DeleteFormaDePago (int idFormaDePago)
        {
            _repoFormaDePago.DeleteFormaDePago(idFormaDePago);
        }


         /*method to Create a InvLineaDeProducto*/
        private static void CreateInvLineaDeProducto()
        {
            var invLineaDeProducto = new InvLineaDeProducto
            {
                INVLPCodigo = "POS",
                INVLPNombre = "Postres",
            };
            _repoInvLineaDeProducto.CreateInvLineaDeProducto(invLineaDeProducto);
        }
        /*Method Read InvLineaDeProducto*/
        private static InvLineaDeProducto ReadInvLineaDeProducto (int idInvLineaDeProducto)
        {
            var invLineaDeProducto = _repoInvLineaDeProducto.ReadInvLineaDeProducto(idInvLineaDeProducto);
            Console.WriteLine(invLineaDeProducto.INVLPCodigo +" "+ invLineaDeProducto.INVLPNombre);
            return invLineaDeProducto;
        }
        /*Method Read InvLineasDeProductos*/
        private static void ReadAllInvLineasDeProductos()
        {
            var invLineaDeProducto = _repoInvLineaDeProducto.ReadAllInvLineasDeProductos();
            Console.WriteLine(invLineaDeProducto);
        }
        /*Method Update FormaDePago*/
        private static void UpdateInvLineaDeProducto(InvLineaDeProducto invLineaDeProducto)
        {
            _repoInvLineaDeProducto.UpdateInvLineaDeProducto(invLineaDeProducto);
        }
        /*Method Delete InvLineaDeProducto*/
        private static void DeleteInvLineaDeProducto (int idInvLineaDeProducto)
        {
            _repoInvLineaDeProducto.DeleteInvLineaDeProducto(idInvLineaDeProducto);
        }


         /*method to Create a InvProducto*/
        private static void CreateInvProducto()
        {
            var invProducto = new InvProducto
            {
                //InvLineaDeProductos = ReadInvLineaDeProducto(8),//es LP comida
                INVProductoCodigo = "CPI",
                INVProductoNombre = "Combo Pizza Extra Grande",

            };
            _repoInvProducto.CreateInvProducto(invProducto);
        }
        /*Method Read InvProducto*/
        private static InvProducto ReadInvProducto (int idInvProducto)
        {
            var invProducto = _repoInvProducto.ReadInvProducto(idInvProducto);
            Console.WriteLine(invProducto.INVProductoCodigo +" "+ invProducto.INVProductoNombre);
            return invProducto;
        }
        /*Method Read InvProducto*/
        private static void ReadAllInvProductos()
        {
            var invProducto = _repoInvProducto.ReadAllInvProductos();
            Console.WriteLine(invProducto);
        }
        /*Method Update InvProducto*/
        private static void UpdateInvProducto(InvProducto invProducto)
        {
            _repoInvProducto.UpdateInvProducto(invProducto);
        }
        /*Method Delete InvProducto*/
        private static void DeleteInvProducto (int idInvProducto)
        {
            _repoInvProducto.DeleteInvProducto(idInvProducto);
        }



        /*method to Create a ComidaTamano*/
        private static void CreateComidaTamano()
        {
            var comidaTamano = new ComidaTamano
            {
                ComidaTamanoNombre = "Mediana",
                NumeroIngredientes = 1,
                PrecioUnitario = 27000,
                Peso = 350,
                Ancho = 28,
                Largo = 28,
                Alto = 2,
                TipoEmpaque = "caja de cartón"
            };
            _repoComidaTamano.CreateComidaTamano(comidaTamano);
        }
        /*Method Read ComidaTamano*/
        private static ComidaTamano ReadComidaTamano (int idComidaTamano)
        {
            var comidaTamano = _repoComidaTamano.ReadComidaTamano(idComidaTamano);
            Console.WriteLine(comidaTamano.ComidaTamanoNombre);
            return comidaTamano;
        }
        /*Method Read AllComidaTamanos*/
        private static void ReadAllComidaTamanos()
        {
            var comidaTamano = _repoComidaTamano.ReadAllComidasTamanos();
            Console.WriteLine(comidaTamano);
        }
        /*Method Update ComidaTamano*/
        private static void UpdateComidaTamano(ComidaTamano comidaTamano)
        {
            _repoComidaTamano.UpdateComidaTamano(comidaTamano);
        }
        /*Method Delete ComidaTamano*/
        private static void DeleteComidaTamano (int idComidaTamano)
        {
            _repoComidaTamano.DeleteComidaTamano(idComidaTamano);
        }
    



        /*method to Create a Pizza*/
        private static void CreatePizza()
        {
            var pizza = new Pizza
            {
                //InvProductos
                PizzaNombre = "Vegetariana",
                PizzaDescripcion = "Cinco vegetales frescos combinados con queso bajo en grasa",
                //Ingredientes
                //comidaTamano = ReadComidaTamano(2),
                Combo="Combo Pizza Extra Grande"//Personal,Pequeña,Mediana,Grande, Extra Grande
            };
            _repoPizza.CreatePizza(pizza);
        }
        /*Method Read Pizza*/
        private static Pizza ReadPizza (int idPizza)
        {
            var pizza = _repoPizza.ReadPizza(idPizza);
            Console.WriteLine(
                pizza.Id +" \n"+
                pizza.PizzaNombre +" \n"+ 
                pizza.PizzaDescripcion+" \n"+
                pizza.Ingredientes+" \n"+
                pizza.comidaTamano+" \n"+
                pizza.Combo
            );
            return pizza;
        }
        /*Method Read AllPizzas*/
        private static void ReadAllPizzas()
        {
            var pizza = _repoPizza.ReadAllPizzas();
            Console.WriteLine(pizza);
        }
        /*Method Update Pizza*/
        private static void UpdatePizza(Pizza pizza)
        {
            _repoPizza.UpdatePizza(pizza);
        }
        /*Method Delete Pizza*/
        private static void DeletePizza (int idPizza)
        {
            _repoPizza.DeletePizza(idPizza);
        }



        /*method to Create a Ingrediente*/
        private static void CreateIngrediente()
        {
            var ingrediente = new Ingrediente
            {
                NombreIngrediente = "Oregano",
                Calorias=20,
                TipoIngrediente="Vegetal"

            };
            _repoIngrediente.CreateIngrediente(ingrediente);
        }
        /*Method Read Ingrediente*/
        private static Ingrediente ReadIngrediente (int idIngrediente)
        {
            var ingrediente = _repoIngrediente.ReadIngrediente(idIngrediente);
            Console.WriteLine(ingrediente.NombreIngrediente);
            return ingrediente;
        }
        /*Method Read AllIngredientes*/
        private static void ReadAllIngredientes()
        {
            var ingrediente = _repoIngrediente.ReadAllIngredientes();
            Console.WriteLine(ingrediente);
        }
        /*Method Update Ingrediente*/
        private static void UpdateIngrediente(Ingrediente ingrediente)
        {
            _repoIngrediente.UpdateIngrediente(ingrediente);
        }
        /*Method Delete Ingrediente*/
        private static void DeleteIngrediente (int idIngrediente)
        {
            _repoIngrediente.DeleteIngrediente(idIngrediente);
        }
    }



        
    
}