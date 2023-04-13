using System;

using Xamarin.Forms;

namespace PopUp
{
	public class PopUpWork : ContentPage
	{
		public PopUpWork ()
		{
            BackgroundImageSource = "pretty.jpg";
            Button hc = new Button
            {
                Text = "Hot/Cold",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.HotPink
            };
            hc.Clicked += Hc_Clicked;
            Button tf = new Button
            {
                Text = "True/False",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.LightBlue
            };
            tf.Clicked += Tf_Clicked;
            Button ei = new Button
            {
                Text = "Exterior/Interior",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.DarkBlue,
                TextColor = Color.WhiteSmoke
            };
            ei.Clicked += Ei_Clicked;
            Button sm = new Button
            {
                Text = "Servant/Master",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Purple
            };
            sm.Clicked += Sm_Clicked;
            Button wf = new Button
            {
                Text = "Wise/Foolish",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.WhiteSmoke
            };
            wf.Clicked += Wf_Clicked;
            Content = new StackLayout { Children = { hc, tf, ei, sm, wf } };
        }

        private async void Wf_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Wise/Foolish", "Which of these two antonyms you want to learn about first?", "Wise", "Foolish");
            await DisplayAlert("Meaning", "Your word was: " + (result ? "Wise" + " " +
                "-" + " " + "Having or showing experience, knowledge, and good judgement(мудрый)" : "Foolish" + " " + "-" + " " + "Lacking good sense or judgement(глуп)"), "OK"); 
        }

        private async void Sm_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Servant/Master", "Which of these two antonyms you want to learn about first?", "Servant", "Master");
            await DisplayAlert("Meaning", "Your word was: " + (result ? "Servant" + " " +
                "-" + " " + "A person who performs duties for others(прислуга)" : "Master" + " " + "-" + " " + "A man who has people working for him(мастер)"), "OK");
        }

        private async void Ei_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Exterior/Interior", "Which of these two antonyms you want to learn about first?", "Exterior", "Interior");
            await DisplayAlert("Meaning", "Your word was: " + (result ? "Exterior" + " " +
                "-" + " " + "The outer surface or structure of something(экстерьер)" : "Interior" + " " + "-" + " " + "The inner part of something; the inside(интерьер)"), "OK");
        }

        private async void Tf_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("True/False", "Which of these two antonyms you want to learn about first?", "True", "False");
            await DisplayAlert("Meaning", "Your word was: " + (result ? "True" + " " +
                "-" + " " + "In accordance with fact or reality(истина)" : "False" + " " + "-" + " " + "Not according with truth or fact(ложь)"), "OK");
        }

        private async void Hc_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Hot/Cold", "Which of these two antonyms you want to learn about first?", "Hot", "Cold");
            await DisplayAlert("Meaning", "Your word was: " + (result ? "Hot" + " " +
                "-" + " " + "Having a high degree of heat or a high temperature(горячий)" : "Cold" + " " + "-" + " " + "Low or relatively low temperature, especially when compared with the human body(холодный)"), "OK");
        }
    }
}

 
