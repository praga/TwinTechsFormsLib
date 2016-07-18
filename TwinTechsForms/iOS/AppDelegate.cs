using Foundation;
using UIKit;
using TwinTechs;
using TwinTechs.Gestures;

namespace TwinTechsFormsExample.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			GestureRecognizerExtensions.Factory = new NativeGestureRecognizerFactory ();

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

