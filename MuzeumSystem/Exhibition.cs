using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    internal class Exhibition
    {
        public string nameExhibition { get; private set; }
        private List<Artwork> exhibitionArtworks { get; set; }
        public Guide guide { get; private set; }
        public enum Genre {History, Nature, Design, Paintings}
        public Genre genre { get; private set; }
        public int entrancePrice { get; private set; }
        public Exhibition(string nameExhibition,Genre genre, int entrancePrice, params Artwork[] artworks)
        {
            this.nameExhibition = nameExhibition;
            exhibitionArtworks = new List<Artwork>(artworks);
            this.genre = genre;
            this.entrancePrice = entrancePrice;
        }
        public List<string> ShowExhibition()
        {
            List<string> detailsArtwork = new List<string>();
            for (int i = 0; i < exhibitionArtworks.Count; i++)
            {
                if(i == 0)
                    detailsArtwork.Add(string.Format("First artwork is made by {0} in year {1}. Artwork by {2} is called {3}\n{4}\n", exhibitionArtworks[i].Artist,exhibitionArtworks[i].createdArtwork.Year, exhibitionArtworks[i].Artist,exhibitionArtworks[i].nameArtwork, exhibitionArtworks[i].descriptionArtwork));
                else
                    detailsArtwork.Add(string.Format("This artwork we call {0}. Artist {1} catch in year {2}\n{3}\n", exhibitionArtworks[i].nameArtwork,exhibitionArtworks[i].Artist, exhibitionArtworks[i].createdArtwork.Year, exhibitionArtworks[i].descriptionArtwork));

            }
            return detailsArtwork;
        }
    }
}
