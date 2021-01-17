using HackatonCCR.DTO;
using HackatonCCR.Model;
using HackatonCCR.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackatonCCR.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EscolasPage : ContentPage
    {

        private ObservableCollection<EscolaDTO> lstEscolas;

        public EscolasPage()
        {
            InitializeComponent();

            lstEscolas = EscolaService.GetEscolas();
            lstEscola.ItemsSource = lstEscolas;

        }

        private async void lstEscola_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var escolaDTO = (EscolaDTO)e.SelectedItem;
            var escolaEtt = new Escola()
            {
                EscolaId = 0,
                DTO = JsonConvert.SerializeObject(escolaDTO),
            };

            await App.Database.SaveEscolaAsync(escolaEtt);

            await Navigation.PushModalAsync((Page)Activator.CreateInstance(typeof(EscolaPage)), true);
        }

        private async void OpenFilter(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync((Page)Activator.CreateInstance(typeof(FilterPage)), true);
        }



    }
}