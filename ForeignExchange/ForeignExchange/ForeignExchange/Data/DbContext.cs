using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace ForeignExchange.Data
{
    public class DbContext : IDisposable
    {
        public SQLiteConnection Db { get; private set; }

        public DbContext()
        {
            var dir = DependencyService.Get<ISQLiteConfig>();
            var path = Path.Combine(dir.DbDirectory(), "test.db");
            Db = new SQLiteConnection(path);
            Db.CreateTable<User>();
        }

        public void Migrate()
        {
            if (!Db.Table<User>().Any())
            {
                Db.Insert(new User() { Name = "User1", Password = "1234", Email = "anemail@example.com", Telephone = "04249568137" });
                Db.Insert(new User() { Name = "User2", Password = "1234", Email = "anemail@example.com", Telephone = "04249568137" });
                Db.Insert(new User() { Name = "User3", Password = "1234", Email = "anemail@example.com", Telephone = "04249568137" });
                Db.Insert(new User() { Name = "User4", Password = "1234", Email = "anemail@example.com", Telephone = "04249568137" });
            }
        }

        public TableQuery<User> Users
        {
            get { return Db.Table<User>(); }
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
