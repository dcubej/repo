	using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace Phoneword.UITests
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			//app = ConfigureApp.Android.DeviceSerial("745e31e90ffc2365").InstalledApp("com.companyname.phoneword").StartApp();
			app = ConfigureApp.Android.DeviceSerial("emulator-5554").InstalledApp("com.companyname.phoneword").StartApp();
			//app = ConfigureApp.Android.DeviceSerial("emulator-5554").ApkFile("/Users/idir/Desktop/com.companyname.phoneword.apk").StartApp();
		}

		[Test]
		public void NewTest()
		{


		
			app.Tap(x => x.Id("PhoneNumberText"));
			app.Screenshot("Tapped on view with class: EditText");
			app.ClearText(x => x.Id("PhoneNumberText"));
			app.EnterText(x => x.Id("PhoneNumberText"), "testrecorder");
			app.Tap(x => x.Id("TranslateButton"));
			app.Screenshot("Tapped on view with class: Button");
			AppResult[] result = app.Query(x => x.Id("CallButton").Text("Call 837873267337"));
			Assert.IsTrue(result.Any(), "Th e number is not being displayed.");
					
		}
	}
}

