using System.IO;
using System.Xml;
using MDML.Utils;

namespace MDML.Models
{
    public class MicroscopeData
    {
        private string _name;
        private string _description;
        private FileInfo _thumbnailData;
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

        public FileInfo ThumbnailData
        {
            get => _thumbnailData;
            set => _thumbnailData = value;
        }

        public FileInfo MetaData
        {
            get => _metaData;
            set => _metaData = value;
        }

        private static void Load(string path)
        {
            var info = FileReader.ReadFromPath(path);
            // todo
        }

        public MicroscopeData(string path = "")
        {
            Load(path);
            // todo
        }
    }
}