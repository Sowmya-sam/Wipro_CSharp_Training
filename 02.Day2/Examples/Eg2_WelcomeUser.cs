﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
             
            Console.WriteLine("Enter your name : ");
            userName = Console.ReadLine();

            Console.WriteLine();    
            Console.WriteLine("Welcome " + userName);


            Console.ReadLine();
        }
    }
}
