using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.Write("整数を入力:");
int i, amari, count;
i = 1;
count = 0;
int suji = int.Parse(Console.ReadLine());
while (i <= suji)
{
    amari = suji % i;
    if (amari == 0)
    {
        count++;
    }
    i++; ;
}

if (count == 2) 
   {
    Console.WriteLine("これは素数です");
    }
else if (count > 2) 
   { 
    Console.WriteLine("これは素数ではないです");
   }