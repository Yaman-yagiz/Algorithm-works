using System;

namespace Kuzem_2._ders
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Soru 1 Verilen bir a sayısının değilini almak
            uint a = 0xfffffffe; // 1111 1111 1111 1111 1111 1111 1111 1110
            uint b = 3;          // 0000 0000 0000 0000 0000 0000 0000 0011
            Console.WriteLine(~a);

            //// xxxxxxxxxxxxxxxxxxxxxxxxxxx1 32 tane 
            //// 0000000000000000000000000001  maske
            //// 1111111111111111111111111110 maskenin değili

            // 2.yol TEKAR ET!
            uint q = 0xfffffffe;
            //1111 1111 1111 1111 1111 1111 1110

            uint maske = 1; //0000 0000 0000 0000 0000 0000 0000 0001

            for (int i = 0; i < 32; i++)
            {
                if ((a & maske) != 0)
                { a = a & q; } // i=1 iken a = 1111 1111 1111 1111 1111 1111 1101
                else
                { a = a | maske; } //i=0 a= 1111 1111 1111 1111 1111 1111 1111 1111 
                maske <<= 1; //i=0 maske = 0000 0000 0000 0000 0000 0000 0000 0010 - i=1 maske= 0000 0000 0000 0000 0000 0000 0000 0100
                q = q << 1;
                q++; //i=0 q = 1111 1111 1111 1111 1111 1111 1101 - i=1 q= 1111 1111 1111 1111 1111 1111 1011
            }
            Console.WriteLine(a);

            // Soru 2 a sayısının bitlerini b ye yansıtmak eşitlemek.
            //uint a = 0xfffffffe; // 1111 1111 1111 1111 1111 1111 1111 1110 a
            //uint b = 0;          // 0000 0000 0000 0000 0000 0000 0000 0000 b
            //uint k = 1;          // 0000 0000 0000 0000 0000 0000 0000 0001 k
            // ~k = 1111 1111 1111 1111 1111 1111 1111 1110 ~k
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((a & k) != 0) { b = b | k; }
            //    else { b = b & ~k; }
            //    k = k << 1;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // Soru 3 bir a sayısı = ff00ff00 olsun bunu tersten
            // kopyalayınız. yani a = 00ff00ff şekilde.
            //uint a = 0xf;
            //uint b = 0;
            //uint c = 0xf0000000;
            //uint k = 1;
            //uint w = 0xefffffff; // 01111111111111111111111111111 32 tane
            //uint s = 0x80000000;
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((a & k) != 0) { b = b|s; }
            //    else { b = b & w; }
            //    k = k << 1;
            //    w = w >> 1;
            //    w = w + 0x80000000;
            //    s = s >> 1;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            // Soru Ekstra : a sayımız sağdan itibaren sola doğru 3. bitten 
            // 4 bitini arttırın 
            // xxxxxxxxxxxxxxxxxxYYYYxx
            // elde kavramı olmadığını düşünelim. 1 arttırılacak

            // 000000000000000000111100 32 tane 0011 1100
            // 000000000000000000xxxx00           3   C
            //uint a; 
            //uint b = a;
            //uint mask = 0x0000003C;
            //uint z = ~mask; 1100 0011
            //b = b & mask;
            //b = b >> 2;
            //b++;
            //b = b << 2;
            //a = a & z;
            //a = a | b;

            uint j = 8; // 1000
            uint f = 0;
            f = j << 1;
            Console.WriteLine(j);
            Console.WriteLine(f);
        }
    }
}
