using System;

using Xamarin.Forms;
using TwinTechs.Example;
using TwinTechs.Example.Gestures;

namespace TwinTechs
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage (new LongPressGestureExample());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

