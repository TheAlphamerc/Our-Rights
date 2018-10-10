using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using WebViewSample.XAML_Implementation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace WebViewSample
{
    public class App : Application
    {
        public App()
        {
			MainPage = new LoadWebViewPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=6beb8110-6eea-4850-b78f-03326f1a952f;" +
                  "uwp=6beb8140-6eea-4850-b78f-03326f1a952f;" +
                  "ios=6beb8120-6eea-4850-b78f-03326f1a952f",
                  typeof(Analytics), typeof(Crashes));
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
