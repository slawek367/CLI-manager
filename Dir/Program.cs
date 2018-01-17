using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dir
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                System.Console.WriteLine("No numeric argument get from parameters, console will start with standard color.");
                ConsoleManager.Start();
            }
            else
            {
                ConsoleManager.Configure(args[0]);
                ConsoleManager.Start();
            }
            
        }
    }
}