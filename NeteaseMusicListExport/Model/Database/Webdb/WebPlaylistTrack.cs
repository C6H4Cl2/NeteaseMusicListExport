using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseMusicListExport.Model.Database.Webdb
{
    // webdb.dat -> table:web_playlist_track
    public class WebPlaylistTrack
    {
        public string pid { set; get; }
        public string tid { set; get; }
        public string version { set; get; }
        public string order { set; get; }
    }
}
