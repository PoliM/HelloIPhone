using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;

namespace HelloIPhone
{
	public partial class MainViewController : UIViewController
	{
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
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			GoalText.Text = NSUserDefaults.StandardUserDefaults.StringForKey ("goal") + " grams";
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

