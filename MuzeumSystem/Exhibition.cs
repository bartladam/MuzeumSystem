using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    /// <summary>
    /// Visitors come to museum to see some exhibition
    /// </summary>
    internal class Exhibition
    {
        /// <summary>
        /// Visitors have to know, which exhibition is available
        /// </summary>
        public string nameExhibition { get; private set; }
        /// <summary>
        /// Single artworks make whole exhibition
        /// </summary>
        private List<Artwork> exhibitionArtworks { get; set; }
        /// <summary>
        /// Genre of exhibition. Visitors can decide between few topics
        /// </summary>
        public enum Genre {History, Nature, Design, Paintings}
        public Genre genre { get; private set; }
        /// <summary>
        /// Visitors have to pay entrance fee on exhibition
        /// </summary>
        public int entrancePrice { get; private set; }
        public Exhibition(string nameExhibition,Genre genre, int entrancePrice, params Artwork[] artworks)
        {
            this.nameExhibition = nameExhibition;
            exhibitionArtworks = new List<Artwork>(artworks);
            this.genre = genre;
            this.entrancePrice = entrancePrice;
        }
        /// <summary>
        /// Guide shows exhibition 
        /// </summary>
        /// <returns></returns>
        public List<string> ShowExhibition()
        {
            List<string> detailsArtwork = new List<string>();
            for (int i = 0; i < exhibitionArtworks.Count; i++)
            {
                if(i == 0)
                    detailsArtwork.Add(string.Format("Guide:\nFirst artwork is made by {0} in year {1}. Artwork by {2} is called {3}\n{4}\n", exhibitionArtworks[i].Artist,exhibitionArtworks[i].createdArtwork.Year, exhibitionArtworks[i].Artist,exhibitionArtworks[i].nameArtwork, exhibitionArtworks[i].descriptionArtwork));
                else
                    detailsArtwork.Add(string.Format("Guide:\nThe next artwork we call {0}. Artist {1} catch in year {2}\n{3}\n", exhibitionArtworks[i].nameArtwork,exhibitionArtworks[i].Artist, exhibitionArtworks[i].createdArtwork.Year, exhibitionArtworks[i].descriptionArtwork));

            }
            return detailsArtwork;
        }
    }
}
