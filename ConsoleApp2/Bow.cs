using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bow
    {
        public int Accuracy { get; set; }
        public int arrowQuantity { get; set; }

        public override string ToString()
        {
            return $"{Accuracy} {arrowQuantity}";
        }
    }
    internal class bowMethods
    {
        public void GenerateAccuracy()
        {
            string bowAcc = string.Empty;
            Random random = new Random();
            for(int i = 0; i < 1; i++)
            {
                bowAcc += random.Next(1, 10).ToString();
            }
        }
        public void GenerateArrowQuantity()
        {
            string bowAcc = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                bowAcc += random.Next(1, 20).ToString();
            }
        }

        public void bowLethal()
        {
            string bowLeth = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                bowLeth += random.Next(1, 100).ToString();
            }
        }

        public void bowPower()
        {
            string bowPower = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                bowPower += random.Next(1, 100).ToString();
            }
        }
    }
}
