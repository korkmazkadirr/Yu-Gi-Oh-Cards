using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yu_Gi_Oh_Cards.Models
{
    public class Kategori
    {

        public int Id { get; set; }

        public string Ad { get; set; }

        public bool Durum { get; set; } = true;
    }
}
