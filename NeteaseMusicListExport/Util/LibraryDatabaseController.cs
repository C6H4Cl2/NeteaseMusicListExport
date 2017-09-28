using NeteaseMusicListExport.Model.Database.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseMusicListExport.Util
{
    public class LibraryDatabaseController : AbstractDatabaseController
    {
        public LibraryDatabaseController()
        {
            this.TEMP_DB_PATH = @"C:\Users\spicy\AppData\Local\Netease\CloudMusic\Library\library.dat"; ;
        }

        public List<Track> SelectRecentTracks(int size)
        {
            List<Track> track = new List<Track>();

            SQLiteConnection db = null;
            try
            {
                db = ConnectDb();
                string sql = "select * from track order by track.timestamp DESC limit @size";
                SQLiteCommand command = new SQLiteCommand(sql, db);
                command.Parameters.Add(new SQLiteParameter("@size", size));
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var webTrack = new Track(reader["file"].ToString(), reader["title"].ToString());
                    track.Add(webTrack);
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
            return track;
        }
    }
}
