using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONN.utils
{
    class FileHandler
    {
        public static string? FileName { get; set; }

        public FileHandler(string? _filename)
        {
            FileName = _filename;
        }

        /// <summary>
        /// This method check if the file exists, if the file doesn't exist
        /// then it will be created
        /// </summary>
        public static void CreateFile()
        {
            if (!File.Exists(FileName))
            {
                File.Create(FileName);
            }
        }
    }
}
