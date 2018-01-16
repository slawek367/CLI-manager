using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dir.Commands
{
    static class Ls
    {
        public static void GetParameters(string[] args)
        {
            if (args.Length == 0)
            {
                ListFiles();
            }
            else if (args[0] == "-date")
            {
                ListFilesByDate();
            }
            else if (args[0] == "-size")
            {
                ListFilesBySize();
            }
            else if (args[0] == "-name")
            {
                ListFilesByName();
            }
            else
            {
                Console.WriteLine("This is ls command, just write ls to list folders and directories");
            }
        }

        public static void ListFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

            var files = dir.GetFiles();
            var directories = dir.GetDirectories();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var item in directories)
            {
                Console.WriteLine(item);
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ListFilesByDate()
        {

        }

        public static void ListFilesBySize()
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

            var files = dir.GetFiles();
            var directories = dir.GetDirectories();
        }

        public static void ListFilesByName()
        {

        }

        //Test
        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }
    }
}
