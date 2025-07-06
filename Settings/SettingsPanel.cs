using Newtonsoft.Json;
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

        public NumericUpDown WotH_Hint_Counter;
        private NumericUpDown Sometimes_Hint_Counter;
        private NumericUpDown Sometimes_DualHint_Counter;
        public Button Load_Preset_Button;
        public Button button1;

        private void InitializeComponent()
        {
            WotH_Hint_Counter = new NumericUpDown();
            button1 = new Button();
            Sometimes_Hint_Counter = new NumericUpDown();
            Sometimes_DualHint_Counter = new NumericUpDown();
            Load_Preset_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)WotH_Hint_Counter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_Hint_Counter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_DualHint_Counter).BeginInit();
            SuspendLayout();
            // 
            // WotH_Hint_Counter
            // 
            WotH_Hint_Counter.Location = new Point(222, 86);
            WotH_Hint_Counter.Name = "WotH_Hint_Counter";
            WotH_Hint_Counter.Size = new Size(120, 23);
            WotH_Hint_Counter.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(198, 279);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 1;
            button1.Text = "Confirm settings";
            button1.UseVisualStyleBackColor = true;
            // 
            // Sometimes_Hint_Counter
            // 
            Sometimes_Hint_Counter.Location = new Point(222, 115);
            Sometimes_Hint_Counter.Name = "Sometimes_Hint_Counter";
            Sometimes_Hint_Counter.Size = new Size(120, 23);
            Sometimes_Hint_Counter.TabIndex = 2;
            // 
            // Sometimes_DualHint_Counter
            // 
            Sometimes_DualHint_Counter.Location = new Point(222, 144);
            Sometimes_DualHint_Counter.Name = "Sometimes_DualHint_Counter";
            Sometimes_DualHint_Counter.Size = new Size(120, 23);
            Sometimes_DualHint_Counter.TabIndex = 3;
            // 
            // Load_Preset_Button
            // 
            Load_Preset_Button.Location = new Point(35, 156);
            Load_Preset_Button.Name = "Load_Preset_Button";
            Load_Preset_Button.Size = new Size(94, 23);
            Load_Preset_Button.TabIndex = 4;
            Load_Preset_Button.Text = "Load Preset";
            Load_Preset_Button.UseVisualStyleBackColor = true;
            // 
            // SettingsPanel
            // 
            Controls.Add(Load_Preset_Button);
            Controls.Add(Sometimes_DualHint_Counter);
            Controls.Add(Sometimes_Hint_Counter);
            Controls.Add(button1);
            Controls.Add(WotH_Hint_Counter);
            Name = "SettingsPanel";
            Size = new Size(366, 334);
            ((System.ComponentModel.ISupportInitialize)WotH_Hint_Counter).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_Hint_Counter).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_DualHint_Counter).EndInit();
            ResumeLayout(false);
        }

        public void ConfirmSettings(Control c)
        {
            foreach (Control control in c.Controls)
            { 
                if (control is WOTHPanel old_woth_panel)
                {
                    old_woth_panel.Goal_Count = WotH_Hint_Counter.Value;
                    old_woth_panel.DeleteHintsAndStones(); 
                    old_woth_panel.GenerateHintsAndStones();
                }              
            }
            foreach (Control control in c.Controls)
            {
                if (control is AlwaysHints old_always_panel)
                {
                    old_always_panel.DeleteItems();
                    old_always_panel.DrawPanel();
                }
            }
            foreach (Control control in c.Controls)
            {
                if (control is SometimesHints sometimesHints)
                {
                    sometimesHints.Hint_Count = Sometimes_Hint_Counter.Value;
                    sometimesHints.Dual_Hint_Count = Sometimes_DualHint_Counter.Value;
                    sometimesHints.DeleteHintsAndStones();
                    sometimesHints.GenerateHintsAndStones();
                }
            }
            
            Visible = false;
        }
        public void LoadPreset(ItemPanel itemPanel, Form1 form, SometimesHints sometimes, AlwaysHints always, WOTHPanel wothpanel)
        {
            //Read json file
            StreamReader r = new("preset.json");
            string json = r.ReadToEnd();
            JsonConvert.PopulateObject(json, form);
            //Update item
            foreach (Control c in itemPanel.Controls)
            {
                if (c != null && c is Item i)
                {
                    i.UpdateItemState();
                }
            }
            //Update WotH hint panel
            wothpanel.DeleteHintsAndStones();
            wothpanel.GenerateHintsAndStones();
            //Update always hint panel
            always.DeleteItems();
            always.DrawPanel();
            //Update sometimes hint panel
            sometimes.DeleteHintsAndStones();
            sometimes.GenerateHintsAndStones();
            Visible = false;
        }

    }
}
