// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamBindingSample
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton BindingsButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CommandsButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (BindingsButton != null) {
				BindingsButton.Dispose ();
				BindingsButton = null;
			}
			if (CommandsButton != null) {
				CommandsButton.Dispose ();
				CommandsButton = null;
			}
		}
	}
}
