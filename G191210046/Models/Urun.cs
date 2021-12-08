using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace G191210046.Models
{
    public class Urun
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ürün Adı")]
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public string Aciklama { get; set; }


    }
}
