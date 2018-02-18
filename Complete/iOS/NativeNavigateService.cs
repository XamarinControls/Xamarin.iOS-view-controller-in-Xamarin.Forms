using UIKit;
using Xamarin.Forms;
using XamarinFormsSampleApp.iOS;

[assembly: Dependency(typeof(NativeNavigateService))]
namespace XamarinFormsSampleApp.iOS
{
    public class NativeNavigateService : INativeNavigateService
    {
        const string MainStoryboardName = "Main";

        public void Navigate()
        {
            var storyboard = UIStoryboard.FromName(MainStoryboardName, null);
            var controller = storyboard.InstantiateInitialViewController();

            var window = UIApplication.SharedApplication.KeyWindow;
            window.RootViewController.PresentViewController(controller, false, null);
        }
    }
}
