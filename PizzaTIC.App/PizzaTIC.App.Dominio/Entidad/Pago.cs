using System.ComponentModel.DataAnnotations;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Pago</c>
     /// Modela una Pago en general en el sistema 
     /// </summary>   
    public class Pago
    {
        // Identificador único de cada Pago
        public int Id { get; set; }
        [MaxLength(30)]
        public DateTime? FechaDePago { get; set; }
        public decimal? PagoTotal { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Factura { get; set; }
        //Relacion de associacion Pago-FormaDePago
        public FormaDePago? formaDePago { set; get; } 
    }
}