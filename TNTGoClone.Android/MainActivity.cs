using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Maui;

namespace TNTGoClone.Droid
{
	[Activity(Label = "TNTGoClone", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : MauiAppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			// this.TabLayoutResource = Resource.Layout.Tabbar;
			// this.ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(savedInstanceState);
		}
		// public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
		// {
		// 	// Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

		// 	base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
		// }
	}
}