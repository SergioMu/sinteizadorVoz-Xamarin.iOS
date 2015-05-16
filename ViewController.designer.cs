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

namespace sintetizadorVoz
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnAcep { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtIdioma { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtMs { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnAcep != null) {
				btnAcep.Dispose ();
				btnAcep = null;
			}
			if (txtIdioma != null) {
				txtIdioma.Dispose ();
				txtIdioma = null;
			}
			if (txtMs != null) {
				txtMs.Dispose ();
				txtMs = null;
			}
		}
	}
}
