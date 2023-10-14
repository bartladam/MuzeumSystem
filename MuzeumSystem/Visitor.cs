using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    internal class Visitor
    {
        /// <summary>
        /// Visitor have to decide, which museum wants to see. We saved his choice
        /// </summary>
        private Museum museum { get; init; }
        public Visitor(Museum museum)
        {
            this.museum = museum;
        }
        /// <summary>
        /// Visitors get list of exhibition, option to sort by topics and option to select one exhibition
        /// </summary>
        public void SelectExhibition()
        {
            (int, string) list = museum.ListExhibitions("all");
            Console.WriteLine("Founded: {0}\nExhibitions: {1}\n", list.Item1, list.Item2);
            Console.Write("Select exhibition by genre [History, Nature, Design, Paintings] (y/n): ");

            while(Console.ReadLine().ToLower().Equals("y"))
            {
                Console.Clear();
                Console.WriteLine("Genre: [History, Nature, Design, Paintings, all]");
                Console.Write("Select genre: ");
                string genre = Console.ReadLine();
                (int, string) exhibitionGenre = museum.ListExhibitions(genre);
                Console.WriteLine("\nFounded: {0}\n{1}", exhibitionGenre.Item1, exhibitionGenre.Item2);
                Console.WriteLine("Repeat sort by genre (y/n): ");
            }
            Console.Write("Select exhibition by name: ");
            string selectedExhibition = Console.ReadLine();
            foreach (Exhibition item in museum.exhibitions)
            {
                if (item.nameExhibition.Equals(selectedExhibition))
                {
                    Console.Write("Pay for exhibition: ");
                    int money = int.Parse(Console.ReadLine());
                    bool status = museum.PayForExhibition(item, money);
                    if (status)
                        museum.SelectExhibition(item);
                }

            }

        }
        /// <summary>
        /// After exhibition, visitors can buy something in shop
        /// </summary>
        public void BuyInMuzeumShop()
        {
            Console.WriteLine(museum.museumShop.ShopOffer());
            Console.Write("Do you want something buy [y/n]: ");
            if(Console.ReadLine().ToLower().Equals("y"))
            {
                Console.Write("Product what you want: ");
                Console.WriteLine("\n"+ museum.museumShop.BuyProduct(Console.ReadLine())); 
            }
        }


    }
}
