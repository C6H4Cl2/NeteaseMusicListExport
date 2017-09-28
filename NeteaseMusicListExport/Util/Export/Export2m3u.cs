using NeteaseMusicListExport.Model.Database.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseMusicListExport.Util.Export
{
    public class Export2m3u
    {
        static private readonly string FILE_NAME = "netease_playlist.m3u";
        static public void ExportTracks(List<Track> tracks, string exportPath)
        {
            if (tracks == null) return;

            string path = Path.Combine(exportPath, FILE_NAME);


            // Create a file to write to.
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine("#EXTM3U");
                foreach (var track in tracks) sw.WriteLine(track.getFilePath());
            }

        }
    }
}
