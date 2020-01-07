using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDatabaseOperation
{
    public class DeQueries
    {
        string createMusicTable = "CREATE TABLE MUSIC(SongFileName TEXT NOT NULL , SongTitle TEXT DEFAULT 'Unknown Title' NOT NULL , AlbumArtist TEXT DEFAULT 'Unknown Artist' NOT NULL, ContributingArtist TEXT DEFAULT 'Unknown Artist' NOT NULL , YearReleased TEXT DEFAULT 'Unknown Year' NOT NULL, FileLocation TEXT UNIQUE NOT NULL, AlbumArt BLOB DEFAULT NULL, DateAdded DATE DEFAULT (DATETIME('NOW','LOCALTIME')))";
        string createDirlocTable = "CREATE TABLE DIRECTORY(DIRLOC TEXT UNIQUE NOT NULL)";
        string createPlayListTabel = "CREATE TABLE PLAYLIST(FileLocation TEXT UNIQUE NOT NULL)";
        public string CreateMusicTable { get => createMusicTable; }
        public string CreateDirlocTable { get => createDirlocTable; }
        public string CreatePlayListTable { get => createPlayListTabel; }
    }
}