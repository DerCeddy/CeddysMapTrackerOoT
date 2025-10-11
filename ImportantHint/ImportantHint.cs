using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace CeddyMapTracker
{
   
    public class ImportantHint : UserControl
    {
        public int MajorItemsCount;
        public TextBox RegionName = new();
        public List<Gossipstone> Gossipstones = [];
        public ImportantHint(Point Location)
        {
            Size = new Size(260,51);
            this.Location = Location;
            Label Counter = new() {Size = new Size(24,24), Font = new Font("Arial",12, GraphicsUnit.Pixel), Location = new Point(0,0), ForeColor = Color.White, BackColor = Color.Black, Text = "0", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter};
            Counter.MouseDown += (sender,e) => GoalClick(e);
            Counter.MouseDown += (sender, e) => Counter.Text = MajorItemsCount.ToString();
            Counter.MouseWheel += (sender, e) => GoalScroll(e);
            Counter.MouseWheel += (sender, e) => Counter.Text = MajorItemsCount.ToString();
            RegionName.Multiline = true;
            RegionName.Location = new Point(24,3); 
            RegionName.Size = new Size(200,23);
            RegionName.BackColor = Color.Goldenrod;
            RegionName.MouseDown += (sender, e) => RegionName.Text = string.Empty;
            Controls.Add(Counter);
            Controls.Add(RegionName);
        }
        public void RefreshGossipStones()
        {
            foreach(Control c in Controls)
            {
                if(c != null && c is Gossipstone GS)
                {
                    Controls.Remove(GS);
                }
            }
            for(int i = 0; i < Gossipstones.Count; i++)
            {
                var temp = i;
                Gossipstones[temp].Size = new Size(24,24);
                Gossipstones[temp].Location = new Point(i * 24,27);
                Controls.Add(Gossipstones[temp]);
            }
        }
        public void RefreshGossipstonesToList()
        {
            for(int i = 0; i < MajorItemsCount; i++)
            {
                var temp = i;

            }
        }
        public void GoalClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ValueUp();

            }
            if (e.Button == MouseButtons.Right)
            {
                ValueDown();
            }          
        }
        public void GoalScroll(MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                ValueUp();

            }
            if (e.Delta < 0)
            {
                ValueDown();
            }
        }
        public int ValueDown()
        {
            MajorItemsCount--;
            if (MajorItemsCount < 0)
            { 
                MajorItemsCount = 0; 
            }
            else
            {
                //Gossipstones.Remove(Gossipstones[MajorItemsCount]);
                var temp = Gossipstones[MajorItemsCount];
                Gossipstones.RemoveAt(MajorItemsCount);
                Controls.Remove(temp);
                temp.Dispose();
            }
            return MajorItemsCount;
        }
        public int ValueUp()
        {
            MajorItemsCount++;
            if (MajorItemsCount > 10)
            { 
                MajorItemsCount = 10; 
            }
            else
            {
                Gossipstone GossipStone = new();
                Gossipstones.Add(GossipStone);
                RefreshGossipStones();
            }
            return MajorItemsCount;
        }
    }
}
    
