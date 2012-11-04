using System;
using MonoTouch.UIKit;

namespace HelloIPhone
{
	public class TabBarController: UITabBarController
	{

		UIViewController mainTab;
		UIViewController historyTab;

		public TabBarController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			mainTab = new MainViewController ();
			mainTab.Title = "Main";

			historyTab = new History ();
			historyTab.Title = "History";
			historyTab.TabBarItem = new UITabBarItem (UITabBarSystemItem.History, 0);
				
			var tabs = new UIViewController[]{mainTab, historyTab};
			ViewControllers = tabs;
			SelectedViewController = mainTab;
		}
	}
}

