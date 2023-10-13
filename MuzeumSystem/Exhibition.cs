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
        public List<string> ShowExhibition()
        {
            List<string> detailsArtwork = new List<string>();
            for (int i = 0; i < exhibitionArtworks.Count; i++)
            {
                if(i == 0)
                    detailsArtwork.Add(string.Format("First artwork is made by {0} in year {1}. {2}\n", exhibitionArtworks[i].Artist, exhibitionArtworks[i].createdArtwork.ToShortDateString(), exhibitionArtworks[i].descriptionArtwork));
                else
                    detailsArtwork.Add(string.Format("Artist {0} in year {1}. {2}\n", exhibitionArtworks[i].Artist, exhibitionArtworks[i].createdArtwork.ToShortDateString(), exhibitionArtworks[i].descriptionArtwork));

            }
            return detailsArtwork;
        }
    }
}
