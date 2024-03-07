using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loteria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinPage : ContentPage
    {
        public WinPage()
        {
            InitializeComponent();
            WinsList.ItemsSource = App.Database.Wypisz<Result>();
        }

        private void wyszukaj_TextChanged(object sender, TextChangedEventArgs e)
        {

            List<Result> wonList = App.Database.Wypisz<Result>();
            List<Result> newList = wonList.Where(win => win.Id.ToString().Contains(search.Text)).ToList();
            WinsList.ItemsSource = newList;

        }
    }
}