using CeddyMapTracker.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CeddyMapTracker
{
    public class SettingsPanel : UserControl
    {
        public int State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                OnValueChanged(null);
            }
        }
        private int _state;
        public SettingsPanel(Point _location)
        {
            Location = _location;
            InitializeComponent();
            UpdateGoalRequirementCounter();
            Rainbow_Bridge_Requirements_ComboBox.TextChanged += (sender, e) => UpdateGoalRequirementCounter();
            string[] files = Directory.GetFiles("Presets");
            Font = new Font("Arial", 12, GraphicsUnit.Pixel);
            foreach (string file in files)
            {
                comboBox1.Items.Add(Path.GetFileName(file));
            }
            changeStyleButton1.Image = (Bitmap)Image.FromFile("Textures/Settings/N64.png");
            foreach (Control c in Controls)
            {
                if(c != null && c is ShuffleButton ShuffleButton)
                {
                    ShuffleButton.ValueChanged += (sender, e) => State = 1;
                }
            }
            //Assign pictures to settings always buttons
            SongOfTime_Button.Picture.Image = Resources.song_of_time_32x40;
            Nocturne_Button.Picture.Image = Resources.nocturne_32x40;
            BigGoron_Button.Picture.Image = Resources.biggoron_32x32;
            Frogs2_Button.Picture.Image = Resources.Frogs2;
            SkullMask_Button.Picture.Image = Resources.OoT3D_Skull_Mask_Icon;
            Skulls20_Button.Picture.Image = Resources.Skulltulas20;
            Skulls30_Button.Picture.Image = Resources.Skulltulas30;
            Skulls40_Button.Picture.Image = Resources.Skulltulas40;
            Skulls50_Button.Picture.Image = Resources.Skulltulas50;
            Trials_Button.Picture.Image = Resources.trials;
            CastleFairies_Button.Picture.Image = Resources.Castle_Fairy_Dual;
            FrogsDual_Button.Picture.Image = Resources.Frogs_Dual;
            IceDual_Button.Picture.Image = Resources.IceCavern;

        }

        public NumericUpDown WotH_Hint_Counter;
        private NumericUpDown Sometimes_Hint_Counter;
        private NumericUpDown Sometimes_DualHint_Counter;
        public Button Load_Preset_Button;
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
        private Label label8;
        public ComboBox comboBox1;
        public ChangeStyleButton changeStyleButton1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label1;
        private Label label12;
        private Label label13;
        public ShuffleButton ExpensiveMerchants;
        public ShuffleButton ShopShuffle;
        private Label label14;
        private NumericUpDown Important_Hint_Counter;
        private Label label15;
        private SettingsAlwaysHint SongOfTime_Button;
        private SettingsAlwaysHint Nocturne_Button;
        private SettingsAlwaysHint BigGoron_Button;
        private SettingsAlwaysHint Frogs2_Button;
        private SettingsAlwaysHint SkullMask_Button;
        private SettingsAlwaysHint Skulls20_Button;
        private SettingsAlwaysHint Skulls30_Button;
        private SettingsAlwaysHint Skulls40_Button;
        private SettingsAlwaysHint Skulls50_Button;
        private SettingsAlwaysHint IceDual_Button;
        private SettingsAlwaysHint Trials_Button;
        private SettingsAlwaysHint CastleFairies_Button;
        private SettingsAlwaysHint FrogsDual_Button;
        private Label label16;
        public ShuffleButton DungeonERShuffle;
        private Label label17;
        private Label label18;
        public ShuffleButton BlueFireArrows;
        public Button button1;

        private void InitializeComponent()
        {
            WotH_Hint_Counter = new NumericUpDown();
            button1 = new Button();
            Sometimes_Hint_Counter = new NumericUpDown();
            Sometimes_DualHint_Counter = new NumericUpDown();
            Load_Preset_Button = new Button();
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
            label8 = new Label();
            comboBox1 = new ComboBox();
            changeStyleButton1 = new ChangeStyleButton();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label1 = new Label();
            label12 = new Label();
            label13 = new Label();
            ExpensiveMerchants = new ShuffleButton();
            ShopShuffle = new ShuffleButton();
            label14 = new Label();
            Important_Hint_Counter = new NumericUpDown();
            label15 = new Label();
            SongOfTime_Button = new SettingsAlwaysHint();
            Nocturne_Button = new SettingsAlwaysHint();
            BigGoron_Button = new SettingsAlwaysHint();
            Frogs2_Button = new SettingsAlwaysHint();
            SkullMask_Button = new SettingsAlwaysHint();
            Skulls20_Button = new SettingsAlwaysHint();
            Skulls30_Button = new SettingsAlwaysHint();
            Skulls40_Button = new SettingsAlwaysHint();
            Skulls50_Button = new SettingsAlwaysHint();
            IceDual_Button = new SettingsAlwaysHint();
            Trials_Button = new SettingsAlwaysHint();
            CastleFairies_Button = new SettingsAlwaysHint();
            FrogsDual_Button = new SettingsAlwaysHint();
            label16 = new Label();
            DungeonERShuffle = new ShuffleButton();
            label17 = new Label();
            label18 = new Label();
            BlueFireArrows = new ShuffleButton();
            ((System.ComponentModel.ISupportInitialize)WotH_Hint_Counter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_Hint_Counter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_DualHint_Counter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Goal_Condition_Counter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changeStyleButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Important_Hint_Counter).BeginInit();
            SuspendLayout();
            // 
            // WotH_Hint_Counter
            // 
            WotH_Hint_Counter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            WotH_Hint_Counter.Location = new Point(361, 94);
            WotH_Hint_Counter.Name = "WotH_Hint_Counter";
            WotH_Hint_Counter.Size = new Size(41, 23);
            WotH_Hint_Counter.TabIndex = 0;
            WotH_Hint_Counter.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            button1.Location = new Point(316, 417);
            button1.Name = "button1";
            button1.Size = new Size(236, 23);
            button1.TabIndex = 1;
            button1.Text = "Confirm Hint Layout and Goal Conditions";
            button1.UseVisualStyleBackColor = true;
            // 
            // Sometimes_Hint_Counter
            // 
            Sometimes_Hint_Counter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Sometimes_Hint_Counter.Location = new Point(361, 123);
            Sometimes_Hint_Counter.Name = "Sometimes_Hint_Counter";
            Sometimes_Hint_Counter.Size = new Size(41, 23);
            Sometimes_Hint_Counter.TabIndex = 2;
            Sometimes_Hint_Counter.TextAlign = HorizontalAlignment.Right;
            // 
            // Sometimes_DualHint_Counter
            // 
            Sometimes_DualHint_Counter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Sometimes_DualHint_Counter.Location = new Point(361, 152);
            Sometimes_DualHint_Counter.Name = "Sometimes_DualHint_Counter";
            Sometimes_DualHint_Counter.Size = new Size(41, 23);
            Sometimes_DualHint_Counter.TabIndex = 3;
            Sometimes_DualHint_Counter.TextAlign = HorizontalAlignment.Right;
            // 
            // Load_Preset_Button
            // 
            Load_Preset_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Load_Preset_Button.Location = new Point(21, 206);
            Load_Preset_Button.Name = "Load_Preset_Button";
            Load_Preset_Button.Size = new Size(94, 23);
            Load_Preset_Button.TabIndex = 4;
            Load_Preset_Button.Text = "Load Preset";
            Load_Preset_Button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(153, 98);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 6;
            label2.Text = "Number of Path Hints";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(153, 127);
            label3.Name = "label3";
            label3.Size = new Size(158, 15);
            label3.TabIndex = 7;
            label3.Text = "Number of Sometimes Hints";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(153, 156);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 8;
            label4.Text = "Number of Dual Hints";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Soldout;
            pictureBox1.Location = new Point(1548, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(434, 60);
            label5.Name = "label5";
            label5.Size = new Size(2, 310);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(573, 41);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 11;
            label6.Text = "Goal Conditions";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(442, 98);
            label7.Name = "label7";
            label7.Size = new Size(161, 15);
            label7.TabIndex = 12;
            label7.Text = "Rainbow Bridge Requirement";
            // 
            // Rainbow_Bridge_Requirements_ComboBox
            // 
            Rainbow_Bridge_Requirements_ComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Rainbow_Bridge_Requirements_ComboBox.FormattingEnabled = true;
            Rainbow_Bridge_Requirements_ComboBox.Items.AddRange(new object[] { "Vanilla", "Spiritual Stones", "Medallions", "Dungeon Rewards" });
            Rainbow_Bridge_Requirements_ComboBox.Location = new Point(640, 94);
            Rainbow_Bridge_Requirements_ComboBox.Name = "Rainbow_Bridge_Requirements_ComboBox";
            Rainbow_Bridge_Requirements_ComboBox.Size = new Size(147, 23);
            Rainbow_Bridge_Requirements_ComboBox.TabIndex = 13;
            Rainbow_Bridge_Requirements_ComboBox.Text = "Vanilla";
            // 
            // Goal_Condition_Counter
            // 
            Goal_Condition_Counter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Goal_Condition_Counter.Location = new Point(752, 123);
            Goal_Condition_Counter.Name = "Goal_Condition_Counter";
            Goal_Condition_Counter.Size = new Size(35, 23);
            Goal_Condition_Counter.TabIndex = 14;
            // 
            // Goal_Condition_Counter_Text
            // 
            Goal_Condition_Counter_Text.AutoSize = true;
            Goal_Condition_Counter_Text.BackColor = Color.Transparent;
            Goal_Condition_Counter_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Goal_Condition_Counter_Text.ForeColor = SystemColors.Control;
            Goal_Condition_Counter_Text.Location = new Point(442, 127);
            Goal_Condition_Counter_Text.Name = "Goal_Condition_Counter_Text";
            Goal_Condition_Counter_Text.Size = new Size(38, 15);
            Goal_Condition_Counter_Text.TabIndex = 15;
            Goal_Condition_Counter_Text.Text = "label8";
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(145, 60);
            label8.Name = "label8";
            label8.Size = new Size(2, 310);
            label8.TabIndex = 16;
            label8.Text = "label8";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 20);
            comboBox1.TabIndex = 17;
            // 
            // changeStyleButton1
            // 
            changeStyleButton1.BackColor = Color.White;
            changeStyleButton1.Location = new Point(1489, 78);
            changeStyleButton1.Name = "changeStyleButton1";
            changeStyleButton1.Size = new Size(48, 48);
            changeStyleButton1.SizeMode = PictureBoxSizeMode.StretchImage;
            changeStyleButton1.TabIndex = 18;
            changeStyleButton1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label9.ForeColor = Color.White;
            label9.Location = new Point(45, 41);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 19;
            label9.Text = "Presets";
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(793, 60);
            label10.Name = "label10";
            label10.Size = new Size(2, 310);
            label10.TabIndex = 20;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label11.ForeColor = Color.White;
            label11.Location = new Point(251, 41);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 21;
            label11.Text = "Hint Layout";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1453, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 22;
            label1.Text = "Cosmetic";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1425, 96);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 23;
            label12.Text = "Icon Style";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(904, 41);
            label13.Name = "label13";
            label13.Size = new Size(89, 15);
            label13.TabIndex = 24;
            label13.Text = "Shuffle Options";
            // 
            // ExpensiveMerchants
            // 
            ExpensiveMerchants.AutoCheck = false;
            ExpensiveMerchants.AutoSize = true;
            ExpensiveMerchants.BackColor = Color.Black;
            ExpensiveMerchants.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            ExpensiveMerchants.ForeColor = Color.White;
            ExpensiveMerchants.Location = new Point(801, 95);
            ExpensiveMerchants.Name = "ExpensiveMerchants";
            ExpensiveMerchants.Size = new Size(176, 19);
            ExpensiveMerchants.State = false;
            ExpensiveMerchants.TabIndex = 25;
            ExpensiveMerchants.Text = "Shuffle Expensive Merchants";
            ExpensiveMerchants.UseVisualStyleBackColor = false;
            // 
            // ShopShuffle
            // 
            ShopShuffle.AutoCheck = false;
            ShopShuffle.AutoSize = true;
            ShopShuffle.BackColor = Color.Black;
            ShopShuffle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            ShopShuffle.ForeColor = Color.White;
            ShopShuffle.Location = new Point(801, 119);
            ShopShuffle.Name = "ShopShuffle";
            ShopShuffle.Size = new Size(98, 19);
            ShopShuffle.State = false;
            ShopShuffle.TabIndex = 26;
            ShopShuffle.Text = "Shuffle Shops";
            ShopShuffle.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(153, 185);
            label14.Name = "label14";
            label14.Size = new Size(188, 15);
            label14.TabIndex = 27;
            label14.Text = "Number of Important Check Hints";
            // 
            // Important_Hint_Counter
            // 
            Important_Hint_Counter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Important_Hint_Counter.Location = new Point(361, 181);
            Important_Hint_Counter.Name = "Important_Hint_Counter";
            Important_Hint_Counter.Size = new Size(41, 23);
            Important_Hint_Counter.TabIndex = 28;
            Important_Hint_Counter.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Location = new Point(1113, 60);
            label15.Name = "label15";
            label15.Size = new Size(2, 310);
            label15.TabIndex = 29;
            label15.Text = "label15";
            // 
            // SongOfTime_Button
            // 
            SongOfTime_Button.Location = new Point(153, 232);
            SongOfTime_Button.Name = "SongOfTime_Button";
            SongOfTime_Button.Size = new Size(48, 32);
            SongOfTime_Button.TabIndex = 30;
            // 
            // Nocturne_Button
            // 
            Nocturne_Button.Location = new Point(207, 232);
            Nocturne_Button.Name = "Nocturne_Button";
            Nocturne_Button.Size = new Size(48, 32);
            Nocturne_Button.TabIndex = 31;
            // 
            // BigGoron_Button
            // 
            BigGoron_Button.Location = new Point(261, 232);
            BigGoron_Button.Name = "BigGoron_Button";
            BigGoron_Button.Size = new Size(48, 32);
            BigGoron_Button.TabIndex = 32;
            // 
            // Frogs2_Button
            // 
            Frogs2_Button.Location = new Point(315, 232);
            Frogs2_Button.Name = "Frogs2_Button";
            Frogs2_Button.Size = new Size(48, 32);
            Frogs2_Button.TabIndex = 33;
            // 
            // SkullMask_Button
            // 
            SkullMask_Button.Location = new Point(369, 232);
            SkullMask_Button.Name = "SkullMask_Button";
            SkullMask_Button.Size = new Size(48, 32);
            SkullMask_Button.TabIndex = 34;
            // 
            // Skulls20_Button
            // 
            Skulls20_Button.Location = new Point(153, 308);
            Skulls20_Button.Name = "Skulls20_Button";
            Skulls20_Button.Size = new Size(48, 32);
            Skulls20_Button.TabIndex = 35;
            // 
            // Skulls30_Button
            // 
            Skulls30_Button.Location = new Point(207, 308);
            Skulls30_Button.Name = "Skulls30_Button";
            Skulls30_Button.Size = new Size(48, 32);
            Skulls30_Button.TabIndex = 36;
            // 
            // Skulls40_Button
            // 
            Skulls40_Button.Location = new Point(261, 308);
            Skulls40_Button.Name = "Skulls40_Button";
            Skulls40_Button.Size = new Size(48, 32);
            Skulls40_Button.TabIndex = 37;
            // 
            // Skulls50_Button
            // 
            Skulls50_Button.Location = new Point(315, 308);
            Skulls50_Button.Name = "Skulls50_Button";
            Skulls50_Button.Size = new Size(48, 32);
            Skulls50_Button.TabIndex = 38;
            // 
            // IceDual_Button
            // 
            IceDual_Button.Location = new Point(153, 270);
            IceDual_Button.Name = "IceDual_Button";
            IceDual_Button.Size = new Size(48, 32);
            IceDual_Button.TabIndex = 39;
            // 
            // Trials_Button
            // 
            Trials_Button.Location = new Point(207, 270);
            Trials_Button.Name = "Trials_Button";
            Trials_Button.Size = new Size(48, 32);
            Trials_Button.TabIndex = 40;
            // 
            // CastleFairies_Button
            // 
            CastleFairies_Button.Location = new Point(261, 270);
            CastleFairies_Button.Name = "CastleFairies_Button";
            CastleFairies_Button.Size = new Size(48, 32);
            CastleFairies_Button.TabIndex = 41;
            // 
            // FrogsDual_Button
            // 
            FrogsDual_Button.Location = new Point(315, 270);
            FrogsDual_Button.Name = "FrogsDual_Button";
            FrogsDual_Button.Size = new Size(48, 32);
            FrogsDual_Button.TabIndex = 42;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(153, 214);
            label16.Name = "label16";
            label16.Size = new Size(75, 15);
            label16.TabIndex = 43;
            label16.Text = "Always Hints";
            // 
            // DungeonERShuffle
            // 
            DungeonERShuffle.AutoCheck = false;
            DungeonERShuffle.AutoSize = true;
            DungeonERShuffle.BackColor = Color.Black;
            DungeonERShuffle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            DungeonERShuffle.ForeColor = Color.White;
            DungeonERShuffle.Location = new Point(801, 144);
            DungeonERShuffle.Name = "DungeonERShuffle";
            DungeonERShuffle.Size = new Size(169, 19);
            DungeonERShuffle.State = false;
            DungeonERShuffle.TabIndex = 44;
            DungeonERShuffle.Text = "Shuffle Dungeon Entrances";
            DungeonERShuffle.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Location = new Point(1417, 60);
            label17.Name = "label17";
            label17.Size = new Size(2, 310);
            label17.TabIndex = 45;
            label17.Text = "label17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(1223, 41);
            label18.Name = "label18";
            label18.Size = new Size(81, 15);
            label18.TabIndex = 46;
            label18.Text = "Logic Settings";
            // 
            // BlueFireArrows
            // 
            BlueFireArrows.AutoCheck = false;
            BlueFireArrows.AutoSize = true;
            BlueFireArrows.BackColor = Color.Black;
            BlueFireArrows.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            BlueFireArrows.ForeColor = Color.White;
            BlueFireArrows.Location = new Point(1121, 94);
            BlueFireArrows.Name = "BlueFireArrows";
            BlueFireArrows.Size = new Size(111, 19);
            BlueFireArrows.State = false;
            BlueFireArrows.TabIndex = 47;
            BlueFireArrows.Text = "Blue Fire Arrows";
            BlueFireArrows.UseVisualStyleBackColor = false;
            // 
            // SettingsPanel
            // 
            BackColor = Color.Black;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(BlueFireArrows);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(DungeonERShuffle);
            Controls.Add(label16);
            Controls.Add(FrogsDual_Button);
            Controls.Add(CastleFairies_Button);
            Controls.Add(Trials_Button);
            Controls.Add(IceDual_Button);
            Controls.Add(Skulls50_Button);
            Controls.Add(Skulls40_Button);
            Controls.Add(Skulls30_Button);
            Controls.Add(Skulls20_Button);
            Controls.Add(SkullMask_Button);
            Controls.Add(Frogs2_Button);
            Controls.Add(BigGoron_Button);
            Controls.Add(Nocturne_Button);
            Controls.Add(SongOfTime_Button);
            Controls.Add(label15);
            Controls.Add(Important_Hint_Counter);
            Controls.Add(label14);
            Controls.Add(ShopShuffle);
            Controls.Add(ExpensiveMerchants);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(changeStyleButton1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
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
            Controls.Add(Load_Preset_Button);
            Controls.Add(Sometimes_DualHint_Counter);
            Controls.Add(Sometimes_Hint_Counter);
            Controls.Add(button1);
            Controls.Add(WotH_Hint_Counter);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            Name = "SettingsPanel";
            Size = new Size(1596, 747);
            Load += SettingsPanel_Load;
            ((System.ComponentModel.ISupportInitialize)WotH_Hint_Counter).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_Hint_Counter).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sometimes_DualHint_Counter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Goal_Condition_Counter).EndInit();
            ((System.ComponentModel.ISupportInitialize)changeStyleButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Important_Hint_Counter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void ConfirmSettings(Form1 Form)
        { 
            //Change WotH Panel
            Form.WotHPanel.Goal_Count = WotH_Hint_Counter.Value;
            Form.WotHPanel.DeleteHintsAndStones();
            Form.WotHPanel.GenerateHintsAndStones();
            //Change Always Hints Panel
            GiveSettingValuesToAlwaysPanel(Form);
            Form.AlwaysHints.DeleteItems();
            Form.AlwaysHints.DrawPanel();  
            //Chagne Sometimes Hints Panel          
            Form.SometimesHints.Hint_Count = Sometimes_Hint_Counter.Value;
            Form.SometimesHints.Dual_Hint_Count = Sometimes_DualHint_Counter.Value;
            Form.SometimesHints.DeleteHintsAndStones();
            Form.SometimesHints.GenerateHintsAndStones();   
            //Change Maptracker Goal Conditions                   
            Form.MapTracker.GoalRequirement = Rainbow_Bridge_Requirements_ComboBox.SelectedItem.ToString();
            Form.MapTracker.Medallions = Goal_Condition_Counter.Value;
            Form.MapTracker.Stones = Goal_Condition_Counter.Value;
            Form.MapTracker.DungeonRewards = Goal_Condition_Counter.Value;
            //Change Important Hint Count
            Form.ImportantHint.Goal_Count = Important_Hint_Counter.Value;
            Form.ImportantHint.DeleteHints();
            Form.ImportantHint.GenerateHints();
            Visible = false;
        }
        public void LoadPreset(ItemPanel itemPanel, Form1 form, SometimesHintsPanel sometimes, AlwaysHintsPanel always, WOTHPanel wothpanel, Maptracker MapTracker)
        {
            //Reset Item states
            foreach (Control c in itemPanel.Controls)
            {
                if (c != null && c is Item i)
                {
                    i.State = 0;
                }
            }
            //Reset extra checks
            MapTracker.ExpensiveMerchantShuffle = false;
            MapTracker.ShopShuffle = false;
            //Reset sometimes panel
            //sometimes.gossipStones.Clear();
            //sometimes.comboBoxes.Clear();
            //Read json file
            StreamReader r = new($"Presets/{comboBox1.Text}");
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
            //Update checks
            foreach (Control c in MapTracker.Controls)
            {
                if (c != null && c is Check check)
                {
                    check.UpdateColor();
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
            form.AssignFunctionsToGossipstonesInSometimesPanel(form.Stats);
            //Update Important Hint Panel
            form.ImportantHint.DeleteHints();
            form.ImportantHint.GenerateHints();           
            //int test = 0;
            //test = itemPanel.Starting_Items[0].Length;
            Visible = false;
        }
        public void UpdateGoalRequirementCounter()
        {
            switch (Rainbow_Bridge_Requirements_ComboBox.Text)
            {
                case "Vanilla":
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
        public void GiveSettingValuesToAlwaysPanel(Form1 Form)
        {
            Form.AlwaysHints.SongOfTime.Active = SongOfTime_Button.CheckBox.Checked;
            Form.AlwaysHints.Nocturne.Active = Nocturne_Button.CheckBox.Checked;
            Form.AlwaysHints.BigGoron.Active = BigGoron_Button.CheckBox.Checked;
            Form.AlwaysHints.Frogs2.Active = Frogs2_Button.CheckBox.Checked;
            Form.AlwaysHints.SkullMask.Active = SkullMask_Button.CheckBox.Checked;
            Form.AlwaysHints.Trials.Active = Trials_Button.CheckBox.Checked;
            Form.AlwaysHints.Skulls20.Active = Skulls20_Button.CheckBox.Checked;
            Form.AlwaysHints.Skulls30.Active = Skulls30_Button.CheckBox.Checked;
            Form.AlwaysHints.Skulls40.Active = Skulls40_Button.CheckBox.Checked;
            Form.AlwaysHints.Skulls50.Active = Skulls50_Button.CheckBox.Checked;
            Form.AlwaysHints.IceDual.Active = IceDual_Button.CheckBox.Checked;
            Form.AlwaysHints.CastleFairies.Active = CastleFairies_Button.CheckBox.Checked;
            Form.AlwaysHints.FrogsDual.Active = FrogsDual_Button.CheckBox.Checked;
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void SettingsPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
