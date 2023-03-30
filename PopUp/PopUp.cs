using System;

using Xamarin.Forms;

namespace PopUp
{
	public class PopUp : ContentPage
	{
		public PopUp ()
		{
            Button alert = new Button
            {
                Text = "Teade",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center
            };
            alert.Clicked += Alert_Clicked;
            Button alertYesNo = new Button
            {
                Text = "Jah või Ei",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center
            };
            alertYesNo.Clicked += AlertYesNo_Clicked;
            Button alertList = new Button
            {
                Text = "Valik",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center
            };
            alertList.Clicked += AlertList_Clicked;
            Button alertQuest = new Button
            {
                Text = "Küsimus",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center
            };
            alertQuest.Clicked += AlertQuest_Clicked;
            Content = new StackLayout { Children = { alert, alertYesNo, alertList, alertQuest } };
        }

        private async void AlertQuest_Clicked(object sender, EventArgs e)
        {
            string result1 = await DisplayPromptAsync("Küsimus", "Kuidas läheb?", placeholder: "Tore!");
            string result2 = await DisplayPromptAsync("Vasta", "Millega võrdub 5 + 5", initialValue: "10", maxLength: 2, keyboard: Keyboard.Numeric);
        }

        private async void AlertList_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Mida teha?", "Loobu", "Kustutada", "Tantsida", "Laulda", "Joonistada");
        }

        private async void AlertYesNo_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Kinnitus", "Kas oled kindel?", "Olen kindel", "Ei ole kindel");
            await DisplayAlert("Teade", "Teie valik on: " + (result ? "Jah" : "Ei"), "OK");
        }

        private void Alert_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Teade", "Teil on uus teade", "Ok");
        }
    }
}


