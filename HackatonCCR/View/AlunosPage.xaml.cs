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
    public partial class AlunosPage : ContentPage
    {

        private ObservableCollection<AlunoDTO> lstAlunos;

        public AlunosPage()
        {
            InitializeComponent();

            lstAlunos = AlunoService.GetAlunos();
            lstAluno.ItemsSource = lstAlunos;

        }


        private async void lstAluno_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var alunoDTO = (AlunoDTO)e.SelectedItem;
            var alunoEtt = new Aluno()
            {
                AlunoId = 0,
                DTO = JsonConvert.SerializeObject(alunoDTO),
            };

            await App.Database.SaveAlunoAsync(alunoEtt);

            await Navigation.PushModalAsync((Page)Activator.CreateInstance(typeof(AlunoPage)), true);
        }

        private async void OpenFilter(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync((Page)Activator.CreateInstance(typeof(FilterPage)), true);
        }






    }
}