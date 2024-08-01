using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeRestaurant.Models
{
    public class Siparis : BaseEntity
    {
        public Siparis(string ad) 
        {
            Ad = ad;
        }

        public Icecek SecilenIcecek { get; set; }
        public AnaYemek SecilenAnaYemek { get; set; }
        public AraSicak SecilenAraSicak { get; set; }
        public Tatli SecilenTatlilar { get; set; }


        decimal TutarHesapla()
        {
            decimal toplamFiyat = 0;
            if(SecilenIcecek != null) toplamFiyat += SecilenIcecek.Fiyat;
            if(SecilenAnaYemek != null) toplamFiyat += SecilenAnaYemek.Fiyat;
            if(SecilenAraSicak != null) toplamFiyat += SecilenAraSicak.Fiyat;
            if (SecilenTatlilar != null) toplamFiyat += SecilenTatlilar.Fiyat;
            return toplamFiyat;
        }

        public override string ToString()
        {
            return $"{Ad} Nosuna: {SecilenAnaYemek}/{SecilenAraSicak}/{SecilenTatlilar}/{SecilenIcecek}, Toplam:{TutarHesapla():C2}";
        }



    }
}
