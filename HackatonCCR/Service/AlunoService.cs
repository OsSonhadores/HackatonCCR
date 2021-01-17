using HackatonCCR.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HackatonCCR.Service
{
    public class AlunoService
    {
        private static ObservableCollection<AlunoDTO> lista;

        public static ObservableCollection<AlunoDTO> GetAlunos()
        {

            lista = new ObservableCollection<AlunoDTO>();

            var aluno1 = new AlunoDTO()
            {
                AlunoId = 1,
                Name = "Pablo Rocha Silva",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Image = "aluno1",
                Age = 16,
                Institution = "Escola Estadual Martins Pena",
                TipoInclusao = "VisualBaixaIcon",
                Distancia = "10.5 KM",
                Laudo = "https://blog.freedom.ind.br/laudo-medico-pcd/",
                HabilidadePrincipal = "Trabalho Em Grupo",
                Comunicacao = 60,
                Flexibilidade = 80,
                HabilidadesInterpessoais = 30,
                ResolucaoDeProblema = 90,
                TrabalhoEmGrupo = 100,
                TrabalhoEtico = 80,
                Lideranca = 50,
            };

            var aluno2 = new AlunoDTO()
            {
                AlunoId = 2,
                Name = "Leticia Balbino",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Image = "aluno2",
                Age = 17,
                Institution = "Escola Estadual Martins Pena",
                TipoInclusao = "VisualGraveIcon",
                Distancia = "8.2 KM",
                Laudo = "https://blog.freedom.ind.br/laudo-medico-pcd/",
                HabilidadePrincipal = "Trabalho Em Grupo",
                Comunicacao = 60,
                Flexibilidade = 80,
                HabilidadesInterpessoais = 30,
                ResolucaoDeProblema = 90,
                TrabalhoEmGrupo = 100,
                TrabalhoEtico = 80,
                Lideranca = 50,
            };

            var aluno3 = new AlunoDTO()
            {
                AlunoId = 3,
                Name = "Ana Souza",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Image = "aluno3",
                Age = 14,
                Institution = "Escola Estadual Martins Pena",
                TipoInclusao = "CadeiranteIcon",
                Distancia = "2.3 KM",
                Laudo = "https://blog.freedom.ind.br/laudo-medico-pcd/",
                HabilidadePrincipal = "Trabalho Em Grupo",
                Comunicacao = 60,
                Flexibilidade = 80,
                HabilidadesInterpessoais = 30,
                ResolucaoDeProblema = 90,
                TrabalhoEmGrupo = 100,
                TrabalhoEtico = 80,
                Lideranca = 50,
            };

            var aluno4 = new AlunoDTO()
            {
                AlunoId = 4,
                Name = "Renato Kondo",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Image = "aluno4",
                Age = 17,
                Institution = "Escola Estadual Martins Pena",
                TipoInclusao = "CadeiranteIcon",
                Distancia = "1.9 KM",
                Laudo = "https://blog.freedom.ind.br/laudo-medico-pcd/",
                HabilidadePrincipal = "Trabalho Em Grupo",
                Comunicacao = 60,
                Flexibilidade = 80,
                HabilidadesInterpessoais = 30,
                ResolucaoDeProblema = 90,
                TrabalhoEmGrupo = 100,
                TrabalhoEtico = 80,
                Lideranca = 50,
            };

            var aluno5 = new AlunoDTO()
            {
                AlunoId = 5,
                Name = "Amanda Silva",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Image = "aluno5",
                Age = 16,
                Institution = "Escola Estadual Martins Pena",
                TipoInclusao = "BaixaRendaIcon",
                Distancia = "1.0 KM",
                Laudo = "https://blog.freedom.ind.br/laudo-medico-pcd/",
                HabilidadePrincipal = "Comunicação",
                Comunicacao = 100,
                Flexibilidade = 80,
                HabilidadesInterpessoais = 70,
                ResolucaoDeProblema = 90,
                TrabalhoEmGrupo = 70,
                TrabalhoEtico = 80,
                Lideranca = 60,
            };

            var aluno6 = new AlunoDTO()
            {
                AlunoId = 6,
                Name = "Jonas Algusto",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Image = "aluno6",
                Age = 17,
                Institution = "Escola Estadual Martins Pena",
                TipoInclusao = "BaixaRendaIcon",
                Distancia = "3.6 KM",
                Laudo = "https://blog.freedom.ind.br/laudo-medico-pcd/",
                HabilidadePrincipal = "Resolucao De Problema",
                Comunicacao = 60,
                Flexibilidade = 80,
                HabilidadesInterpessoais = 30,
                ResolucaoDeProblema = 100,
                TrabalhoEmGrupo = 70,
                TrabalhoEtico = 80,
                Lideranca = 60,
            };

            var aluno7 = new AlunoDTO()
            {
                AlunoId = 7,
                Name = "Lucas Vieira Da Silva",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Image = "aluno7",
                Age = 17,
                Institution = "Escola Estadual Martins Pena",
                TipoInclusao = "AltismoIcon",
                Distancia = "0.5 KM",
                Laudo = "https://blog.freedom.ind.br/laudo-medico-pcd/",
                HabilidadePrincipal = "Trabalho Etico",

                Comunicacao = 60,
                Flexibilidade = 80,
                HabilidadesInterpessoais = 30,
                ResolucaoDeProblema = 90,
                TrabalhoEmGrupo = 70,
                TrabalhoEtico = 100,
                Lideranca = 90,
            };

            var aluno8 = new AlunoDTO()
            {
                AlunoId = 8,
                Name = "Joana Pereira",
                Infos = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Image = "aluno8",
                Age = 16,
                Institution = "Escola Estadual Martins Pena",
                TipoInclusao = "BaixaRendaIcon",
                Distancia = "0.2 KM",
                Laudo = "https://blog.freedom.ind.br/laudo-medico-pcd/",
                HabilidadePrincipal = "Lideranca",
                Comunicacao = 60,
                Flexibilidade = 80,
                HabilidadesInterpessoais = 30,
                ResolucaoDeProblema = 90,
                TrabalhoEmGrupo = 70,
                TrabalhoEtico = 80,
                Lideranca = 100,
            
            };



            lista.Add(aluno7);
            lista.Add(aluno4);
            lista.Add(aluno1);
            lista.Add(aluno5);
            lista.Add(aluno2);
            lista.Add(aluno6);
            lista.Add(aluno3);
            lista.Add(aluno8);

            return lista;
        }









    }
}
