using System;
using Android.App;
using Android.Runtime;
using Microsoft.Maui;
using TNTGoClone;

namespace TNTGoClone.Droid
{
	[Application]
	public class MainApplication : MauiApplication<Startup>
	{
		public MainApplication(IntPtr handle, JniHandleOwnership ownership)
			: base(handle, ownership)
		{
		}
	}
}