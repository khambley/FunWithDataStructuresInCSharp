using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var bstTest = new BinarySearchTree<int>();
            bstTest.Insert(value: 37);
            bstTest.Insert(value: 24);
            bstTest.Insert(value: 17);
            bstTest.Insert(value: 28);
            bstTest.Insert(value: 31);
            bstTest.Insert(value: 29);
            bstTest.Insert(value: 15);
            bstTest.Insert(value: 12);
            bstTest.Insert(value: 20);

            foreach (var i in bstTest.TraverseInOrder())
            {
                Console.Write(value: $"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine(bstTest.Min());
            Console.WriteLine(bstTest.Max());
            Console.WriteLine(bstTest.Get(20).Value);
            Console.Read();
        }
    }
}
