using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;
using System.Runtime.Remoting.Channels;

namespace Raleys
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}


		[Test]
		public void FirstTest()
		{
			Thread.Sleep(30000);
			//app.WaitForElement(x => x.Class("XWalkCordovaView").Css(".icon-cart"), timeout: TimeSpan.FromSeconds(80));
			app.Tap(x => x.Class("XWalkCordovaView").Css(".icon-cart"));
			Thread.Sleep(2000);
			app.Screenshot("Tapped on 'Departments'");


			app.Tap(x => x.Class("XWalkCordovaView").Css(".back"));
			Thread.Sleep(2000);
			app.Screenshot("Tapped on 'Back' Button");

			app.Tap(x => x.Class("XWalkCordovaView").Css(".icon-collections"));
			Thread.Sleep(2000);
			app.Screenshot("Tapped on 'Collections'");

			app.Tap(x => x.Class("XWalkCordovaView").Css(".back"));
			Thread.Sleep(2000);
			app.Screenshot("Tapped on 'Back' Button");

			app.Tap(x => x.Class("XWalkCordovaView").Css(".icon-tag-purchased"));
			Thread.Sleep(2000);
			app.Screenshot("Tapped on 'Previous Purchases'");

			Thread.Sleep(2000);
			app.EnterText("@Microsoft Loves Raley's!");
			Thread.Sleep(2000);
			app.Screenshot("Entered in my E-Mail, '@Microsoft Loves Raley's!'");

			Thread.Sleep(2000);
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			Thread.Sleep(2000);
			//app.WaitForElement(x => x.Class("XWalkCordovaView").Css(".icon-login"), timeout: TimeSpan.FromSeconds(80));
			app.Back();
			app.Screenshot("Tapped on 'Back' Button");

			app.Tap(x => x.Class("XWalkCordovaView").Css(".icon-promo-tag"));
			Thread.Sleep(2000);
			app.Screenshot("Tapped on 'Weekly Ad'");

			app.Tap(x => x.Class("XWalkCordovaView").Css(".cell-title"));
			Thread.Sleep(2000);
			app.Screenshot("Tapped on 'Everyday Basted Turkey'");

			Thread.Sleep(2000);
			app.Tap(x => x.Class("XWalkCordovaView").Css(".select-button"));
			Thread.Sleep(2000);
			app.Screenshot("Tapped on 'Add to Cart'");

			//app.Tap(x => x.Class("XWalkCordovaView").Css(".back"));
			//Thread.Sleep(2000);
			//app.Screenshot("Tapped on 'Back' Button");

			//app.Query(x => x.Class("XWalkCordovaView").Css("body"));

		}




	}
}
