using System;
using System.ComponentModel.DataAnnotations;

namespace Recuparacion_Cristhian.Models
{
    public class Product
    {
        [Key]
        [Range(1,99999)]
        public int ProductId { get; set; }
        [Required]
        [StringLength(30,MinimumLength =3)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime MyProperty { get; set; }
    }
}