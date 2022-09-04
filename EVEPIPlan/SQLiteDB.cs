using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace EVEPIPlan
{
    internal class SQLiteDB
    {
        static SQLiteDB instance;
        static Mutex mutex = new Mutex();
        SQLiteConnection db;

        public static SQLiteDB GetInstance()
        {
            mutex.WaitOne();
            if (instance == null)
            {
                instance = new SQLiteDB();
            }
            mutex.ReleaseMutex();
            return instance;
        }

        private SQLiteDB()
        {
        }
    }
}
