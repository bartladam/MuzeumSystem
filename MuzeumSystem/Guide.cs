using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    /// <summary>
    /// Guide helps visitors to orient at exhibition
    /// </summary>
    internal class Guide
    {
        /// <summary>
        /// Name of guide who introduce exhibition
        /// </summary>
        public string nameGuide { get; init; }
        /// <summary>
        /// Surname of guide who introduce exhibition
        /// </summary>
        public string surnameGuide { get; init; }
        /// <summary>
        /// Each guide is assigned to one exhibition
        /// </summary>
        public Exhibition exhibition { get; set; }
        public Guide(string nameGuide, string surnameGuide)
        {
            this.nameGuide = nameGuide;
            this.surnameGuide = surnameGuide;
        }
        /// <summary>
        /// Guide is introducing exhibition to visitors
        /// </summary>
        public void ShowExhibition()
        {
            Console.WriteLine("\nGuide:\nHello, my name is {0} {1} and today\ni will present you exhibition {2}\n", nameGuide,surnameGuide,exhibition.nameExhibition);
            foreach (string item in exhibition.ShowExhibition())
            {
                Task.Delay(3000).Wait();
                Console.WriteLine(item);
            }
            Task.Delay(3000).Wait();
            Console.WriteLine("Guide: Now we are in the end of our exhibition.\nThank you for your attention.\nWe move on to muzeum shop and you can something buy\n");
        }


    }
}
