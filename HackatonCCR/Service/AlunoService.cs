using HackatonCCR.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HackatonCCR.Service
{
    public class AlunoService
    {
        private static ObservableCollection<Aluno> lista;

        public static ObservableCollection<Aluno> GetAlunos()
        {
            lista = new ObservableCollection<Aluno>();

            var aluno1 = new Aluno()
            {
                AlunoId = 1,
                Name = "Pablo Rocha Silva",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Image = "aluno1",                
            };

            var aluno2 = new Aluno()
            {
                AlunoId = 2,
                Name = "Leticia Balbino",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Image = "aluno2",
            };

            var aluno3 = new Aluno()
            {
                AlunoId = 3,
                Name = "Ana Souza",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Image = "aluno3",
            };

            var aluno4 = new Aluno()
            {
                AlunoId = 4,
                Name = "Flavio Andrade",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Image = "aluno4",
            };

            var aluno5 = new Aluno()
            {
                AlunoId = 6,
                Name = "Amanda Silva",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Image = "aluno5",
            };

            lista.Add(aluno1);
            lista.Add(aluno2);
            lista.Add(aluno3);
            lista.Add(aluno4);
            lista.Add(aluno5);

            return lista;
        }

    }
}
