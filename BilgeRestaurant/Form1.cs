using BilgeRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BilgeRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Icecek> icecekler = new List<Icecek>()
            {
                new Icecek {Ad = "Kola", Fiyat = 30},
                new Icecek {Ad = "Meyve Suyu", Fiyat = 15},
                new Icecek {Ad = "Gazoz", Fiyat = 25},
                new Icecek {Ad = "Fanta", Fiyat = 30},
                new Icecek {Ad = "Su", Fiyat = 10}
            };
            CbIcecekler.DataSource = icecekler;
            CbIcecekler.SelectedIndex = -1;

            List<Tatli> tatlilar = new List<Tatli>()
            {
                new Tatli {Ad = "Baklava",Fiyat = 60},
                new Tatli {Ad = "Katmer",Fiyat = 55},
                new Tatli {Ad = "Kazandibi",Fiyat = 40},
                new Tatli {Ad = "Künefe",Fiyat = 65},
                new Tatli {Ad = "Şekerpare",Fiyat = 35}
            };
            CbTatlilar.DataSource = tatlilar;
            CbTatlilar.SelectedIndex = -1;

            List<AnaYemek> anaYemekler = new List<AnaYemek>()
            {
                new AnaYemek {Ad = "Tekirdağ Köftesi",Fiyat = 250},
                new AnaYemek {Ad = "Adana Kebap",Fiyat = 350},
                new AnaYemek {Ad = "Patates Oturtma",Fiyat = 200},
                new AnaYemek {Ad = "Hasanpaşa Köftesi",Fiyat = 400},
                new AnaYemek {Ad = "Tepsi Kebabı",Fiyat = 450}
            };
            CbAnaYemekler.DataSource = anaYemekler;
            CbAnaYemekler.SelectedIndex = -1;

            List<AraSicak> araSicaklar = new List<AraSicak>()
            {
                new AraSicak {Ad = "Paçanga Böreği",Fiyat = 100},
                new AraSicak {Ad = "Kalamar Tava",Fiyat = 280},
                new AraSicak {Ad = "Rum Böreği",Fiyat = 150},
                new AraSicak {Ad = "Tavuklu Volovan",Fiyat = 85},
                new AraSicak {Ad = "Patates Kroket",Fiyat = 120}
            };
            CbAraSicaklar.DataSource = araSicaklar;
            CbAraSicaklar.SelectedIndex = -1;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMasaNo.Text))
            {
                MessageBox.Show("Masa numarası boş olamaz");
                return;
            }

            if(CbTatlilar.SelectedItem == null && CbIcecekler.SelectedItem == null && CbAnaYemekler.SelectedItem == null && CbAraSicaklar.SelectedItem == null)
            {
                MessageBox.Show("Herhangi bir ürün seçmeden sipariş oluşturamazsınız");
                return;
            }

            Siparis yeniSiparis = YeniSiparisOlustur();
            LstSiparisler.Items.Add(yeniSiparis);

            SecilenleriTemizle();
        }

        private void BtnCiro_Click(object sender, EventArgs e)
        {
            decimal toplamCiro = 0;

            foreach (Siparis item in LstSiparisler.Items)
            {
                if(item.SecilenAraSicak != null) toplamCiro += item.SecilenAraSicak.Fiyat;
                if(item.SecilenAnaYemek != null) toplamCiro += item.SecilenAnaYemek.Fiyat;
                if(item.SecilenIcecek != null) toplamCiro += item.SecilenIcecek.Fiyat;
                if(item.SecilenTatlilar != null) toplamCiro += item.SecilenTatlilar.Fiyat;
            }
            MessageBox.Show(toplamCiro.ToString("C2"));
        }

        private Siparis YeniSiparisOlustur()
        {
            Siparis s = new Siparis(TxtMasaNo.Text);
            s.SecilenTatlilar = CbTatlilar.SelectedItem as Tatli;
            s.SecilenIcecek = CbIcecekler.SelectedItem as Icecek;
            s.SecilenAnaYemek = CbAnaYemekler.SelectedItem as AnaYemek;
            s.SecilenAraSicak = CbAraSicaklar.SelectedItem as AraSicak;
            return s;
        }

        private void SecilenleriTemizle()
        {
            CbTatlilar.SelectedIndex = -1;
            CbIcecekler.SelectedIndex = -1;
            CbAnaYemekler.SelectedIndex = -1;
            CbAraSicaklar.SelectedIndex = -1;
        }
    }
}
