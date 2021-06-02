using System;

namespace Kuzem_10.ders
{
    class Program
    {
        // önceki haftanın algoritmasını iyileştirdik
        //static int odemeyap(int[]s,int m,int n) // s paralar dizisi , m miktar , n ödeyeceğimiz para
        //{
        //    int[] odeme = new int[n + 1];
        //    odeme[0] = 1;
        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = s[i];  j <=n;  j++)
        //        {
        //            odeme[j] += odeme[j - s[i]];
        //        }     
        //    }
        //    return odeme[n];
        //}
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3 };
            Console.WriteLine(odemeyap(x,x.Length,4));


            // yeni soru
            // longest common substring (lcs) lerini bulun. iki string arasındaki ortak ifadeleri bul.
            // dna zincirleri eşitliklerinde kullanılır.
            string s1 = "123456789012345678910";
            string s2 = "12abc345dfg456789t";
            int[,] lcs = new int[s1.Length, s2.Length];
            int eblcs = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s1[j])if(i*j==0) lcs[i, j] = 1;
                        else{lcs[i, j] = lcs[i - 1, j - 1] + 1;
                            if (eblcs < lcs[i, j]) eblcs = lcs[i, j];}
                    
                }
            }
            Console.WriteLine(eblcs);

        }
    }
}
