using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDatabaseOperation
{
    public class DeQueries
    {
        string createMusicTable= "CREATE TABLE MUSIC(SongFileName TEXT UNIQUE NOT NULL , SongTitle TEXT DEFAULT 'Unknown Title' NOT NULL , AlbumArtist TEXT DEFAULT 'Unknown Artist' NOT NULL, ContributingArtist TEXT DEFAULT 'Unknown Artist' NOT NULL , YearReleased TEXT DEFAULT 'Unknown Year' NOT NULL, FileLocation TEXT NOT NULL, AlbumArt BLOB DEFAULT NULL)";
        string createDirlocTable = "CREATE TABLE DIRECTORY(DIRLOC TEXT NOT NULL)";
        public string CreateMusicTable { get => createMusicTable; }
        public string CreateDirlocTable { get => createDirlocTable; }
    }
}
