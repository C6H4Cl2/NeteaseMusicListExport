using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseMusicListExport.Model.Database.Webdb
{
    // webdb.dat -> table:web_playlist
    public class WebPlaylist
    {
        private string pid;
        private string playlistJson;

        public WebPlaylist(string pid, string playlist)
        {
            this.pid = pid;
            this.playlistJson = playlist;
        }
    }
}
