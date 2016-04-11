using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM102Quiz1
{
    class Heureux
    {
        private int number;

        public int Number
        {
            get { return number; }
            set
            {
                if (value <= 0)
                {
                    number = 1;
                }
                else number = value;
            }
        }



        public bool hesapla()
        {

            int hesaplanan_deger = this.Number;
            int hesaplanan_kare = 0;
            if (hesaplanan_deger < 10)
            {
                hesaplanan_deger *= hesaplanan_deger;
            }

            for (; hesaplanan_deger >= 10;)
            {
                int basamak_sayisi = basamakSayısı(hesaplanan_deger);

                for (int i = 0; i < basamak_sayisi; i++)
                {
                    int basamak_deger = hesaplanan_deger % 10;
                    hesaplanan_deger = hesaplanan_deger / 10;
                    hesaplanan_kare += basamak_deger * basamak_deger;
                }

                hesaplanan_deger = hesaplanan_kare;
                hesaplanan_kare = 0;
            }


            if (hesaplanan_deger == 1)
            {
                return true;
            }
            // commit message


            return false;
        }

        int basamakSayısı(int sayi)
        {
            if (sayi / 10 == 0)
            {
                return 1;
            }
            else return basamakSayısı(sayi / 10) + 1;
        }
    }
}
