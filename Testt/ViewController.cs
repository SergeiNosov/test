using System;
using CoreAudioKit;
using Foundation;
using PassKit;
using UIKit;

namespace Testt
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Console.WriteLine("start!");
            var url = new NSUrl("https://google.com/");
            //WebContent.LoadRequest(new NSUrlRequest(url)); // Perform any additional setup after loading the view, typically from a nib.

            //UrlSaver.Text = "https://google.com/";
        }

        partial void EnterApplePay(UIButton sender)
        {
         
            if (PKPaymentAuthorizationController.CanMakePayments)
            {
                Console.WriteLine("Apple Pay Start!");
            
            }
            else {
                Console.WriteLine("Apple Pay No Start!");
            }

        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }




       

        //partial void ChangeText(UIButton sender)
        //{
        //    Console.WriteLine("Click!!");
        //    var urlText = "https://" + UrlSaver.Text + "/";
        //    var url = new NSUrl("https://" + UrlSaver.Text+"/");
        //    WebContent.LoadRequest(new NSUrlRequest(url));
        //    UrlSaver.Text = urlText;
        //}

        //partial void ChangeLayer(UIButton sender)
        //{
        //    var twoView = View2 as UIViewController;
        //}
    }
}
