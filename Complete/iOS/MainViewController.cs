using Foundation;
using System;
using UIKit;

namespace XamarinFormsSampleApp.iOS
{
    public partial class MainViewController : UIViewController
    {
        public MainViewController (IntPtr handle) : base (handle)
        {
        }

        partial void GoBack(UIButton sender)
        {
            this.DismissViewController(false, null);
        }
    }
}