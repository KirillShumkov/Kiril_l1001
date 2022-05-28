using System;

using AppKit;
using Foundation;

namespace OOPGUI
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		private NSViewController _Presentor;

		public NSViewController Presentor
		{
			get { return _Presentor; }
			set { _Presentor = value; }
		}

		private void CloseDialog()
		{
			Presentor.DismissViewController(this);
		}

		partial void Register1(Foundation.NSObject sender)
		{
			RaiseDialogRegister1();
			CloseDialog();
		}


		public EventHandler DialogRegister1;

		internal void RaiseDialogRegister1()
		{
			if (this.DialogRegister1 != null)
				this.DialogRegister1(this, EventArgs.Empty);
		}

		

		public override void PrepareForSegue(NSStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			// Take action based on the segue name
			switch (segue.Identifier)
			{
				case "ModalSegue":
					var dialog = segue.DestinationController as CustomDialogController;
					dialog.DialogTitle = "Пажалуйста укажите свой номер телефона, и мы свяжемся с вами в ближайшее время";
					dialog.DialogDescription = "Введите номер телефона:";

					dialog.Presentor = this;
					break;
			
				case "ModalSegueRegister":
					var dialogR = segue.DestinationController as Register;
					dialogR.DialogLogin = "";
					dialogR.Dialogpassword = "";
					dialogR.Dialogpasswordagain = "";

					dialogR.Presentor = this;

					break;

				case "ModalSegueRegister2":
					var dialogR2 = segue.DestinationController as Register;
					dialogR2.DialogLogin = "";
					dialogR2.Dialogpassword = "";
					dialogR2.Dialogpasswordagain = "";

					dialogR2.Presentor = this;

					break;

				case "ModalSegueEntry":
					var dialogE = segue.DestinationController as Entry;
					dialogE.Presentor = this;
					break;

				case "ModalSegueEntry2":
					var dialogE2 = segue.DestinationController as Entry;
					dialogE2.Presentor = this;
					break;
			}
		}
	}
}
