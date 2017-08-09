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

namespace TestApp1
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _button1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _button2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _button3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _button4 { get; set; }

        [Action ("_button1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _button1_TouchUpInside (UIKit.UIButton sender);

        [Action ("_button2_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _button2_TouchUpInside (UIKit.UIButton sender);

        [Action ("_button3_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _button3_TouchUpInside (UIKit.UIButton sender);

        [Action ("_button4_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _button4_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (_button1 != null) {
                _button1.Dispose ();
                _button1 = null;
            }

            if (_button2 != null) {
                _button2.Dispose ();
                _button2 = null;
            }

            if (_button3 != null) {
                _button3.Dispose ();
                _button3 = null;
            }

            if (_button4 != null) {
                _button4.Dispose ();
                _button4 = null;
            }
        }
    }
}