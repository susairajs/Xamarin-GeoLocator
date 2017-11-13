// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamarinGeoLocator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLatitude { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLongitude { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MapKit.MKMapView mapView1 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblLatitude != null) {
                lblLatitude.Dispose ();
                lblLatitude = null;
            }

            if (lblLongitude != null) {
                lblLongitude.Dispose ();
                lblLongitude = null;
            }

            if (mapView1 != null) {
                mapView1.Dispose ();
                mapView1 = null;
            }
        }
    }
}