using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeRestaurant.Models
{
    public abstract class BaseEntity
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
    }
}
