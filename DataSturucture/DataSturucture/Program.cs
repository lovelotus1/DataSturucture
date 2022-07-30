using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Problem Program!");

            Console.WriteLine("Search Operation !");
            LinkedList list = new LinkedList();
            list.AddReverse(70);
            list.AddReverse(30);
            list.AddReverse(56);
            Console.WriteLine("Display Nodes Are:");

            list.Display();
            Console.WriteLine("============================================");
            Console.ReadLine();
        }
    }
}