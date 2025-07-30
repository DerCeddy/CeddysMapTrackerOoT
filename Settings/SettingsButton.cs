using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CeddyMapTracker
{
    public class SettingsButton : Button
    {
        public SettingsButton(Point _location)
        {
            Location = _location;
            Size = new Size(64,64);
            Image = Resources.settingsbutton;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }
        public void ClickEvent(SettingsPanel settingspanel)
        {
            settingspanel.Visible = true;
            settingspanel.BringToFront();
        }
    }
}
