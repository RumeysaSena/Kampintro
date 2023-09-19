using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } // hangi katogorideyse onun Idsi
        public string ProductName { get; set; } // ürün adı
        public double UnitPrice { get; set; }  //  ürünün birim fiyatı
        public int UnitInStock { get; set; }  //   ürün stok adedi

        

    }
}
