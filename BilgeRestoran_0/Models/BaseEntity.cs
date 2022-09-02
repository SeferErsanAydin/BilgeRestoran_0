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
                return _fiyat;
            }
            set
            {
                _fiyat = value;
            }
        }
        
    }
}
