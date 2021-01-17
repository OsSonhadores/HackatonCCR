using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HackatonCCR.View;
using HackatonCCR.Repository;
using System.IO;

namespace HackatonCCR
{
    public partial class App : Application
    {

        static Repository.Repository database;
        public static Repository.Repository Database
        {
            get
            {
                if (database == null)
                {
                    database = new Repository.Repository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Alunos2.db3"));
                }
                return database;
            }
        }


        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
