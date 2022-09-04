using System.ComponentModel.DataAnnotations;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Especificacion</c>
     /// Modela una Especificacion en general en el sistema 
     /// </summary>   
    public class Especificacion
    {
        // Identificador único de cada Especificacion
        public int Id { get; set; }  
        public decimal PrecioUnitario { get; set; }  
        public int Peso { get; set; }  
        public int Ancho { get; set; }  
        public int Largo { get; set; }  
        public int Alto { get; set; }  
        [Required]
        [MaxLength(40)]     
        public string? TipoEmpaque { set; get; }
    }
}