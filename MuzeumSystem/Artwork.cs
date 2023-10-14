using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    /// <summary>
    /// The exhibition is made up of works of art
    /// </summary>
    internal class Artwork
    {
        /// <summary>
        /// Artwork name by artist 
        /// </summary>
        public string nameArtwork { get; private set; }
        /// <summary>
        /// What artwork say to visitors
        /// </summary>
        public string descriptionArtwork { get; private set; }
        /// <summary>
        /// Time when the artwork was created
        /// </summary>
        public DateTime createdArtwork { get; private set; }
        /// <summary>
        /// Artist name
        /// </summary>
        public string Artist { get; private set; }
        public Artwork(string nameArtwork, string descriptionArtwork, DateTime createdArtwork, string Artist)
        {
            this.nameArtwork = nameArtwork;
            this.descriptionArtwork = descriptionArtwork;
            this.createdArtwork = createdArtwork;
            this.Artist = Artist;

        }
    }
}
