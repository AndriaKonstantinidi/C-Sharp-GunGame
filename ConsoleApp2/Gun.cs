using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Gun
    {
        public int BulletQuantity { get; set; }

        public override string ToString()
        {
            return $"{BulletQuantity}";
        }
    }

    internal class gunMethods
    {
        public void GenerateBullet()
        {
            string moreBoulets = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                moreBoulets += random.Next(1, 15).ToString();
            }
        }

        public void gunLethal()
        {
            string gunLeth = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                gunLeth += random.Next(1, 50).ToString();
            }
        }

        public void gunPower()
        {
            string gunPower = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                gunPower += random.Next(1, 100).ToString();
            }
        }
    }
}

