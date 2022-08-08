using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class creature_template
    {
        public int Guid { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public creature_template()
        {
        }

        public creature_template(int guid, string name, int level)
        {
            Guid = guid;
            Name = name;
            Level = level;
        }
    }
}