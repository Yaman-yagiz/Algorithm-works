using System;

namespace Kuzem_4._ders
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-Soru: string içinde string bulma
            string s = "Türk edebiyatında aşk üzerine yazılmış birçok şiir vardır.Taşı delen suyun gücü değil damlaların sürekliliğidir.";
            string q = "aşk";
            int bulundu = 0;
            for (int i = 0; i < s.Length-q.Length; i++)
            {
                if (s[i]==q[0])
                {
                    bulundu = 1;
                    for (int j = 0; j < q.Length; j++)
                    {
                        if (s[i + j] != q[j])
                        {
                            bulundu = 0;
                            break;
                        }
                    }
                }
                if (bulundu == 1) { Console.WriteLine("Bulundu"); break; }
            }
            if (bulundu != 1) { Console.WriteLine("Bulunamadı"); }

        }
    }
}
