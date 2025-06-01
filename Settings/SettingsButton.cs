using OoTItemTrackerNew.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    public class SettingsButton : Button
    {
        public SettingsButton(Point _location)
        {
            Location = _location;
            Size = new Size(64,64);
            Image = Resources.settingsbutton;          
        }
        public void ClickEvent(SettingsPanel settingspanel)
        {
            settingspanel.Visible = true;
            settingspanel.BringToFront();
        }
    }
}
