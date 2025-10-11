using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CeddyMapTracker
{
    public class GoalTextBox : TextBox
    {
        public GoalTextBox(Point _location)
        {
            Size = new Size(129, 24);
            Font = new Font("Arial",12, GraphicsUnit.Pixel);
            //TextAlign = HorizontalAlignment.Left;
            BackColor = Color.DeepSkyBlue;
            Location = _location;
            //BorderStyle = BorderStyle.None;
            MaximumSize = new Size(129,24);
            //Multiline = true;
            //Location = new Point(26, (i * 30) + 20);
            MouseDown += (sender, e) => DeleteString();
        }
        public void DeleteString()
        {
            Text = string.Empty;
        }
    }
}
