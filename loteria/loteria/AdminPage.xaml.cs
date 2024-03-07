using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loteria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminPage : ContentPage
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        void SendMail(string doKogo, string tytul, string opis)
        {
            MailMessage wiadomosc = new MailMessage("sprawdziangit@outlook.com", doKogo, tytul, opis);
            SmtpClient klient = new SmtpClient("smtp-mail.outlook.com", 587);
            klient.EnableSsl = true;
            klient.Credentials = new NetworkCredential("sprawdziangit@outlook.com", "Haslo123");
            klient.UseDefaultCredentials = false;
            klient.Send(wiadomosc);
        }

        private void lotery_Clicked(object sender, EventArgs e)
        {
            int licznikWygranych = 0;
            Random losowa = new Random();
            string wynik = "";
            for (int i = 0; i < 9; i++)
            {
                wynik += losowa.Next(0, 10);
            }
            List<Player> listaGraczy = App.Database.Wypisz<Player>();
            foreach (Player gracz in listaGraczy)
            {
                if (gracz.Code == wynik)
                {
                    //SendMail(gracz.Email, "Gratuluje wygranej!", "Proszę o kontakt pod adresem Limanowa 22. \nPozdrawiamy zespół lotto.");
                    licznikWygranych++;
                }
            }
            Result dodawanyWynik = new Result(DateTime.Now, wynik, licznikWygranych);
            App.Database.Zapisz(dodawanyWynik);
            loterydate.Text = "Data losowania: " + dodawanyWynik.LoteryDate.ToString();
            wonCount.Text = "Ilosc wygranych: " + licznikWygranych.ToString();
            wonCode.Text = "Wygrany kod: " + wynik;
        }

        private void allwin_Clicked(object sender, EventArgs e)
        {
            int licznikWygranych = 0;
            string wynik = "kazdy wygrywa";

            List<Player> listaGraczy = App.Database.Wypisz<Player>();
            foreach (Player gracz in listaGraczy)
            {
                //SendMail(gracz.Email, "Gratuluje wygranej!", "Proszę o kontakt pod adresem Limanowa 22. \nPozdrawiamy zespół lotto.");
                licznikWygranych++;
            }

            Result dodawanyWynik = new Result(DateTime.Now, wynik, licznikWygranych);
            App.Database.Zapisz(dodawanyWynik);
            loterydate.Text = "Data losowania: " + dodawanyWynik.LoteryDate.ToString();
            wonCount.Text = "Ilosc wygranych: " + licznikWygranych.ToString();
            wonCode.Text = "Wygrany kod: " + wynik;
        }
    }
}