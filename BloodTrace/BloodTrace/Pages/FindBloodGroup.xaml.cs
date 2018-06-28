﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BloodTrace.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FindBloodGroup : ContentPage
	{
		public FindBloodGroup ()
		{
			InitializeComponent ();
		}

        private void BtnSearch_Clicked(object sender, EventArgs e)
        {
            var country = PickerCountry.Items[PickerCountry.SelectedIndex];
            var bloodGroup = PickerBloodGroup.Items[PickerBloodGroup.SelectedIndex].Trim().Replace("+", "%2B");

            Navigation.PushAsync(new DonorsListPage(country, bloodGroup));
        }
    }
}