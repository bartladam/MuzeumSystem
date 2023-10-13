using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    internal class Guide
    {
        public string nameGuide { get; init; }
        public string surnameGuide { get; init; }
        public Exhibition exhibition { get; set; }
        public Guide(string nameGuide, string surnameGuide)
        {
            this.nameGuide = nameGuide;
            this.surnameGuide = surnameGuide;
        }
        public void ShowExhibition()
        {
            Console.WriteLine("\nGuide:\nHello, my name is {0} {1} and today\ni will present you exhibition {2}\n", nameGuide,surnameGuide,exhibition.nameExhibition);
            foreach (string item in exhibition.ShowExhibition())
            {
                Task.Delay(2000).Wait();
                Console.WriteLine(item);
            }
            Task.Delay(2000).Wait();
            Console.WriteLine("Guide: Now we are in the end of our exhibition.\nThank you for your attention.\nWe move on to muzeum shop and you can something buy\n");
        }


    }
}
