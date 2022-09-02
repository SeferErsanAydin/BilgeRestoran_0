using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeRestoran_0.Models
{
    public class Siparis : BaseEntity
    {

        public List<MenuIcerik> MenuIcerigi { get; set; }
        public Siparis()
        {
            MenuIcerigi = new List<MenuIcerik>();
        }
        public decimal ToplamTutar { get; private set; }
        public void TutarHesapla()
        {
            ToplamTutar = 0;

            foreach (MenuIcerik item in MenuIcerigi)
            {
                ToplamTutar += item.Fiyat;
            }

        }
        public override string ToString()
        {

            string sip = null;

            foreach (MenuIcerik item in MenuIcerigi)
            {
                sip += $"{item.Ad},";
            }
            if (sip is null)
            {
                return $"{Ad} No'lu masa için ürün seçilmediginden dolayı sipariş oluşturulamadı";
            }
            else
            {
                sip = sip.TrimEnd(',');

                return $"{Ad} No'lu masa için sipariş => {sip} Toplam Tutar => {ToplamTutar:C2}";
            }
            
        }
    }
}
