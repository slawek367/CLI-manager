using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dir
{
    static class Print
    {
        public static void Line(string user, string time, string dir)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(user + "-");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[" + time + "]" + " ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(dir + ":~$ ");
        }
    }
}
