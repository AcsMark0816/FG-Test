using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevengeOfFG
{
    public class FGFileManager
    {
        public static List<FG> FileReader(string FileName)
        {
            List<FG> lines = new List<FG>();
            try
            {
                foreach(string line in File.ReadAllLines(FileName, Encoding.UTF8).Skip(1))
                {
                    string[] temp = line.Split(";");
                    if(temp.Length == 5)
                    {
                        lines.Add(new FG(temp));
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
