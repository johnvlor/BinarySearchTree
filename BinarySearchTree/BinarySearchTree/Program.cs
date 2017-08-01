using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree nums = new BinarySearchTree();
            nums.Add(50);
            nums.Add(17);
            nums.Add(23);
            nums.Add(7);
            nums.Add(1);
            nums.Add(72);
            nums.Add(76);
            nums.Add(12);
            nums.Add(62);

            nums.Display();

            Console.WriteLine();
            Console.WriteLine("50 " + nums.Find(50));
            Console.WriteLine("76 " + nums.Find(76));
            Console.WriteLine("7 " + nums.Find(7));
            Console.WriteLine("10 " + nums.Find(10));
            Console.WriteLine("100 " + nums.Find(100));

            Console.ReadKey();
        }
    }
}
