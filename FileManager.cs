using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevengeOfFG
{
    public class FileManager
    {
        public static List<Wizard> FileReader(string Filename)
        {
            List<Wizard> lines = new List<Wizard>();

            try
            {
                foreach (string line in File.ReadAllLines(Filename, Encoding.UTF8).Skip(1))
                {
                    string[] temp = line.Split(";");
                    if (temp.Length == 5)
                    {
                        lines.Add(new Wizard(temp));
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
    

