using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    /// <summary>
    /// Place where visitors can see exhibitions
    /// </summary>
    internal class Museum
    {
        /// <summary>
        /// Official name museum
        /// </summary>
        public string nameMuseum { get; init; }
        /// <summary>
        /// Adress museum
        /// </summary>
        public string adress { get; init; }
        /// <summary>
        /// Museum has guides who are introducing exhibitions
        /// </summary>
        private List<Guide> guides { get; set; }
        /// <summary>
        /// List of exhibitions what museum offers to visitors
        /// </summary>
        public List<Exhibition> exhibitions { get; private set; }
        /// <summary>
        /// Visitors after exhibition, can something buy in museum shop
        /// </summary>
        public MuseumShop museumShop { get; init; }
        /// <summary>
        /// Museum has security guards if someone want to steal or break something
        /// </summary>
        private SecurityGuard[] guards { get; set; }
        public Museum(string nameMuseum, string adress, MuseumShop museumShop, SecurityGuard[] guards, params Guide[] guides)
        {
            this.nameMuseum = nameMuseum;
            this.adress = adress;
            this.guides = new List<Guide>(guides);
            exhibitions = new List<Exhibition>();
            this.museumShop = museumShop;
            this.guards = guards;
        }
        /// <summary>
        /// Museum can add exhibition
        /// </summary>
        /// <param name="exhibition"></param>
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
        /// <summary>
        /// Visitors can see offered exhibitions and sort by topics what they prefer
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Visitors pick one exhibition, what they want to see
        /// </summary>
        /// <param name="exhibition"></param>
        public void SelectExhibition(Exhibition exhibition)
        {
            foreach (Guide item in guides)
            {
                if (item.exhibition == exhibition)
                    item.ShowExhibition();
            }
        }
        /// <summary>
        /// After selected exhibition, visitors have to pay entrance
        /// </summary>
        /// <param name="exhibition"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public bool PayForExhibition(Exhibition exhibition, int money) => (money == exhibition.entrancePrice) ? true : false;
        /// <summary>
        /// List of guards where each one guard one exhibition
        /// </summary>
        /// <returns></returns>
        public string GuardMuzeum()
        {
            string deploymentGuards = "\nSecurity of museum:\n";
            for (int i = 0; i < guards.Length; i++)
            {
                deploymentGuards += guards[i].Guard(exhibitions[i]) + "\n";
            }
            return deploymentGuards;
        }
    }
}
