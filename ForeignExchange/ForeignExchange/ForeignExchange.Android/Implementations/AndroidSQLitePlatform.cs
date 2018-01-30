using App.Droid.Implementations;
using ForeignExchange.Interfaces;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(AndroidSQLitePlatform))]
namespace App.Droid.Implementations
{
    public class AndroidSQLitePlatform : ISQLitePlatform
    {
        public string GetPath(string dbName = "SoulForeignExchange.db3")
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
        }
    }
}