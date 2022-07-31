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
            list.Add(56);
            list.Add(70);
            Console.WriteLine("Display Nodes Are:");
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            Console.WriteLine("============================================");
            Console.ReadLine();
        }
    }
}