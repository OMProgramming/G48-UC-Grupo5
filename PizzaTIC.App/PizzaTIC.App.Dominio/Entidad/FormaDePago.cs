using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>FormaDePago</c>
     /// Modela una Forma de Pago de un cliente en general
     /// </summary>   
    public class FormaDePago
    {
        // Identificador único de cada FormaDePago
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string? TipoDeTarjeta { get; set; }
        [Required]
        [MaxLength(50)]
        public string? NombreEnTarjeta { get; set; }
        [Required]
        [MaxLength(16)]
        public double? NumeroEnTarjeta { get; set; }
        [Required]
        [MaxLength(30)]
        public DateTime? FechaDeVencimiento { set; get; }
        [Required]
        [MaxLength(6)]
        public string? CodigoDeSeguridad { set; get; }
    }
}