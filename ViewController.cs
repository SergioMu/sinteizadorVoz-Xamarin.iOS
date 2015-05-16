using System;

using UIKit;
using AVFoundation;

namespace sintetizadorVoz
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			btnAcep.TouchUpInside += (sender, e) => {
				sintetizadorVoz(txtMs.Text, txtIdioma.Text);
			} ;
				
		}

		void sintetizadorVoz (String texto, String idioma){
			var sintetizador = new AVSpeechSynthesizer ();
			var ConfigSintetizador = new AVSpeechUtterance (texto) {
				Rate = AVSpeechUtterance.MinimumSpeechRate/6,
				Voice = AVSpeechSynthesisVoice.FromLanguage(idioma),
				Volume = 1f
			};
			sintetizador.SpeakUtterance (ConfigSintetizador);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

