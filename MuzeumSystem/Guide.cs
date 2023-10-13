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
            foreach (string item in exhibition.ShowExhibition())
            {
                Console.WriteLine(item);
                Task.Delay(2000).Wait();
            }
        }


    }
}
