using System.IO;
using System.Xml;
using MDML.Utils;

namespace MDML.Models
{
    public class MicroscopeData
    {
        private string _name;
        private string _description;
        private FileInfo _metaData;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public FileInfo MetaData
        {
            get => _metaData;
            set => _metaData = value;
        }

        public static void Load(string path)
        {
            var info = FileReader.ReadFromPath(path);
            
            
        }
    }
}