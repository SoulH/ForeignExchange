using App.DependencyServices;
using App.Droid.Implementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteConfig))]
namespace App.Droid.Implementations
{
    public class SQLiteConfig : ISQLiteConfig
    {
        public string DbDirectory()
        {
            return System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        }
    }
}