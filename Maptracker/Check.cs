using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class Check : Button
    {       
        public Color color;
        private Color Color_Done = Color.Gray;
        public RichToolTip RichToolTip = new();
        [Browsable(true), Description("test property"), Category("Appearance")]
        public int CheckIndex {  get; set; }
        public bool PressedCheck;
        public bool Done
        {
            get
            {
                return _done;
            }
            set
            {
                _done = value;
                OnValueChanged(null);
            }
        }
        private bool _done;
        public Check()
        {
            Size = new Size(13, 13);
            FlatStyle = FlatStyle.Flat;
            BackColor = color;
            ForeColor = Color.Black;
            MouseDown += (sender,e) => ChangeColor();
            ValueChanged += (sender, e) => UpdateColor();
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.Black;    
            RichToolTip.Location = this.Location;            
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
            Graphics g = e.Graphics;
            using Pen selPen = new(Color.Black, 2);
            g.DrawEllipse(selPen, 0, 0, 13, 13);
        }
        public void ChangeColor()
        {          
            if(!Done)
            {                             
                Done = true;
            }             
            else
            {
                Done = false;
            }
            if(!PressedCheck)
            {
                PressedCheck = true;
            }
            else
            {
                PressedCheck = false;
            }
        }
        public void UpdateColor()
        {
            if(!Done)
            {
                BackColor = color;
            }  
            else
            {
                BackColor = Color_Done;
            }
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
    }
}
