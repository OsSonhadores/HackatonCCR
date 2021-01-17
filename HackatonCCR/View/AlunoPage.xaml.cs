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
                SliderLideranca.Value = alunoDTO.Lideranca;

                AlunoHabilidadesInterpessoais.Text = alunoDTO.HabilidadesInterpessoais.ToString();
                SliderHabilidadesInterpessoais.Value = alunoDTO.HabilidadesInterpessoais;

                AlunoTrabalhoEmGrupo.Text = alunoDTO.TrabalhoEmGrupo.ToString();
                SliderTrabalhoEmGrupo.Value = alunoDTO.TrabalhoEmGrupo;

                AlunoTrabalhoEtico.Text = alunoDTO.TrabalhoEtico.ToString();
                SliderTrabalhoEtico.Value = alunoDTO.ResolucaoDeProblema;

                AlunoResolucaoDeProblema.Text = alunoDTO.ResolucaoDeProblema.ToString();
                SliderResolucaoDeProblema.Value = alunoDTO.ResolucaoDeProblema;

                AlunoFlexibilidade.Text = alunoDTO.Flexibilidade.ToString();
                SliderFlexibilidade.Value = alunoDTO.Flexibilidade;

                AlunoComunicacao.Text = alunoDTO.Comunicacao.ToString();
                SliderComunicacao.Value = alunoDTO.Comunicacao;


                imgBtnTipoInclusao.Source = alunoDTO.TipoInclusao;
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