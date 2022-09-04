using System.ComponentModel.DataAnnotations;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Administrador</c>
     /// Modela una Adminitrador en general en el sistema 
     /// </summary>   
    public class Administrador
    {
        // Identificador único de cada Administrador
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string? UserName { get; set; }
        [Required]
        [MaxLength(20)]
        public string? Password { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Nombres { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Apellidos { set; get; }
        [Required]
        [MaxLength(30)]
        public string? Cargo { set; get; }
        [Required]
        [MaxLength(30)]
        public string? NivelDeAcceso { set; get; }
    }
}