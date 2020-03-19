using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace DeMusic
{
    public partial class ControlAllPageComponent
    {
        //THIS METHOD CHECKS FOR THE DB FILE IN APPDATA
        public bool CheckData()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\DeMusic\songdatabase.db"))
            {
                mainPageObj.lonelyPageFrame.Visibility = Visibility.Hidden;
                ChangeButtonState(false);
                return true;
            }
            else
            {
                mainPageObj.lonelyPageFrame.Visibility = Visibility.Visible;
                ChangeButtonState(true);
                return false;
            }
        }
    }
}
