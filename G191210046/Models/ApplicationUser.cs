using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace G191210046.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Adres { get; set; }
        public string TelNo { get; set; }

        public string AdSoyad
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }
    }
}
