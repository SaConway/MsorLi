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
            if (Settings.UserId != "")
            {
                UserName.Text = "שלום " + Settings.UserFirstName;
                UserImg.Source = Settings.ImgUrl;
                logButton.Text = "התנתק";
            }
            else
            {
                UserName.Text = "שלום אורח";
                UserImg.Source = "unknown-user.png";
                logButton.Text = "התחבר";
            }

        }
        protected async override void OnAppearing()

        {
            try
            {
                //if (Settings.UserId != "")
                //{
                //    UserName.Text = "שלום " + Settings.UserFirstName;
                //    UserImg.Source = Settings.ImgUrl;
                //    logButton.Text = "התנתק";
                //}
                //else
                //{
                //    UserName.Text = "שלום אורח";
                //    UserImg.Source = "unknown-user.png";
                //    logButton.Text = "התחבר";
                //}
            }
            catch
            {
                await DisplayAlert("שגיאה", "לא ניתן לטעון נתונים", "אישור");
            }
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

        private async void LogbuttonClickEvent(object sender, EventArgs e)
        {
            try
            {
                //if user is looged and pressed logout
                if (Settings.UserId != ""){
                    Settings.UserId = "";
					await Navigation.PopToRootAsync();
                    Settings.ClearUserData();
                }
                else
                    await Navigation.PushAsync(new LoginPage());
            }
            catch (Exception)
            {
                await DisplayAlert("שגיאה", "לא ניתן להתנתק. נסה שנית מאוחר יותר.", "אישור");
            }
        }
        private async void ProfileClickEvent(object sender, EventArgs e)
        {
            try
            {
               await Navigation.PushAsync(new ProfilePage());
            }
            catch (Exception)
            {
                //await DisplayAlert("שגיאה", "לא ניתן להתנתק. נסה שנית מאוחר יותר.", "אישור");
            }
        }
    }
}