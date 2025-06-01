using System;
using System.Collections.Generic;
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
        public bool done
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
            Size = new Size(12, 12);
            FlatStyle = FlatStyle.Flat;
            BackColor = color;
            ForeColor = Color.Black;
            MouseDown += (sender,e) => ChangeColor();
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.Black;
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
            if(!done)
            {             
                BackColor = Color.Gray;
                done = true;
            }             
            else
            {
                BackColor = color;
                done = false;
            }
        }
        public void UpdateColor()
        {
            if(!done)
            {
                BackColor = color;
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
