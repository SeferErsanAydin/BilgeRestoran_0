using BilgeRestoran_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeRestoran_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();
            s.Ad = txtMasaNo.Text;
            if (s.Ad == "")                                             //masa id si girilmediginde  mesaj
            {
                MessageBox.Show("Masa No'sunu Girmeniz gerekmektedir");
                return;
            }

            Fiyatla(s);
            s.TutarHesapla();
            lstSiparisler.Items.Add(s);
            lblAciklama.Text = "";
        }
        private void btnOnIzleme_Click(object sender, EventArgs e)
        {
            lblAciklama.Text = "";
            Siparis s = new Siparis();

            Fiyatla(s);
            s.TutarHesapla();

            lblAciklama.Text += $"Siparişiniz toplamda {s.ToplamTutar:C2} tutacaktır.\n";
            if (txtMasaNo.Text == "") lblAciklama.Text += "Siparişi onaylamadan önce masa No'nuzu eklemeyi unutmayın";
            if (s.ToplamTutar == 0) lblAciklama.Text = "";              // kullanıcı herhangibir ürün seçmediyse açıklama kısmında çıkan yazıyı siler
        }

        private void Fiyatla(Siparis s)                                 // onizleme ve sipariş için fiyat hesaplar, siparişte ürün yoksa kullanıcıya bilgi verir. 
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    foreach (CheckBox chk in item.Controls)
                    {
                        if (chk.Checked)
                        {
                            MenuIcerik i = new MenuIcerik();
                            i.Ad = chk.Text;
                            i.Fiyat = Convert.ToDecimal(chk.Tag);
                            s.MenuIcerigi.Add(i);
                            lblAciklama.Text += $"{chk.Text} => {chk.Tag} ₺\n";
                        }
                    }
                }
            }
            if (s.MenuIcerigi.Count < 1)
            {
                MessageBox.Show("Siparişte en az bir ürün olmak zorunda");
                return;
            }
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            decimal ciro = 0;
            foreach (Siparis item in lstSiparisler.Items)
            {
                ciro += item.ToplamTutar;
            }
            lblCiro.Text = $"{ciro:C2}";
        }

        private void txtMasaNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMasaNo.Text, "[^0-9]"))    // stackoverflow sagolsun, ayrıca max 2 haneli olarak ayarladım propertylerinden
            {
                txtMasaNo.Text = txtMasaNo.Text.Remove(txtMasaNo.Text.Length - 1);
            }
        }
    }
}
