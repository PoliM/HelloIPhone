// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace HelloIPhone
{
	[Register ("FlipsideViewController")]
	partial class FlipsideViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField DailyGoal { get; set; }

		[Action ("done:")]
		partial void done (MonoTouch.UIKit.UIBarButtonItem sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DailyGoal != null) {
				DailyGoal.Dispose ();
				DailyGoal = null;
			}
		}
	}
}
