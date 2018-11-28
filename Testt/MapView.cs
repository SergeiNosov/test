using Foundation;
using System;
using UIKit;
using MapKit;
using CoreLocation;
using CoreGraphics;
using Plugin.Geolocator;
namespace Testt
{
    public partial class MapView : UIViewController
    {

        public MapView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Console.WriteLine("MapView Start!!");
            var map = MapObj;
            map.ShowsUserLocation = true;
            map.ShowsTraffic=true;

            Wait();

        }

        async void Wait()
        {

            var locator = CrossGeolocator.Current;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));

            Console.WriteLine("Position Status: {0}", position.Timestamp);
            Console.WriteLine("Position Latitude: {0}", position.Latitude);
            Console.WriteLine("Position Longitude: {0}", position.Longitude);
        }
    }
   
}