using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Song
    {
        public string SongFileName { get; set; }
        public string SongTitle { get; set; }
        public string AlbumArtist { get; set; }
        public string ContributingArtist { get; set; }
        public string YearReleased { get; set; }
    }
}
