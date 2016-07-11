using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using DasQuiz.Interfaces;
using DasQuiz.Windows;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Win))]
namespace DasQuiz.Windows
{
    public class SQLite_Win : ISQLite
    {
        public SQLite_Win() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "SpielerInfo.db3";
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
            var conn = new SQLiteConnection(path);
            return conn;
        }

        public SQLiteConnection GetConnectionQuiz()
        {
            var sqliteFilename = "german.db";
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}
