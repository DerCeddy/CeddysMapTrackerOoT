using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class SometimesHintElement
    {
        public int CheckIndex = 0;
        public int CheckIndexDual = 0;
        public string CheckName = "";       

        public SometimesHintElement()
        {
            
        }
         public override string ToString()
        {
            return this.CheckName;
        }
    }
}
