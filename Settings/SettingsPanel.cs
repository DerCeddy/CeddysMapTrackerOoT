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
            Rainbow_Bridge_Requirements_ComboBox.TextChanged += (sender,e) => UpdateGoalRequirementCounter();
        }

        public NumericUpDown WotH_Hint_Counter;
        private NumericUpDown Sometimes_Hint_Counter;
        private NumericUpDown Sometimes_DualHint_Counter;
        public Button Load_Preset_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        public ComboBox Rainbow_Bridge_Requirements_ComboBox;
        public NumericUpDown Goal_Condition_Counter;
        public Label Goal_Condition_Counter_Text;
        public Button button1;

        private void InitializeComponent()
        {
            WotH_Hint_Counter = new NumericUpDown();
            button1 = new Button();
            Sometimes_Hint_Counter = new NumericUpDown();
            Sometimes_DualHint_Counter = new NumericUpDown();
            Load_Preset_Button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Rainbow_Bridge_Requirements_ComboBox = new ComboBox();
            Goal_Condition_Counter = new NumericUpDown();
            Goal_Condition_Counter_Text = new Label();
            ((System.ComponentModel.ISupportInitialize)WotH_Hint_Counter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_Hint_Counter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_DualHint_Counter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Goal_Condition_Counter).BeginInit();
            SuspendLayout();
            // 
            // WotH_Hint_Counter
            // 
            WotH_Hint_Counter.Location = new Point(333, 95);
            WotH_Hint_Counter.Name = "WotH_Hint_Counter";
            WotH_Hint_Counter.Size = new Size(41, 23);
            WotH_Hint_Counter.TabIndex = 0;
            WotH_Hint_Counter.TextAlign = HorizontalAlignment.Right;
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
            Sometimes_Hint_Counter.Location = new Point(333, 124);
            Sometimes_Hint_Counter.Name = "Sometimes_Hint_Counter";
            Sometimes_Hint_Counter.Size = new Size(41, 23);
            Sometimes_Hint_Counter.TabIndex = 2;
            Sometimes_Hint_Counter.TextAlign = HorizontalAlignment.Right;
            // 
            // Sometimes_DualHint_Counter
            // 
            Sometimes_DualHint_Counter.Location = new Point(333, 153);
            Sometimes_DualHint_Counter.Name = "Sometimes_DualHint_Counter";
            Sometimes_DualHint_Counter.Size = new Size(41, 23);
            Sometimes_DualHint_Counter.TabIndex = 3;
            Sometimes_DualHint_Counter.TextAlign = HorizontalAlignment.Right;
            // 
            // Load_Preset_Button
            // 
            Load_Preset_Button.Location = new Point(3, 17);
            Load_Preset_Button.Name = "Load_Preset_Button";
            Load_Preset_Button.Size = new Size(94, 23);
            Load_Preset_Button.TabIndex = 4;
            Load_Preset_Button.Text = "Load Preset";
            Load_Preset_Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(129, 240);
            label1.Name = "label1";
            label1.Size = new Size(245, 2);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(125, 97);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 6;
            label2.Text = "Number of Path Hints";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(125, 124);
            label3.Name = "label3";
            label3.Size = new Size(158, 15);
            label3.TabIndex = 7;
            label3.Text = "Number of Sometimes Hints";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(125, 153);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 8;
            label4.Text = "Number of Dual Hints";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Soldout;
            pictureBox1.Location = new Point(744, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(406, 40);
            label5.Name = "label5";
            label5.Size = new Size(2, 225);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(461, 21);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 11;
            label6.Text = "Goal Conditions";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(414, 97);
            label7.Name = "label7";
            label7.Size = new Size(161, 15);
            label7.TabIndex = 12;
            label7.Text = "Rainbow Bridge Requirement";
            // 
            // Rainbow_Bridge_Requirements_ComboBox
            // 
            Rainbow_Bridge_Requirements_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Rainbow_Bridge_Requirements_ComboBox.FormattingEnabled = true;
            Rainbow_Bridge_Requirements_ComboBox.Items.AddRange(new object[] { "Vanilla Requirements", "Spiritual Stones", "Medallions", "Dungeon Rewards" });
            Rainbow_Bridge_Requirements_ComboBox.Location = new Point(581, 89);
            Rainbow_Bridge_Requirements_ComboBox.Name = "Rainbow_Bridge_Requirements_ComboBox";
            Rainbow_Bridge_Requirements_ComboBox.Size = new Size(121, 23);
            Rainbow_Bridge_Requirements_ComboBox.TabIndex = 13;
            // 
            // Goal_Condition_Counter
            // 
            Goal_Condition_Counter.Location = new Point(666, 124);
            Goal_Condition_Counter.Name = "Goal_Condition_Counter";
            Goal_Condition_Counter.Size = new Size(35, 23);
            Goal_Condition_Counter.TabIndex = 14;
            // 
            // Goal_Condition_Counter_Text
            // 
            Goal_Condition_Counter_Text.AutoSize = true;
            Goal_Condition_Counter_Text.BackColor = Color.Transparent;
            Goal_Condition_Counter_Text.ForeColor = SystemColors.Control;
            Goal_Condition_Counter_Text.Location = new Point(414, 132);
            Goal_Condition_Counter_Text.Name = "Goal_Condition_Counter_Text";
            Goal_Condition_Counter_Text.Size = new Size(38, 15);
            Goal_Condition_Counter_Text.TabIndex = 15;
            Goal_Condition_Counter_Text.Text = "label8";
            // 
            // SettingsPanel
            // 
            BackColor = Color.Black;
            Controls.Add(Goal_Condition_Counter_Text);
            Controls.Add(Goal_Condition_Counter);
            Controls.Add(Rainbow_Bridge_Requirements_ComboBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Load_Preset_Button);
            Controls.Add(Sometimes_DualHint_Counter);
            Controls.Add(Sometimes_Hint_Counter);
            Controls.Add(button1);
            Controls.Add(WotH_Hint_Counter);
            Name = "SettingsPanel";
            Size = new Size(786, 468);
            ((System.ComponentModel.ISupportInitialize)WotH_Hint_Counter).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_Hint_Counter).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_DualHint_Counter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Goal_Condition_Counter).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
            foreach (Control control in c.Controls)
            {
                if (control is Maptracker maptracker)
                {
                    maptracker.Goalrequirement = Rainbow_Bridge_Requirements_ComboBox.SelectedItem.ToString();
                    maptracker.Medallions = Goal_Condition_Counter.Value;
                    maptracker.Stones = Goal_Condition_Counter.Value;
                    maptracker.DungeonRewards = Goal_Condition_Counter.Value;
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
        public void UpdateGoalRequirementCounter()
        {                    
            switch(Rainbow_Bridge_Requirements_ComboBox.Text)
            {            
                case "Vanilla Requirements":
                    Goal_Condition_Counter.Visible = false;
                    Goal_Condition_Counter_Text.Visible = false;
                    break;
                case "Medallions":
                    Goal_Condition_Counter.Visible = true;
                    Goal_Condition_Counter_Text.Visible = true;
                    Goal_Condition_Counter_Text.Text = "Medallions Required for Bridge:";
                    break;
                case "Spiritual Stones":
                    Goal_Condition_Counter.Visible = true;
                    Goal_Condition_Counter_Text.Visible = true;
                    Goal_Condition_Counter_Text.Text = "Stones Required for Bridge:";
                    break;
                case "Dungeon Rewards":
                    Goal_Condition_Counter.Visible = true;
                    Goal_Condition_Counter_Text.Visible = true;
                    Goal_Condition_Counter_Text.Text = "Dungeon Rewards Required for Bridge:";
                    break;
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
