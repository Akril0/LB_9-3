using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_9_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Node root = FileReader.ReadFileAndCreateTree();

            Console.WriteLine("Введіть слово:");
            String word = Console.ReadLine();


            Node current = root;
            Node parent = null;
            while (current != null && current.Data[0] != word)
            {
                parent = current;
                if (word.Length <= current.Data[0].Length)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            Console.WriteLine(current.Data[1]);
        }
    }
}