using HackatonCCR.Model;
using Newtonsoft.Json;
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
    public partial class AlunoPage : ContentPage
    {

        public AlunoPage()
        {
            BindingContext = this;
            InitializeComponent();

        }


        protected override async void OnAppearing()
        {

            var alunos = await App.Database.GetAlunoAsync();

            if (alunos.Count > 0)
            {
                var alunoEtt = alunos.FirstOrDefault();
                var alunoDTO = JsonConvert.DeserializeObject<AlunoDTO>(alunoEtt.DTO);
                AlunoName.Text = alunoDTO.Name;
                AlunoImage.Source = alunoDTO.Image;
                AlunoAge.Text = alunoDTO.Age.ToString();
                AlunoInstitution.Text = alunoDTO.Institution;

                AlunoLideranca.Text = alunoDTO.Lideranca.ToString();
                AlunoHabilidadesInterpessoais.Text = alunoDTO.HabilidadesInterpessoais.ToString();
                AlunoTrabalhoEmGrupo.Text = alunoDTO.TrabalhoEmGrupo.ToString();
                AlunoTrabalhoEtico.Text = alunoDTO.TrabalhoEtico.ToString();
                AlunoResolucaoDeProblema.Text = alunoDTO.ResolucaoDeProblema.ToString();
                AlunoFlexibilidade.Text = alunoDTO.Flexibilidade.ToString();
                AlunoComunicacao.Text = alunoDTO.Comunicacao.ToString();

                await App.Database.DeleteAlunoAsync(alunos.FirstOrDefault());
            }

            base.OnAppearing();
        }

        private void MudaLideranca(object sender, ValueChangedEventArgs e)
        {
            AlunoLideranca.Text = Convert.ToInt32(e.NewValue).ToString();
        }

        private void MudaTrabalhoEmGrupo(object sender, ValueChangedEventArgs e)
        {
            AlunoTrabalhoEmGrupo.Text = Convert.ToInt32(e.NewValue).ToString();
        }

        private void MudaComunicacao(object sender, ValueChangedEventArgs e)
        {
            AlunoComunicacao.Text = Convert.ToInt32(e.NewValue).ToString();
        }

        private void MudaResolucaoDeProblema(object sender, ValueChangedEventArgs e)
        {
            AlunoResolucaoDeProblema.Text = Convert.ToInt32(e.NewValue).ToString();
        }

        private void MudaFlexibilidade(object sender, ValueChangedEventArgs e)
        {
            AlunoFlexibilidade.Text = Convert.ToInt32(e.NewValue).ToString();
        }

        private void MudaHabilidadesInterpessoais(object sender, ValueChangedEventArgs e)
        {
            AlunoHabilidadesInterpessoais.Text = Convert.ToInt32(e.NewValue).ToString();
        }

        private void MudaTrabalhoEtico(object sender, ValueChangedEventArgs e)
        {
            AlunoTrabalhoEtico.Text = Convert.ToInt32(e.NewValue).ToString();
        }




    }
}