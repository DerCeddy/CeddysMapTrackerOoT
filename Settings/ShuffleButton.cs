using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace CeddyMapTracker
{
    public class ShuffleButton : CheckBox
    {
        public bool State
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
        private bool _state;        
        public ShuffleButton()
        {            
            Size = new Size(48, 48);           
            BackColor = Color.White;
            Font = new Font("Arial", 12, GraphicsUnit.Pixel);
            MouseDown += (sender,e) => ClickEvent(e);
            AutoCheck = false;
            CheckedChanged += (sender, e) => State = true;
        }
        public void ClickEvent(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (!Checked)
                    {
                        Checked = true;                      
                    }
                    else
                    {
                        Checked = false;
                    }
                    break;
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
