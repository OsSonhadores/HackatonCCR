using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackatonCCR.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Logar(object sender, EventArgs e)
        {
            if (EntryEmail.Text.ToLower().Contains("empresa"))
            {
                await Navigation.PushModalAsync((Page)Activator.CreateInstance(typeof(MenuEmpresaPage)), true);
            }
            else 
            {
                await Navigation.PushModalAsync((Page)Activator.CreateInstance(typeof(MenuPage)), true);
            }
        }





    }
}