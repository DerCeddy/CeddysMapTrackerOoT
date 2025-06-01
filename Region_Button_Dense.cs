using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class Region_Button_Dense : Button
    {
        public string _name;
        public Region_Button_Dense()
        {
            FlatStyle = FlatStyle.Flat;       
            Size = new Size(24, 24);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.Black;
            ForeColor = Color.Transparent;
            BackColor = Color.Red;
            Font = new Font("Arial",9, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        public void ButtonClick(MouseEventArgs e, Region_Panel region_panel)
        {
            switch (e.Button)
            {              
                case MouseButtons.Right:                 
                    break;
                case MouseButtons.Middle:
                    int ChecksChecked = 0;
                    int MaxChecks = 0;
                    foreach (Control c in region_panel.Controls)
                    {
                        if (c is CheckBox cb)
                        {
                            MaxChecks++;
                            if (cb.Checked)
                            {
                                ChecksChecked++;
                            }
                        }
                    }
                    if (MaxChecks > ChecksChecked)
                    {
                        foreach (Control c in region_panel.Controls)
                        {
                            if (c is CheckBox cb)
                            {
                                cb.Checked = true;
                            }
                        }
                    }
                    else
                    {
                        foreach (Control c in region_panel.Controls)
                        {
                            if (c is CheckBox cb)
                            {
                                cb.Checked = false;
                            }
                        }
                    }                  
                    break;
            }
        }                   
    }
}
