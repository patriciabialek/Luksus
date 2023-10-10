using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Luksus.Models
{
    public class Perfume
    {
        public int Id { get; set; }

        /*[StringLength(60, MinimumLength = 3)]
        [Required]*/
        public string Name { get; set; }

        /*[StringLength(60, MinimumLength = 3)]
        [Required]*/
        public string Brand { get; set; }

        /*[Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]*/
        public decimal Price { get; set; }

        /*[StringLength(60, MinimumLength = 3)]
         * [Display(Name = "Fragrance Family")]
        [Required]*/
        public string FragranceFamily { get; set; }

        /*[Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]*/
        public int Volume { get; set; }

        /*[StringLength(60, MinimumLength = 3)]
        [Required]*/
        public string Concentration { get; set; }

        /*[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]*/
        public string Rating { get; set; }
    }
}
