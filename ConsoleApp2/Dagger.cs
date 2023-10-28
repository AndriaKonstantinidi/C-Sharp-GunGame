using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dagger
    {
        public int singleorDouble { get; set; }

        public override string ToString()
        {
            return $"{singleorDouble}";
        }
    }
    internal class knifeMethods
    {
        public void OneOrTwo()
        {
            string knives = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                knives += random.Next(1, 2).ToString();
            }
        }

        public void KnifePower()
        {
            string daggPower = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                daggPower += random.Next(1, 100).ToString();
            }
        }
        public void KnifeLethal()
        {
            string daggLeth = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                daggLeth += random.Next(1, 50).ToString();
            }
        }
    }
}
