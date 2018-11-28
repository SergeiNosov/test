// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Testt
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EntyerApplePay { get; set; }

        [Action ("EnterApplePay:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void EnterApplePay (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (EntyerApplePay != null) {
                EntyerApplePay.Dispose ();
                EntyerApplePay = null;
            }
        }
    }
}