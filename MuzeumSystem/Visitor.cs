using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    internal class Visitor
    {
        private Muzeum muzeum { get; init; }
        public Visitor(Muzeum muzeum)
        {
            this.muzeum = muzeum;
        }
        public void SelectExhibition()
        {
            (int, string) list = muzeum.ListExhibitions("all");
            Console.WriteLine("Founded: {0}\nExhibitions: {1}\n", list.Item1, list.Item2);
            Console.Write("Select exhibition by genre [History, Nature, Design, Paintings] (y/n): ");

            while(Console.ReadLine().ToLower().Equals("y"))
            {
                Console.Clear();
                Console.WriteLine("Genre: [History, Nature, Design, Paintings, all]");
                Console.Write("Select genre: ");
                string genre = Console.ReadLine();
                (int, string) exhibitionGenre = muzeum.ListExhibitions(genre);
                Console.WriteLine("\nFounded: {0}\n{1}", exhibitionGenre.Item1, exhibitionGenre.Item2);
                Console.WriteLine("Repeat sort by genre (y/n): ");
            }
            Console.Write("Select exhibition by name: ");
            string selectedExhibition = Console.ReadLine();
            foreach (Exhibition item in muzeum.exhibitions)
            {
                if (item.nameExhibition.Equals(selectedExhibition))
                {
                    Console.Write("Pay for exhibition: ");
                    int money = int.Parse(Console.ReadLine());
                    bool status = muzeum.PayForExhibition(item, money);
                    if (status)
                        muzeum.SelectExhibition(item);
                }

            }

        }
    }
}
