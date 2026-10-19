using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace RevengeOfFG
{
    public class BossesClass(string[] data)
    {
        public string name {  get; set; } = data[0];
        public int damage { get; set; } = int.Parse(data[1]);
        public int health{ get; set; } = int.Parse(data[2]);



        public override string ToString()
        {
            return $"{name},{damage},{health}";
        }
    }
}
