﻿using System;
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
            list.RemoveFirstNode();
            Console.WriteLine("After Removing is : ");
            list.Display();
            Console.WriteLine("============================================");
            Console.ReadLine();
        }
    }
}