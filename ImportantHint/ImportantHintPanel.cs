using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class ImportantHintPanel : Panel
    {
        public List<ImportantHint> ImportantHints = [];       
        public decimal Goal_Count = 0;
        public ImportantHintPanel(Point _location)
        {
            Width = 260;
            Height = 0;
            AutoSize = true;
            Location = _location;
            BackColor = Color.Black;
            Font = new Font("Arial", 12, GraphicsUnit.Pixel);
            Label label = new()
            {
                Size = new Size(130, 20),
                Location = new Point(0, 0),
                Text = "Important Hints",
                ForeColor = Color.White,
            };
            Controls.Add(label);
            //GenerateHintsAndStones();
            AutoSize = true;
            GenerateHints();
        }
        public void GenerateHints()
        {
            for (int i = 0; i < Goal_Count; i++)
            {
                ImportantHint ImportantHint = new(new Point(0, (i * 51) + 30));
                ImportantHints.Add(ImportantHint);           
                Controls.Add(ImportantHint);
            }
        }
        public void DeleteHints()
        {
            foreach (ImportantHint Hint in ImportantHints)
            {
                Hint.Dispose();
            }            
            ImportantHints.Clear();
        }
    }
}
