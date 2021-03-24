using System;
using System.IO;
using System.IO.Compression;

namespace MDML.Utils
{
    public static class FileReader
    {
        /// <summary>
        /// This method will read the source package and copy it to working directory, return the unpacked file information.
        /// </summary>
        /// <param name="path">The source package full path</param>
        /// <returns>The unpacked FileInfo</returns>
        /// <exception cref="ArgumentException"></exception>
        public static FileInfo ReadFromPath(string path)
        {
            // judge if the file is existing
            if (!File.Exists(path))
            {
                throw new ArgumentException("File Not Exist");
            }

            // try to unzip the file
            string innerPath = FileZiper.UnZip(path);
            
            return new FileInfo(innerPath);
        }
    }
}