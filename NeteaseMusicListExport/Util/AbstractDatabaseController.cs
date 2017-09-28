using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseMusicListExport.Util
{
    public abstract class AbstractDatabaseController
    {
        protected string TEMP_DB_PATH = null;

        protected SQLiteConnection ConnectDb()
        {
            if (String.IsNullOrEmpty(TEMP_DB_PATH)) throw new Exception("Database path is empty.");

            string connectionInfo = String.Format("Data Source={0};Version=3;", TEMP_DB_PATH);
            SQLiteConnection db = new SQLiteConnection(connectionInfo);
            db.Open();

            return db;
        }
        
    }
}
