using Android.App;
using ForeignExchange.Droid.Implementations;
using ForeignExchange.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(CloseApplication))]
namespace ForeignExchange.Droid.Implementations
{
    class CloseApplication : ICloseApplication
    {
        public void Close()
        {
            var activity = (Activity) Forms.Context;
            activity.FinishAffinity();
        }
    }
}