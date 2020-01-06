using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using FileIoOperation;
using System.Windows.Controls;

namespace DeMusic
{
    public partial class ControlAllPageComponent
    {
        //PAGE OBJECTS IN THIS ASSEMBLY
        static MainPage mainPageObj;
        static AboutPage aboutPageObj;
        static SettingPage settingPageObj;
        //OVERLOADED CONSTRUCTORS
        public ControlAllPageComponent()
        {

        }
        public ControlAllPageComponent(MainPage obj)
        {
            if (mainPageObj == null)
            {
                mainPageObj = obj;
            }
        }
        public ControlAllPageComponent(AboutPage obj)
        {
            if (aboutPageObj == null)
            {
                aboutPageObj = obj;
            }
        }
        public ControlAllPageComponent(SettingPage obj)
        {
            if (settingPageObj == null)
            {
                settingPageObj = obj;
            }
        }
    }
}
