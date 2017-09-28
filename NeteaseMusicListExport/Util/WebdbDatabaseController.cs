using NeteaseMusicListExport.Model.Database.Webdb;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseMusicListExport.Util
{
    public class WebdbDatabaseController : AbstractDatabaseController
    {
        public WebdbDatabaseController()
        {
            this.TEMP_DB_PATH = @"C:\Users\spicy\AppData\Local\Netease\CloudMusic\Library\webdb.dat";
        }

        public List<WebTrack> GetWebTracksByPlaylistId(string pid)
        {
            var webPlaylistTracks = new List<WebTrack>();
            if (String.IsNullOrEmpty(pid)) return webPlaylistTracks;

            SQLiteConnection db = null;
            try
            {
                db = ConnectDb();

                string sql = "select web_track.tid, web_track.track from web_playlist_track, web_track where web_playlist_track.pid='{0}' and web_playlist_track.tid=web_track.tid order by web_playlist_track.'order' ASC";
                SQLiteCommand command = new SQLiteCommand(String.Format(sql, pid), db);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var webTrack = new WebTrack(reader["tid"].ToString(), reader["track"].ToString());
                    webPlaylistTracks.Add(webTrack);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (db != null) db.Close();
            }
            return webPlaylistTracks;
        }

        public List<WebPlaylist> GetWebPlaylist()
        {
            var webPlaylists = new List<WebPlaylist>();
            SQLiteConnection db = null;
            try
            {
                db = ConnectDb();

                string sql = "select * from web_playlist";
                SQLiteCommand command = new SQLiteCommand(sql, db);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var webPlaylist = new WebPlaylist(reader["pid"].ToString(), reader["playlist"].ToString());
                    webPlaylists.Add(webPlaylist);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (db != null) db.Close();
            }
            return webPlaylists;
        }
    }
}
