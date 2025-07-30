using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CeddyMapTracker
{
    public class RegionButton : Button
    {
        public string RegionName;
        public RegionButton()
        {
            BackColor = Color.Transparent;
            Text = "";
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = BackColor;
            FlatAppearance.MouseOverBackColor = BackColor;         
        }
        public void ButtonClick(MouseEventArgs e, Panel control, List<Check> listchecks)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:  
                    /*
                    foreach (Control c in control.Controls)
                    {
                        if (c is TextBox tb)
                        {
                            if (tb.Text == string.Empty)
                            {
                                tb.Text = RegionName;
                                return;
                            }
                        }
                    }
                    */
                    break;
                case MouseButtons.Middle:
                    int ChecksChecked = 0;
                    int MaxChecks = 0;
                    foreach (Check cb in listchecks)
                    {                        
                        MaxChecks++;
                        if (cb.Done)
                        {
                            ChecksChecked++;
                        }                       
                    }
                    if (MaxChecks > ChecksChecked)
                    {
                        foreach (Check cb in listchecks)
                        {                         
                            cb.Done = false;                           
                            cb.ChangeColor();                           
                        }
                    }
                    else
                    {
                        foreach (Check cb in listchecks)
                        {                          
                            cb.Done = true;
                            cb.ChangeColor();                           
                        }
                    }
                    break;
            }
        }
    }   
}
