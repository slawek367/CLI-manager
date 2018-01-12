using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dir
{
    static class SystemGet
    {
        public static string GetUser()
        {
            return Environment.UserName;
        }

        public static string GetTime()
        {
            return string.Format("{0:dd-MM-y HH:mm:ss}", DateTime.Now);
        }

        public static string GetCurrentDir()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }
    }
}
