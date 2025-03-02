using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    public class araba
    {
        public string marka;
        public string model;
        public int pencereSayisi;
        public string vitesTuru;

        public void git()
        {
            Console.WriteLine("gidiyor");
        }

        public void markaVitesyaz(string marka, string vitesTuru)
        {
            Console.WriteLine(marka+" "+ vitesTuru+" "+ "viteslidir.");
        }
    }

    
    
}
