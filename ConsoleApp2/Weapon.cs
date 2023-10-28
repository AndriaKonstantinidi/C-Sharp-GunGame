using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Weapon
    {
        public string Power { get; set; }
        public string Lethality { get; set; }

        public override string ToString()
        {
            return $"{Power} {Lethality}";
        }
    }
}
