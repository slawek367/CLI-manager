using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dir
{
    class CommandLine
    {
        public string currentDir { get; set; }

        public CommandLine()
        {

        }

        public void GetInput()
        {
            Print.Line(SystemGet.GetUser(), SystemGet.GetTime(), SystemGet.GetCurrentDir());
            RunCommand(Console.ReadLine());
        }

        public void RunCommand(string text)
        {
            string command = text.Split(' ').First();
            string[] arguments = text.Split(' ').Skip(1).ToArray();

            if (Command.Exists(command))
            {
                Command.commandList[command](arguments);
            }
            else if (command == "")
            {
                return;
            }
            else
            {
                Console.WriteLine("Command " + command + " not found! Please type \"help\" to get more informations.\n");
            }
        }
    }
}
