using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace G191210046.Models
{
    public class Siparis
    {
        public int Id { get; set; }
        public string MusteriId { get; set; }
        [ForeignKey("MusteriId")]
        public ApplicationUser ApplicationUser { get; set; }

        public double ToplamUcret { get; set; }

        public DateTime SiparisTarihi { get; set; }

        public SiparisDurumu SiparisDurumu { get; set; }

        public string SiparisKodu { get; set; }

        public string Aciklama { get; set; }

    }

    public enum SiparisDurumu
    {
        YolaCikiyor,
        KuryeTeslimAldi,
        KuryeYolaCikti,
        TeslimEdildi,
       
    }
}
