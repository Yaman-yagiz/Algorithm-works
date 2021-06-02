using System;

namespace Kuzem_3._ders
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-Soru : a sayısını sağdan 2. 4 bitlik bölümünü 1 arttıralım
            // 1.Yol
            uint a = 0x000000ef ;   // 0xef  0000 0000 0000 0000 0000 0000 1110 1111
            //a += 0x10;            // 0x10  0000 0000 0000 0000 0000 0000 0001 0000
            // a= 0000 0000 0000 0000 0000 0000 1111 1111 yani a = 0xff oldu.

            // 2.Yol  ÖNEMLİ Bu örnekte bütün bitwise işlemleri hemen hemen bulunmaktadır.
            uint yedek = 0 ;
            // 0000 0000 0000 0000 0000 0000 1110 1111 = a
            // 0000 0000 0000 0000 0000 0000 1111 0000 = 0xf0
    // yedek = 0000 0000 0000 0000 0000 0000 1110 0000
            yedek = a & 0xf0 ;
            yedek >>= 4; // 0000 0000 0000 0000 0000 0000 0000 1110
            yedek++; // 0000 0000 0000 0000 0000 0000 0000 1111
            yedek <<= 4; // 0000 0000 0000 0000 0000 0000 1111 0000
            a = a & 0xffffff0f ;
            // 0000 0000 0000 0000 0000 0000 1110 1111
            // 1111 1111 1111 1111 1111 1111 0000 1111
            // a = 0000 0000 0000 0000 0000 0000 0000 1111
            

            a = a | yedek;
            // a =     0000 0000 0000 0000 0000 0000 0000 1111
            // yedek = 0000 0000 0000 0000 0000 0000 1111 0000
            // a =     0000 0000 0000 0000 0000 0000 1111 1111
            

            // 2-Soru : a sayısının en sağdaki 2 biti ile en soldaki 2 bitini  toplamda 4 bit yani bu arttıralım.



            // 3-Soru a) Aşağıdaki x y ve d c ikililerini toplayalım. b) 1.grub(y,x) i 2 ile çarp. c) 2.grub(c,d) yi 2 ye bölelim.
            // ikili grupları toplarken grubu 64 bit olarak düşün. a ve c şıkkını sen çöz.

            // b) ikisini bir 64 bitlik sayı gibi düşün
            uint x = 0x80000000; // 32 bit msb y; lsb x;
            // 1000 0000 0000 0000 0000 0000 0000 0000
            uint y = 0; // 32 bit
            uint elde = 0;

            //eldenin oluşmasını ve nasıl kullanacğımızı şu örnekle inceleyelim.
            // y= 0000 0000 0000 0000 0000 0000 0000 0000 x= 1000 0000 0000 0000 0000 0000 0000 0001  
            // bu şekilde iken sola shift yaparsak en baştaki 1 in y'ye eklenmesi gerekir.
            // yani yeni y= 0000 0000 0000 0000 0000 0000 0000 0001   x= 0000 0000 0000 0000 0000 0000 0000 0010 bu şekilde olmalıdır.

            if ((x & 0x80000000) != 0) elde++; 
            // x ile 1000 0000 0000 0000 0000 0000 0000 0000 ' ı and ler eğer 0 dan farklı ise yani x ' in baştaki biti 1 ise elde 1 var demektir bu yüzden elde artar.
            x = x << 1;
            y = (y << 1) + elde; // eldenin y'ye yansıması için de toplarız.

            Console.WriteLine(x);
            Console.WriteLine(y);
            // 0000 0000 0000 0000 0000 0000 0000 0000  0000 0000 0000 0000 0000 0000 0000 0000    

            uint c = 0; // 32 bit
            uint d = 0; // 32 bit

            // 4-Soru : uint[] a = new uint[100]; bu sayıyı a[0] dan itibaren 1 er bit sola shift yap. elde yi ona göre ayarlamalısın. 32 bit 100 tane 3200 bitlik sayıyı 2 ile çarpmış olacağız.
            uint[] q = new uint[100];   
            uint elde1 = 0;
            uint eskiElde = 0;
            for (int i = 0; i < q.Length; i++)
            {
                if ((q[i] & 0x80000000) != 0) elde1++;
                q[i] = q[i] << 1;
                q[i] += eskiElde;
                eskiElde = elde1;
                elde1 = 0;
            }
            //q[0] = 1000 0000 0000 0000 0000 0000 0000 0000   elde1 = 1
            //       1000 0000 0000 0000 0000 0000 0000 0000
            // sola shiftli hali q[0]= 0000 0000 0000 0000 0000 0000 0000 0000
            // eskiElde+=q[0] 0000 0000 0000 0000 0000 0000 0000 0000 +0 
            // eskiElde=1
            // elde1=0

            // q[1] = 1100 0000 0000 0000 0000 0000 0000 0000 elde1=1
            //  solshift 1000 0000 0000 0000 0000 0000 0000 0000
            // eskiElde+q[1] = 1000 0000 0000 0000 0000 0000 0000 0001
            // 
        }
    }
}
