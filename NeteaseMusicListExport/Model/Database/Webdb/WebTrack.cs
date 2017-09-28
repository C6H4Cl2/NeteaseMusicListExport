using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseMusicListExport.Model.Database.Webdb
{
    public class WebTrack
    {
        private string tid;
        private string track;

        public WebTrack(string tid, string track)
        {
            this.tid = tid;
            this.track = track;
        }
    }
}
