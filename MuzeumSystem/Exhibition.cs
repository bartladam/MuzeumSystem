using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    internal class Exhibition
    {
        private List<Artwork> exhibitionArtworks { get; set; }
        public Guide guide { get; private set; }
        public Exhibition(Guide guide,params Artwork[] artworks)
        {
            exhibitionArtworks = new List<Artwork>(artworks);
            this.guide = guide;
        }
        public void ShowExhibition()
        {

        }
    }
}
