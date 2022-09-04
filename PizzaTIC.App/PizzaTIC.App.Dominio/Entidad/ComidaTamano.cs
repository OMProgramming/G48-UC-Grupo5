using System.ComponentModel.DataAnnotations;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>ComidaTamano</c>
     /// Modela una ComidaTamano en general en el sistema 
     /// </summary>   
    public class ComidaTamano
    {
        // Identificador único de cada ComidaTamano
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public String? ComidaTamanoNombre { get; set; }
        public int NumeroIngredientes { get; set; }  
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