using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using static MDML.Config;

namespace MDML.Utils
{
    public static class FileZiper
    {
        public static string UnZip(string path)
        {
            // judge if the file is existing
            if (!File.Exists(path))
            {
                throw new ArgumentException("File Not Exist");
            }

            // unzip the file to working directory
            var info = new FileInfo(path);
            ZipFile.ExtractToDirectory(path, Path.Combine(DefaultPath, info.Name), Encoding.Default);
            
            // judge if the Description.xml and Resource.meta is existing
            if (!File.Exists(Path.Combine(DefaultPath, info.Name, "Description.xml")) || !File.Exists(Path.Combine(DefaultPath, info.Name, "Resource.meta")))
            {
                throw new ArgumentException("Description File Not Exist");
            }

            return Path.Combine(DefaultPath, info.Name);
        }
    }
}