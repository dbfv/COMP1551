using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Part1.classes
{
    public static class DataManager
    {
        private static string filePath = "History.csv";

        public static void WriteToFile()
        { 
            File.WriteAllText(filePath, "ngu");
        }
    } //end of DataManager
} //end of namespace
