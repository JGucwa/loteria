using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace loteria
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Player_nav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PlayerPage());
        }

        private void Admin_Nnav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminPage());
        }

        private void Result_nav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WinPage());
        }
    }
}
