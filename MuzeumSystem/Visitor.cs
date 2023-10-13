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
            Console.WriteLine("Founded: {0}\nExhibitions: {1}", list.Item1, list.Item2);
            Console.Write("Select exhibition by genre [History, Nature, Design, Paintings] (y/n): ");
            string choice = Console.ReadLine();
            if (choice.Equals("y"))
            {
                Console.Clear();
                Console.WriteLine("Genre: [History, Nature, Design, Paintings");
                Console.Write("Select genre:");
                string genre = Console.ReadLine();
                (int, string) exhibitionGenre = muzeum.ListExhibitions(genre);
                Console.WriteLine("Founded: {0}\nExhibitions: {1}", exhibitionGenre.Item1, exhibitionGenre.Item2);
            }
            else
            {
                Console.WriteLine("Select exhibition by name: ");
                string selectedExhibition = Console.ReadLine();
                foreach (Exhibition item in muzeum.exhibitions)
                {
                    if (item.nameExhibition.Equals(selectedExhibition))
                    {
                        Console.WriteLine("Pay for exhibition: ");
                        int money = int.Parse(Console.ReadLine());
                        bool status = muzeum.PayForExhibition(item, money);
                        if (status)
                            muzeum.SelectExhibition(item);
                    }
                        
                }
            }
        }
    }
}
