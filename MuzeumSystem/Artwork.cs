using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    internal class Artwork
    {
        public string nameArtwork { get; private set; }
        public string descriptionArtwork { get; private set; }
        public DateTime createdArtwork { get; private set; }
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
