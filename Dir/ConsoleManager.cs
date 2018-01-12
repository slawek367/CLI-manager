using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dir
{
    static class ConsoleManager
    {


        public static void Configure()
        {

        }

        public static void Start()
        {
            CommandLine cli = new CommandLine();
            while (true)
            {
                cli.GetInput();
            }
        }
    }
}
