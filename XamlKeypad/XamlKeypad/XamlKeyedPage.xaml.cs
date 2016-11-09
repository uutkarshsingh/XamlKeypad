using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamlKeypad
{
	public partial class XamlKeyedPage : ContentPage
	{
		public XamlKeyedPage()
		{
			InitializeComponent();
		}

		public void OnDigitButtonChanged(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("Digit tapped");		
		}
		public void OnBackspaceButtonCLicked(object sender, EventArgs e)
		{ 
			System.Diagnostics.Debug.WriteLine("BackSpace tapped");
		}
	}
}
