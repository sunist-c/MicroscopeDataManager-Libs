using System;
using System.IO;

namespace MDML
{
    public static class Config
    {
        private static string _defaultPath;

        public static string DefaultPath => _defaultPath;

        static Config()
        {
            _defaultPath = Path.Combine("~", "Documents", "MicroscopeData", "Resources");
        }

        public static bool SetPath(string path)
        {
            if (Directory.Exists(path))
            {
                _defaultPath = path;
                return true;
            }
            else
            {
                throw new ArgumentException("Directory Not Exist");
            }
        }

        public static void ResetPath()
        {
            _defaultPath = Path.Combine("~", "Documents", "MicroscopeData", "Resources");
        }
    }
}