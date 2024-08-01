using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeRestaurant.Models
{
    public class AnaYemek : BaseEntity
    {
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Ad)) return $"{Ad} => {Fiyat:C2}";
            return "";
        }
    }
}
