using System;

using UIKit;
using Plugin.Geolocator;
using CoreLocation;
using MapKit;
namespace XamarinGeoLocator
{
	public partial class ViewController : UIViewController
	{

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public async override void ViewDidLoad()
		{
			base.ViewDidLoad();

            var location = CrossGeolocator.Current;
            var position = await location.GetPositionAsync();
            CLLocationManager locationManager = new CLLocationManager();
			locationManager.RequestWhenInUseAuthorization();

			mapView1.MapType = MKMapType.Standard;
			mapView1.ZoomEnabled = true;
			mapView1.ScrollEnabled = true;

			
			CLLocationCoordinate2D mapCenter = new CLLocationCoordinate2D(position.Latitude, position.Longitude);
			MKCoordinateRegion mapRegion = MKCoordinateRegion.FromDistance(mapCenter, 8000, 8000);
			mapView1.CenterCoordinate = mapCenter;
			mapView1.Region = mapRegion;
			mapView1.ShowsUserLocation = true;

			lblLatitude.Text = "Latitude:"+position.Latitude.ToString();
			lblLongitude.Text= "Longitude:"+position.Longitude.ToString();

			//mapView1.DidUpdateUserLocation += (sender, e) =>
			//{
			//	if (mapView1.UserLocation != null)
			//	{
			//		CLLocationCoordinate2D coords = mapView1.UserLocation.Coordinate;
			//		MKCoordinateSpan span = new MKCoordinateSpan(MilesToLatitudeDegrees(2), MilesToLongitudeDegrees(2, coords.Latitude));
			//		mapView1.Region = new MKCoordinateRegion(coords, span);
			//	}
			//};

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
