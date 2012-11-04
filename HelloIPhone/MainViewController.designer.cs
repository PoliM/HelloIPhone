// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace HelloIPhone
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton HistoryButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel GoalText { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel asd { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton EnterButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField Amount { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel Total { get; set; }

		[Action ("EnterClicked:")]
		partial void EnterClicked (MonoTouch.Foundation.NSObject sender);

		[Action ("showInfo:")]
		partial void showInfo (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (HistoryButton != null) {
				HistoryButton.Dispose ();
				HistoryButton = null;
			}

			if (GoalText != null) {
				GoalText.Dispose ();
				GoalText = null;
			}

			if (asd != null) {
				asd.Dispose ();
				asd = null;
			}

			if (EnterButton != null) {
				EnterButton.Dispose ();
				EnterButton = null;
			}

			if (Amount != null) {
				Amount.Dispose ();
				Amount = null;
			}

			if (Total != null) {
				Total.Dispose ();
				Total = null;
			}
		}
	}
}
