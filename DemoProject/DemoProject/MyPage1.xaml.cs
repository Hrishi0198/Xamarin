using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoProject
{
	public partial class MyPage1 : ContentPage
	{
		public MyPage1()
		{
			InitializeComponent();

		}

		
		public void
			Slider1_ValueChanged(object sender, ValueChangedEventArgs e) { label1.Text = e.NewValue.ToString(); }
    
		
	}
}

