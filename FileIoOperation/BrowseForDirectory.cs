using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FileIoOperation
{
    public class BrowseForDirectory
    {

        FolderPaths folderPath;
        public FolderPaths FolderPath { get => this.folderPath; }
        public BrowseForDirectory()
        {
            folderPath = new FolderPaths();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath.SongFolderPath = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
