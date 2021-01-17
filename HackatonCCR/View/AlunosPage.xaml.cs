﻿using HackatonCCR.Model;
using HackatonCCR.Service;
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

        private ObservableCollection<Aluno> lstAlunos;

        public AlunosPage()
        {
            InitializeComponent();

            lstAlunos = AlunoService.GetAlunos();
            lstAluno.ItemsSource = lstAlunos;

        }


        private async void lstAluno_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //TODO:  salva o id do aluno
            await Navigation.PushModalAsync((Page)Activator.CreateInstance(typeof(AlunoPage)), true);
        }


    }
}