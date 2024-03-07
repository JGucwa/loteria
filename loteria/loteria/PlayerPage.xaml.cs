using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loteria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerPage : ContentPage
    {
        public PlayerPage()
        {
            InitializeComponent();
        }
        private void applied_Clicked(object sender, EventArgs e)
        {
            Player nowygracz = new Player(firstname.Text, surname.Text, email.Text, code.Text);
            if (firstname.Text != "" && surname.Text != "" && email.Text != "" && code.Text != "" &&
                Regex.IsMatch(email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$") && Regex.IsMatch(code.Text, @"^[0-9]{9}$"))
            {
                App.Database.Zapisz(nowygracz);
                DisplayAlert("informacja", "Wziales udzial w loterii", "OK");
                Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("Blad", "Pola uzupelnione niepoprawnie", "OK");
            }

            firstname.Text = "";
            surname.Text = "";
            email.Text = "";
            code.Text = "";
        }
    }
}