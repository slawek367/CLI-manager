using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Dir.Commands
{
    static class Cd
    {
        public static void GetParameters(string[] args)
        {
            if(args.Length == 0)
            {
                Help();
            }
            else if (args[0] == "..")
            {
                try
                {
                    Directory.SetCurrentDirectory(Directory.GetParent(Environment.CurrentDirectory).ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("Can't do this!");
                }
            }
            else if (args[0].Length > 1 && args[0][1] == ':')
            {
                try
                {
                    Directory.SetCurrentDirectory(args[0].Replace('/', '\\'));
                }
                catch (Exception)
                {
                    Console.WriteLine("No such folder: " + args[0].Replace('/', '\\'));
                }
            }
            else if (args[0].Length>0)
            {
                try
                {
                    Directory.SetCurrentDirectory(Environment.CurrentDirectory.ToString() + "\\" + args[0].Replace('/','\\'));
                }
                catch (Exception)
                {
                    Console.WriteLine("No such folder: " + Environment.CurrentDirectory.ToString() + "\\" + args[0].Replace('/', '\\'));
                }
            }
            else
            {
                Console.WriteLine("Can't understand " + args[0] + " parameter!");
                Help();
            }
        }

        public static void Help()
        {
            Console.WriteLine("This is cd command, examples of usage:");
            Console.WriteLine("cd .. -> back one directory");
            Console.WriteLine("cd FolderName -> go to folder");
            Console.WriteLine("cd C:\\dir1\\dir2 -> go to full directory, you could use / or \\ it doesn't matter.");
        }
    }
}
