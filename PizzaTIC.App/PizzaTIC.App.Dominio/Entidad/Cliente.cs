using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Text.Json.Serialization;

namespace PizzaTIC.App.Dominio
{
     /// <summary>Class <c>Cliente</c>
     /// Modela una Cliente en general en el sistema 
     /// </summary>   
    public class Cliente
    {
        // Identificador único de cada Cliente
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
        public string? Direccion { set; get; }
        [Required]
        [MaxLength(20)]
        public string? Ciudad { set; get; }
        [Required]
        [MaxLength(20)]
        public string? Departamento { set; get; }
        [Required]
        [MaxLength(20)]
        public string? Pais { set; get; }
        [Required]
        [MaxLength(15)]
        public string? Telefono { set; get; }
        [Required]
        [MaxLength(30)]
        public string? Email { set; get; }
        //Relacion de associacion Cliente-FormaDePago
        public FormaDePago? formaDePago { set; get; }
        //Relacion de associacion de muchos clientes a muchos Pedidos
        [JsonIgnore]
        public ICollection<Pedido>? Pedidos { get; set; }
    }
}
