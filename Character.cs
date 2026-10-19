using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevengeOfFG
{
    public class FG(string[] data)
    {
        public string Name { get; set; } = data[0];
        public int Money { get; set; } = int.Parse(data[1]);
        public int Damage { get; set; } = int.Parse(data[2]);
        public int Health { get; set; } = int.Parse(data[3]);
        public int Defense { get; set; } = int.Parse(data[4]);




        public override string ToString()
        {
            return $"{Name},{Money},{Damage},{Health},{Defense}";
        }
    }
}
