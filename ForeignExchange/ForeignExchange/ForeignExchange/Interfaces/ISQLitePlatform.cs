using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForeignExchange.Interfaces
{
    public interface ISQLitePlatform
    {
        string GetPath(string dbName="SoulForeignExchange.db3");
        //SQLiteConnection GetConnection();
        //SQLiteAsyncConnection GetConnectionAsync();
    }
}
