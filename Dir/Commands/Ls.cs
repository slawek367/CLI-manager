using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

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
                if (args.Length == 2 && args[1] == "-desc")
                {
                    ListFilesByDate(false);
                    return;
                }
                ListFilesByDate();
            }
            else if (args[0] == "-size")
            {
                if(args.Length == 2 && args[1] == "-desc")
                {
                    ListFilesBySize(false);
                    return;
                }
                ListFilesBySize();
            }
            else if (args[0] == "-name")
            {
                if (args.Length == 2 && args[1] == "-desc")
                {
                    ListFilesByName(false);
                    return;
                }
                ListFilesByName();
            }
            else
            {
                Console.WriteLine("This is ls command, possible commands:");
                Console.WriteLine("ls");
                Console.WriteLine("ls -size");
                Console.WriteLine("ls -size -desc");
                Console.WriteLine("ls -name");
                Console.WriteLine("ls -name -desc");
                Console.WriteLine("ls -date");
                Console.WriteLine("ls -date -desc");
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

        public static void ListFilesByDate(bool asc = true)
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            var directory = dir.EnumerateFileSystemInfos();

            IEnumerable<FileSystemInfo> sortedDirAndFiles;
            if (asc == true)
            {
                sortedDirAndFiles = directory.OrderBy(x => x.CreationTime);
            }
            else
            {
                sortedDirAndFiles = directory.OrderByDescending(x => x.CreationTime);
            }

            foreach (var item in sortedDirAndFiles)
            {
                if (item.Attributes.HasFlag(FileAttributes.Directory))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{item.Name,-20} {item.CreationTime,20}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{item.Name,-20} {item.CreationTime,20}");
                }
            }
        }

        public static void ListFilesBySize(bool asc = true)
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

            var directories = dir.GetDirectories();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var item in directories)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;

            IEnumerable<FileInfo> fis;
            if (asc == true)
            {
                fis = dir.GetFiles().OrderBy(x => x.Length);
            } else
            {
                fis = dir.GetFiles().OrderByDescending(x => x.Length);
            }

            foreach (FileInfo fi in fis)
            {
                //Console.WriteLine(fi.Name + "\t\t\t\t" + fi.Length);
                double size = Convert.ToDouble(fi.Length) / 1024;
                string size2 = size.ToString("F2");
                Console.WriteLine($"{fi.Name,-20} {size2,20} Kb ");
                size += fi.Length;
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ListFilesByName(bool asc = true)
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            var directory = dir.EnumerateFileSystemInfos();

            IEnumerable<FileSystemInfo> sortedDirAndFiles;
            if (asc == true)
            {
                sortedDirAndFiles = directory.OrderBy(x => x.Name);
            }
            else
            {
                sortedDirAndFiles = directory.OrderByDescending(x => x.Name);
            }

            foreach (var item in sortedDirAndFiles)
            {
                if (item.Attributes.HasFlag(FileAttributes.Directory))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(item.Name);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
