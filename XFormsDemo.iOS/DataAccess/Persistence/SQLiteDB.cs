using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using XFormsDemo.DataAccess.Persistence;
using XFormsDemo.iOS.DataAccess.Persistence;

[assembly: Dependency(typeof(SQLiteDB))]

namespace XFormsDemo.iOS.DataAccess.Persistence
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
