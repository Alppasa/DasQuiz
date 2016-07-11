using System;
using System.IO;
using System.Runtime.CompilerServices;
using Android.Content.Res;
using Android.OS;
using DasQuiz.Droid;
using SQLite;
using DasQuiz.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Android))]

namespace DasQuiz.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {
            
        }

        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "SpielerInfo.db3";
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            var conn = new  SQLiteConnection(path);
            return conn;
        }

        public SQLiteConnection GetConnectionQuiz()
        {
            var sqliteFilename = "german.db";
            var documentsPath = FileAccessHelper.GetLocalFilePath(sqliteFilename);
            // Create the connection
            var conn = new SQLiteConnection(documentsPath);
            // Return the database connection
            return conn;
   
        }
    }

}