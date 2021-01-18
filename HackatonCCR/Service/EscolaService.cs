using HackatonCCR.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HackatonCCR.Service
{
    public class EscolaService
    {
        private static ObservableCollection<EscolaDTO> lista;

        public static ObservableCollection<EscolaDTO> GetEscolas()
        {

            lista = new ObservableCollection<EscolaDTO>();

            var escola1 = new EscolaDTO()
            {
                EscolaId = 1,
                Name = "E. E. Souza Lima",
                Image = "EscolasDefaultIcon",
                Distancia = "10.5 KM",
                AlunosDisponiveis = "2",
                TipoInclusao3 = "AltismoIcon",
                TipoInclusao1 = "VisualGraveIcon",
                TipoInclusao2 = "VisualBaixaIcon",
                TipoInclusao4 = "CadeiranteIcon",
            };

            var escola2 = new EscolaDTO()
            {
                EscolaId = 2,
                Name = "ONG Acolher E Cuidar",
                Image = "EscolasDefaultIcon",
                Distancia = "3.5 KM",
                AlunosDisponiveis = "2",
                TipoInclusao2 = "BaixaRendaIcon",
                TipoInclusao4 = "VisualBaixaIcon",
                TipoInclusao3 = "AltismoIcon",
                TipoInclusao1 = "VisualGraveIcon",
            };

            var escola3 = new EscolaDTO()
            {
                EscolaId = 3,
                Name = "E. E. Dona Gonçalves",
                Image = "EscolasDefaultIcon",
                Distancia = "7.5 KM",
                AlunosDisponiveis = "2",
                TipoInclusao2 = "BaixaRendaIcon",
                TipoInclusao1 = "VisualGraveIcon",
                TipoInclusao3 = "AltismoIcon",
                TipoInclusao4 = "CadeiranteIcon",
            };

            var escola4 = new EscolaDTO()
            {
                EscolaId = 3,
                Name = "ONG Saber E Ensinar",
                Image = "EscolasDefaultIcon",
                Distancia = "1.5 KM",
                AlunosDisponiveis = "2",
                TipoInclusao1 = "VisualGraveIcon",
                TipoInclusao2 = "BaixaRendaIcon",
                TipoInclusao3 = "VisualBaixaIcon",
                TipoInclusao4 = "CadeiranteIcon",
            };

            lista.Add(escola1);
            lista.Add(escola2);
            lista.Add(escola3);
            lista.Add(escola4);

            return lista;
        }




    }
}
