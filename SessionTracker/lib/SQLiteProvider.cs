using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionTracker.lib
{
    class SQLiteProvider
    {
        #region member
        public SQLiteConnection Connection { get { return _connection; } }

        #endregion member

        private SQLiteConnection _connection;

        public void Initialize(String FileName)
        {
            //check if db Exists
            if (!File.Exists(FileName))
            {
                //create db
                SQLiteConnection.CreateFile(FileName);
            }
            //connect to FileName
            _connection = new SQLiteConnection("Data Source="+FileName);
            _connection.Open();
            //check if table exists with correct fields
            //create table
            SQLiteCommand command = new SQLiteCommand("CREATE TABLE tracks (start DateTime,end DateTime,description text)",_connection);
            command.ExecuteNonQuery();
        }

        public void Open(String FileName)
        {
            //check if file exists => Initialize
            if (!File.Exists(FileName))
            {
                Initialize(FileName);
            }
            else
            {
                _connection = new SQLiteConnection("Data Source=" + FileName);
                _connection.Open();
            }
        }

        public bool SaveTrack(Track track)
        {
            SQLiteCommand command = new SQLiteCommand("INSERT INTO tracks (start,end,description) VALUES (@START,@END,@DESCRIPTION)",_connection);
            command.Parameters.Add(new SQLiteParameter("@START", track.start));
            command.Parameters.Add(new SQLiteParameter("@END", track.stop));
            command.Parameters.Add(new SQLiteParameter("@DESCRIPTION", track.description));
            command.ExecuteNonQuery();
            return true;
        }

        public List<Track> getTracks()
        {
            List<Track> tracks = new List<Track>();

            return tracks;
        }

        public List<DayCounter> getCounter() {
            List<DayCounter> counterlist = new List<DayCounter>();
            string stm = "SELECT * FROM DayCounterLastMonth order by day";

            using (SQLiteCommand cmd = new SQLiteCommand(stm, _connection))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        DateTime date = (DateTime) rdr["day"];
                        DayCounter counter = new DayCounter(
                                (DateTime)rdr["day"],
                                Convert.ToInt32(rdr["weekday"]),
                                Convert.ToInt32(rdr["week"]) +1,
                                Convert.ToDouble(rdr["counter"]));
                        counterlist.Add(counter);
                    }
                }
            }

            return counterlist;
        } 

    }
}
