using System;
using SQLite;

namespace XFormsDemo.DataAccess.Persistence
{
	public interface ISQLiteDB
    {
		SQLiteAsyncConnection GetConnection();
    }
}
