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
        public void ButtonClick(MouseEventArgs e, List<Region_Panel_Check> Checks, List<ShopPanelCheck> ShopChecks)
        {
            switch (e.Button)
            {              
                case MouseButtons.Right:                 
                    break;
                case MouseButtons.Middle:
                    int ChecksChecked = 0;
                    int MaxChecks = 0;
                    foreach (Region_Panel_Check rpc in Checks)
                    {            
                        MaxChecks++;
                        if (rpc.Checked)
                        {
                            ChecksChecked++;
                        }
                    }
                    foreach (ShopPanelCheck spc in ShopChecks)
                    {
                        MaxChecks++;
                        if (spc.Checked)
                        {
                            ChecksChecked++;
                        }
                    }
                    if (MaxChecks > ChecksChecked)
                    {
                        foreach (Region_Panel_Check rpc in Checks)
                        {
                            rpc.Checked = true;
                            rpc.UserClickedCheck = true;
                        }
                        foreach (ShopPanelCheck spc in ShopChecks)
                        {
                            spc.Checked = true;
                        }
                    }
                    else
                    {
                        foreach (Region_Panel_Check rpc in Checks)
                        {
                            rpc.Checked = false;
                            rpc.UserClickedCheck = false;
                        }
                        foreach (ShopPanelCheck spc in ShopChecks)
                        {
                            spc.Checked = false;
                        }
                    }                  
                    break;
            }
        }                   
    }
}
