using System;

namespace Kuzem_8.ders
{
    class Program
    {
        // ÖDEV
        static int index = 0;
        static public string palindromik(string s,string y)
        {
            if (s == y)  return "Palindromik";
            if (s.Length == index) return "Palindromik değil";
            else { y = s[index] + y; index++; return palindromik(s, y); }
        }


        static void Main(string[] args)
        {
            // palindromik stringler yani sağdan ve soldan okunuşları aynı olacak (omo , ama , ala .... gibi)
            // bir stringin palindromik olup olmadığını anlayan algoritmayı yaz
            // ÖDEV BUNU RECURSİVE ÇÖZ.
            // ÖDEV 2. ÇÖZÜM YOLU BUL.
            // ÖDEV string a = "asdasd123454321dfsşfdsf" gib içerisnde palindromil ifade  gömülü stringde içersindeki en uzun palindromik ifadeyi bulan algoritmayı yaz.
            // 2 5 7 7 8 4 5 6 7 3 5 5 77 7 gibi yanda belli aralıklarla pik yapan sayılar vardır. Kaç kere pik olduğunu bulan algoritmayı yaz. Time serisi

            //Console.WriteLine("Bir kelime ya da sayı giriniz :");
            string s = "12321";
            string y = "";
            //for (int i = s.Length-1; i >= 0; i--)
            //{
            //    y += s[i];
            //}
            // 2. çözüm olarak  aşağıdaki yapı kullanılabilir.
            //for (int i = 0; i < s.Length; i++)
            //{
            //    y = s[i] + y;
            //}
            //if (y==s) Console.WriteLine("Evet bu string palindromiktir.");
            //else Console.WriteLine("palindromik değil");
            Console.WriteLine(palindromik(s, y)); 

            // 3. Çözüm en kısa temiz çözüm TAM ÇÖZÜM DEĞİL DEVAM ETTİR
    //        int a = 0;
    //        int b = s.Length - 1;
    //        while (s[a]==s[b] && b>=a)
    //        {
    //            a++;
    //            b--;
    //        }


    //        // Ugly sayıları 2,3 ve 5 in katları olan sayılardır(1(2 üzeri 0 dan)  de dahil). 1,2,3,4,5,6,8,9,10,12,15 gibi...
    //        // 79. ugly sayısı nedir ? bulan algoritmayı yaz.
    //        // O(n) lineer notasyonlu çözüm.
    //        int ugly = 0;
    //        int sayi = 1;
    //        int deger = 0;
    //        while (ugly<79)
    //        {
    //            if (isugly(sayi)) { ugly++; deger = sayi; }
    //            sayi++;
    //        }
    //        Console.WriteLine(deger);
    //    }

    //    static public int bolum(int a,int b)
    //    {
    //        while (a % b == 0) a = a / b;
    //        return a;
    //    }

    //    static public bool isugly(int a)
    //    {
    //        a = bolum(a, 2);
    //        a = bolum(a, 3);
    //        a = bolum(a, 5);

    //        return a == 1 ? true : false; // a = 1 ise true değil ise false döndür demektir.
    //        // java,javascript,dot.net gibi dillerde de böyle returnlar vardır.
       }
    }
}
