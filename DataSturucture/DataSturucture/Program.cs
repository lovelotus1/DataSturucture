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
            list.Appending(56);
            list.Appending(30);
            list.Appending(70);
            Console.WriteLine("Display Nodes Are:");

            list.Display();
            Console.WriteLine("============================================");
            Console.ReadLine();
        }
    }
}