using System;
using System.IO;
using SQLite;
using XFormsDemo.DataAccess.Persistence;
using XFormsDemo.Droid.DataAccess.Persistence;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDB))]

namespace XFormsDemo.Droid.DataAccess.Persistence
{
	public class SQLiteDB : ISQLiteDB
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var sqliteDBPath = Path.Combine(documentDirectory, "App.db3");
            return new SQLiteAsyncConnection(sqliteDBPath);
        }
    }
}
