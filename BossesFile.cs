using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevengeOfFG
{
    public class BossesFile
    {
        public static List<BossesClass> FileReader(string FileName)
        {
            List<BossesClass> lines = new List<BossesClass>();
            try
            {
                foreach (string line in File.ReadAllLines(FileName, Encoding.UTF8).Skip(1))
                {
                    string[] temp = line.Split(";");
                    if (temp.Length == 3)
                    {
                        lines.Add(new BossesClass(temp));
                    }
                }
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }

            return lines;
        }
    }
}
