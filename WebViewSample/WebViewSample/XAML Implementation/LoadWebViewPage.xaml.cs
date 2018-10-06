using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebViewSample.XAML_Implementation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoadWebViewPage : ContentPage
	{
		public LoadWebViewPage ()
		{
			InitializeComponent ();
		}
        /// <summary>
		/// Called when the webview starts navigating. Displays the loading label.
		/// </summary>
		void webviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            this.labelLoading.IsVisible = true; //display the label when navigating starts
        }

        /// <summary>
        /// Called when the webview finished navigating. Hides the loading label.
        /// </summary>
        void webviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            this.labelLoading.IsVisible = false; //remove the loading indicator when navigating is finished
        }
        protected override bool OnBackButtonPressed()
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }

            return true; ;
        }
    }
}