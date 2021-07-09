using System;
using TNTGoClone.Views;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace TNTGoClone
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainView();
		}

		protected override Window CreateWindow(IActivationState activationState)
        {
        	return new Microsoft.Maui.Controls.Window(new MainView());
        }

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
