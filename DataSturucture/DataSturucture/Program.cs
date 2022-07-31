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
            list.Add(30);
            list.Add(70);
            int searchData = list.Search(30);
            if (searchData != 0)
                Console.WriteLine("\n{0} is present in the LinkedList ", searchData);
            list.Display();
            Console.WriteLine("============================================");
            Console.ReadLine();
        }
    }
}