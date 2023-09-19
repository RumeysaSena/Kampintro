using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Urun
    {

        //property - özellik
        public int Id { get; set; } // bir datayı diğerlerinden ayırt etmek için eşsiz değeri anlatır.
        public string Adi  { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }


    }
}
