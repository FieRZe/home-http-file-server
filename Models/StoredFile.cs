using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileServer.Models
{
    public class StoredFile
    {
        public string Name { get; }
        public string Extension { get; }
        public string Type { get; }
        public string DateUpload { get; }
        public string TimeUpload { get; }
        public double Size { get; }
        public string Path { get; }
    }
}
