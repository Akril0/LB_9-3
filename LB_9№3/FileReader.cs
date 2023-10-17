using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_9_3
{
    internal class FileReader
    {
        public static Node ReadFileAndCreateTree()
        {
            
            String line;
            Node root = null;
            try
            {
                StreamReader sr = new StreamReader($"../../../translate.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    String[] data = line.Split(":");
                    root = Node.Insert(root, data);
                    
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return root;

        }
    }
}
