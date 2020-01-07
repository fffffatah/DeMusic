using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileIoOperation;
using System.Windows.Controls;
using System.IO;

namespace DeMusic
{
    public partial class ControlAllPageComponent
    {
        BrowseForDirectory browse;
        static HashSet<string> dirList = new HashSet<string>();
        ListBoxItem itm;
        //THIS METHOD IS FOR ADD BUTTON IN SETTING PAGE
        public void AddDirectory()
        {           
            browse = new BrowseForDirectory();
            if (browse.FolderPath.SongFolderPath != null)
            {
                settingPageObj.saveSettingButton.IsEnabled = true;
            }
            if(dirList.Add(browse.FolderPath.SongFolderPath))
            {
                itm = new ListBoxItem();
                itm.Content = browse.FolderPath.SongFolderPath;
                settingPageObj.songDirectoryListbox.Items.Add(itm);
            }
        }
        //THIS METHOD REMOVES DIRECTORIES FROM BOTH DATABASE AND THE ABOVE HASHSET
        public void RemoveDirectory()
        {
            //TO-DO
        }
        //THIS METHOD SENDS THE DATA TO FILE IO ASSEMBLY WHICH THEN INSERTS THE DIRECTORIES INTO DB
        public void SaveDirectory()
        {
            //TO-DO
        }
    }
}
