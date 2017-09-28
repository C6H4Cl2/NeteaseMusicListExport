using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseMusicListExport.Model.Database.Library
{
    public class Track
    {
        private string file;
        private string title;

        public Track(string file, string title)
        {
            this.file = file;
            this.title = title;
        }

        public string getFilePath()
        {
            return file;
        }
    }
}
