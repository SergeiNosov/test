// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Testt
{
    [Register ("MapView")]
    partial class MapView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MapKit.MKMapView MapObj { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MapObj != null) {
                MapObj.Dispose ();
                MapObj = null;
            }
        }
    }
}