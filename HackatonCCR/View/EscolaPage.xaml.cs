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
    public partial class EscolaPage : ContentPage
    {

        private ObservableCollection<AlunoDTO> _alunos;

        public EscolaPage()
        {
            InitializeComponent();

        }

        protected async override void OnAppearing()
        {

            var escolasEtt = await App.Database.GetEscolaAsync();

            if (escolasEtt.Count > 0)
            {
                var escolaEtt = escolasEtt.FirstOrDefault();

                var escolaDTO = JsonConvert.DeserializeObject<EscolaDTO>(escolaEtt.DTO);

                EscolaName.Text = escolaDTO.Name;
                EscolaImage.Source = escolaDTO.Image;
                EscolaAlunosDisponiveis.Text = escolaDTO.AlunosDisponiveis;
                EscolaDistancia.Text = escolaDTO.Distancia;
                EscolaDistancia.Text = escolaDTO.Distancia;

                EscolaTipoInclusao1.Source = escolaDTO.TipoInclusao1;
                EscolaTipoInclusao2.Source = escolaDTO.TipoInclusao2;
                EscolaTipoInclusao3.Source = escolaDTO.TipoInclusao3;
                EscolaTipoInclusao4.Source = escolaDTO.TipoInclusao4;

                _alunos = AlunoService.GetAlunosPorEscola(escolaDTO.Name);

                lstAlunos.ItemsSource = _alunos;

            }




            base.OnAppearing();
        }

        private async void VerAluno(object sender, SelectedItemChangedEventArgs e)
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






    }
}