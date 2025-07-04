using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class SettingsPanel : UserControl
    {
        public SettingsPanel(Point _location)
        {
            Location = _location;
            InitializeComponent();
        }

        public NumericUpDown numericUpDown1;
        public Button button1;

        private void InitializeComponent()
        {
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(17, 79);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(113, 207);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 1;
            button1.Text = "Confirm settings";
            button1.UseVisualStyleBackColor = true;
            // 
            // SettingsPanel
            // 
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Name = "SettingsPanel";
            Size = new Size(366, 334);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }
        public void ConfirmSettings(Control c, Point woth_panel_location)
        {
            //WOTHPanel new_woth_panel = new(woth_panel_location) { Goal_Count = numericUpDown1.Value };
            foreach (Control control in c.Controls)
            { 
                if (control is WOTHPanel old_woth_panel)
                {
                    old_woth_panel.Goal_Count = numericUpDown1.Value;
                    old_woth_panel.DeleteHintsAndStones(); 
                    old_woth_panel.GenerateHintsAndStones();
                }              
            }
            foreach (Control control in c.Controls)
            {
                if (control is AlwaysHints old_always_panel)
                {
                    old_always_panel.Dispose();
                }
            }   
            /*
            c.Controls.Add(new_woth_panel);
            new_woth_panel.GenerateHintsAndStones();
            AlwaysHints new_always_panel = new(new Point(new_woth_panel.Location.X, new_woth_panel.Size.Height + 1));
            c.Controls.Add(new_always_panel);
            new_always_panel.DrawPanel();
            new_woth_panel.BringToFront();
            new_always_panel.BringToFront(); 
            */
            Visible = false;
        }

    }
}
