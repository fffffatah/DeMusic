using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileIoOperation;
using System.Windows.Controls;

namespace DeMusic
{
    public partial class ControlAllPageComponent
    {
        //THIS METHOD IS FOR ADD BUTTON IN SETTING PAGE
        public void AddDirectory()
        {
            BrowseForDirectory browse = new BrowseForDirectory();
            ListBoxItem itm = new ListBoxItem();
            itm.Content = browse.FolderPath.SongFolderPath;
            settingPageObj.songDirectoryListbox.Items.Add(itm);
        }
    }
}
