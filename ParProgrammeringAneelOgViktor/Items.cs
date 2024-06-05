using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringAneelOgViktor
{
    public class Items
    {
        public string Name { get; private set; }
        public string Type { get; private set; }

        public Items(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public Items()
        {
        }
    }
}