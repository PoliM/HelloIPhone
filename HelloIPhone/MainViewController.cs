using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;

namespace HelloIPhone
{
	public partial class MainViewController : UIViewController
	{
		private History history;

		public MainViewController () : base ("MainViewController", null)
		{
			// Custom initialization
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			Total.Text = "0 grams";
			Amount.ShouldReturn = (s) => 
			{
				Amount.ResignFirstResponder ();
				return true;
			};

//			UILabel newLabel = new UILabel (new RectangleF (10, 0, 300, 100));
//			newLabel.Text = "Dynamic Content";
//			View.AddSubview (newLabel);
//
//			Amount.EditingChanged += (object sender, EventArgs e) => {
//				newLabel.Text = "Editing Changed";
//			}; 
//
//			Amount.ValueChanged += (object sender, EventArgs e) => {
//				newLabel.Text = "ValueChanged";
//			};
//			Amount.EditingDidEnd += (object sender, EventArgs e) => {
//				newLabel.Text = "EditingDidEnd";
//			};
//
			EnterButton.TouchUpInside += (sender, e) => 
			{
				Total.Text = Amount.Text;
				Amount.Text = "";
			};

			HistoryButton.TouchUpInside += (sender, e) => {
				history = new History ();
				history.ModalTransitionStyle = UIModalTransitionStyle.PartialCurl;
				history.Done += (sender2, e2) => {
					DismissModalViewControllerAnimated (true);
				};

				PresentModalViewController (history, true);
				
			};

			ResetButton.TouchUpInside += (sender, e) => {
				var alert = new UIActionSheet ("Reset?", null, "Cancel", "Reset", "?");
				alert.Clicked += HandleAlertClicked;
				alert.ShowInView (ParentViewController.View);
			};
		}

		void HandleAlertClicked (object sender, UIButtonEventArgs e)
		{
			UIActionSheet alert = (UIActionSheet)sender;
			if (e.ButtonIndex == alert.CancelButtonIndex) {
				var al2 = new UIAlertView ("Canceled", "Canceled", null, "Ok");
				al2.Show ();
			} else if (e.ButtonIndex == alert.DestructiveButtonIndex) {
				var al2 = new UIAlertView ("Ok", "Ok", null, "Ok");
				al2.Show ();
			} else {
				var al2 = new UIAlertView ("Hä?", "What?", null, "Ok");
				al2.Show ();
			}
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			GoalText.Text = NSUserDefaults.StandardUserDefaults.StringForKey ("goal") + " grams";

//			NavigationController.SetNavigationBarHidden (true, animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
//			NavigationController.SetNavigationBarHidden (false, animated);
		}
		partial void EnterClicked (NSObject sender)
		{
//			Total.Text = Amount.Text;
//			Amount.Text = "";
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		partial void showInfo (NSObject sender)
		{
			var controller = new FlipsideViewController () {
				ModalTransitionStyle = UIModalTransitionStyle.FlipHorizontal,
			};
			
			controller.Done += delegate {
				DismissModalViewControllerAnimated (true);
			};
			
			PresentModalViewController (controller, true);
		}
	}
}

