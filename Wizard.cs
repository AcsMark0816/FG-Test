using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevengeOfFG
{
    public class Wizard(string[] data)
    {
        public string Name { get; set; } = data[0];
        public string Type { get; set; } = data[1];
        public int DMG { get; set; } = int.Parse(data[2]);
        public int Def { get; set; } = int.Parse(data[3]);
        public int Health { get; set; } = int.Parse(data[4]);





        public override string ToString()
        {
            return $"{Name},{Type},{DMG},{Def},{Health}";
        }

       
    }
}
    

