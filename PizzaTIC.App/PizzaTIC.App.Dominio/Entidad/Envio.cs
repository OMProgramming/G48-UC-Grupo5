using System.ComponentModel.DataAnnotations;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Envio</c>
     /// Modela una Envio en general en el sistema 
     /// </summary>   
    public class Envio
    {
        // Identificador único de cada Envio
        public int Id { get; set; }
        [MaxLength(30)]
        public DateTime? FechaDeEnvio { get; set; }
        [Required]
        [MaxLength(80)]
        public string? DireccionFacturacion { get; set; }
        public bool Finalizado { get; set; }
        [Required]
        [MaxLength(30)]
        public string? CompaniaTransporte { get; set; }
        //Relacion de associacion Envio-Pago
        public Pago? pago { set; get; } 
        //Relacion de associacion Envio-Pedido
        public Envio? envio { set; get; }
    }
}