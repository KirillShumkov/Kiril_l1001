// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace OOPGUI
{
	[Register ("Register")]
	partial class Register
	{
		[Outlet]
		AppKit.NSTextField Login { get; set; }

		[Outlet]
		AppKit.NSTextField Password { get; set; }

		[Outlet]
		AppKit.NSTextField Passwordagain { get; set; }

		[Action ("BackR:")]
		partial void BackR (Foundation.NSObject sender);

		[Action ("ExitR:")]
		partial void ExitR (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (Login != null) {
				Login.Dispose ();
				Login = null;
			}

			if (Password != null) {
				Password.Dispose ();
				Password = null;
			}

			if (Passwordagain != null) {
				Passwordagain.Dispose ();
				Passwordagain = null;
			}
		}
	}
}
