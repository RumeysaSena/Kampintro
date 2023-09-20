using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Musteri    // classların içerisinde özellikler ve operasyonlar tutar. özellik tuttuğumz yerde operasyon, operasyn tuttuğumuz yerde özellik tutmuyoruz.
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }

        // matematiksel işlem yapıp, ona sayı görevi vermiyorsan string olarak kullan.

    }
}

// eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsa,o alan o nesneye ait değilmiş gibi duruyorsa soyutlama hatası yapıyorsun dmeektir