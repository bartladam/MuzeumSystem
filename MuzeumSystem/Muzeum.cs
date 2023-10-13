using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    internal class Muzeum
    {
        public string nameMuzeum { get; init; }
        public string adress { get; init; }
        private List<Guide> guides { get; set; }
        public List<Exhibition> exhibitions { get; private set; }
        public MuzeumShop muzeumShop { get; init; }
        public Muzeum(string nameMuzeum, string adress, MuzeumShop muzeumShop, params Guide[] guides)
        {
            this.nameMuzeum = nameMuzeum;
            this.adress = adress;
            this.guides = new List<Guide>(guides);
            exhibitions = new List<Exhibition>();
            this.muzeumShop = muzeumShop;
        }
        public void AddExhibition(Exhibition exhibition)
        {
            exhibitions.Add(exhibition);
            foreach (Guide item in guides)
            {
                if(item.exhibition is null)
                {
                    item.exhibition = exhibition;
                    break;
                }
            }
        }
        public (int, string) ListExhibitions(string type)
        {
            string selectedExhibition = "";
            int numberFounded = 0;
            if(type.ToLower() is "all")
            {
                foreach (Exhibition item in exhibitions)
                {
                    selectedExhibition += string.Format("Exhibition: {0} ({1} Kč)\n", item.nameExhibition, item.entrancePrice);
                    numberFounded++;
                }
            }
            else
            {
                var exhibition = from i in exhibitions
                                 where (i.genre.ToString().Equals(type))
                                 select i;
                
                foreach (var item in exhibition)
                {
                    selectedExhibition += string.Format("Exhibition: {0} ({1} Kč)\n", item.nameExhibition, item.entrancePrice);
                    numberFounded++;
                }
            }
            return (numberFounded, selectedExhibition);
        }
        public void SelectExhibition(Exhibition exhibition)
        {
            foreach (Guide item in guides)
            {
                if (item.exhibition == exhibition)
                    item.ShowExhibition();
            }
        }
        public bool PayForExhibition(Exhibition exhibition, int money) => (money == exhibition.entrancePrice) ? true : false;
        
    }
}
