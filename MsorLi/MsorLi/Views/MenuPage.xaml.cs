﻿using System;
using Xamarin.Forms;
using MsorLi.Utilities;

namespace MsorLi.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void SavedItemsClickEvent(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new SavedItemsPage());
            }

            catch (Exception)
            {
                await DisplayAlert("שגיאה", "לא ניתן לטעון מוצרים. נסה שנית מאוחר יותר.", "אישור");
            }
        }

        private async void LogOutClickEvent(object sender, EventArgs e)
        {
            try
            {
                Settings._GeneralSettings = "";
                await Navigation.PopToRootAsync();
            }
            catch (Exception)
            {
                await DisplayAlert("שגיאה", "לא ניתן להתנתק. נסה שנית מאוחר יותר.", "אישור");
            }
        }
    }
}