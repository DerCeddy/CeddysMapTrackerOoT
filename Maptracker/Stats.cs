using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class Stats : Panel
    {
        public int ChecksRemaining = 0;
        public int ChecksDone = 0;
        public int ChecksAvailable = 0;
        public int SkulltulaAvailable = 0;
        public Label checksAvailable_Label = new() { Location = new Point(100, 0), Size = new Size(50, 50), BackColor = Color.Lime, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), ForeColor = Color.White };
        public Label checksRemaining_Label = new() { Location = new Point(50, 0), Size = new Size(50, 50), BackColor = Color.Gold, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), ForeColor = Color.White };
        public Label checksDone_Label = new() { Location = new Point(0, 0), Size = new Size(50, 50), BackColor = Color.Red, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), ForeColor = Color.White };
        public Label Skulltula_Label = new() { Location = new Point(150, 0), Size = new Size(50, 50), TextAlign = ContentAlignment.BottomCenter, Image = Resources.skulltula, Font = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel), ForeColor = Color.White }; 

        public Stats(Point _location)
        {
            Location = _location;
            Size = new Size(200,100);
            Label checksAvailable_Info = new() { Location = new Point(100, 50), Size = new Size(50,20), Text = "Available", ForeColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Pixel) };
            Label checksRemaining_Info = new() { Location = new Point(50, 50), Size = new Size(50, 20), Text = "Remaining", ForeColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Pixel) };
            Label checksDone_Info = new() { Location = new Point(0, 50), Size = new Size(50, 20), Text = "Done", ForeColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Pixel) };
            Label Skulltula_Info = new() { Location = new Point(150, 50), Size = new Size(50, 20), Text = "Available", ForeColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Pixel) };
            //Add counters to stat panel
            Controls.Add(checksRemaining_Label);
            Controls.Add(checksAvailable_Label);   
            Controls.Add(checksDone_Label);
            Controls.Add(Skulltula_Label);
            //Add info labels to stat panel
            Controls.Add(checksAvailable_Info);
            Controls.Add(checksRemaining_Info);
            Controls.Add(checksDone_Info);
            Controls.Add(Skulltula_Info);
        }  
        public void UpdateChecksAvailable()
        {          
            checksAvailable_Label.Text = ChecksAvailable.ToString(); 
            checksRemaining_Label.Text = ChecksRemaining.ToString();
            checksDone_Label.Text = ChecksDone.ToString();
            Skulltula_Label.Text = SkulltulaAvailable.ToString();
        }
    }
}
