using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeRestoran_0.Models
{
    public abstract class BaseEntity
    {
        public string Ad { get; set; }
        private decimal _fiyat;
        public decimal Fiyat 
        {
            get
            {
                if (_fiyat <= 0)
                {
                    System.Windows.Forms.MessageBox.Show("Dikkat ediniz ürün fiyatı yanlış girilmiştir, sonuc 0 olacaktır");
                    throw new Exception("ürün fiyatı 0");
                }
                return _fiyat;
            }
            set
            {
                if (value <= 0) throw new Exception("Fiyat 0 veya 0 dan küçük olamaz");
                _fiyat = value;
            }
        }
        
    }
}
