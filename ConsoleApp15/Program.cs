using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {//bir liste oluşturucaz, listeye kaç eleman attığımızı kullanıcı belirlicek
            //liste random bir şekilde doldurulcak, farklı bir listeye tersten atılcak
            Random r = new Random();
            ArrayList l = new ArrayList();
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                l.Add(r.Next(100));
                Console.WriteLine(l[i]);
            }
            ArrayList li = new ArrayList();
            Console.WriteLine("----------------");
            for (int i = 0; i < a; i++)
            {
                li.Add(l[l.Count - 1 - i]);
            }
            foreach (object item in li)
            {
                Console.WriteLine(item);
            }
        }
    }
}
