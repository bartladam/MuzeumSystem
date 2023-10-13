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
        public string descriptionArtWork { get; private set; }
        public DateTime createdArtWork { get; private set; }
        public string Artist { get; private set; }
        public Artwork(string nameArtwork, string descriptionArtWork, DateTime createdArtWork, string Artist)
        {
            this.nameArtwork = nameArtwork;
            this.descriptionArtWork = descriptionArtWork;
            this.createdArtWork = createdArtWork;
            this.Artist = Artist;

        }
    }
}
