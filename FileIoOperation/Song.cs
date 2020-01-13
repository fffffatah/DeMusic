using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace FileIoOperation
{
    public class Song
    {
        public string SongFileName { get; set; }
        public string SongTitle { get; set; }
        public string AlbumArtist { get; set; }
        public string ContributingArtist { get; set; }
        public string YearReleased { get; set; }
        [TestMethod]
        public void SetTags(string loc)
        {
            File f = File.Create(loc);
            SongTitle = f.Tag.Title;
            AlbumArtist = f.Tag.FirstAlbumArtist;
        }
    }
}
