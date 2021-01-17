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
                Name = "Escola Estadual Souza Lima",
                Image = "EscolaIconDefaut",
                Distancia = "10.5 KM",
                AlunosDisponiveis = "15",
                TipoInclusao1 = "VisualGraveIcon",
                TipoInclusao2 = "BaixaRendaIcon",
                TipoInclusao3 = "AltismoIcon",
                TipoInclusao4 = "CadeiranteIcon",
            };

            var escola2 = new EscolaDTO()
            {
                EscolaId = 2,
                Name = "Escola Estadual Martins Pena",
                Image = "EscolaIconDefaut",
                Distancia = "3.5 KM",
                AlunosDisponiveis = "10",
                TipoInclusao1 = "VisualGraveIcon",
                TipoInclusao2 = "BaixaRendaIcon",
                TipoInclusao3 = "AltismoIcon",
                TipoInclusao4 = "CadeiranteIcon",
            };

            var escola3 = new EscolaDTO()
            {
                EscolaId = 3,
                Name = "Escola Estadual Dona Gonçalves",
                Image = "EscolaIconDefaut",
                Distancia = "7.5 KM",
                AlunosDisponiveis = "10",
                TipoInclusao1 = "VisualGraveIcon",
                TipoInclusao2 = "BaixaRendaIcon",
                TipoInclusao3 = "AltismoIcon",
                TipoInclusao4 = "CadeiranteIcon",
            };

            var escola4 = new EscolaDTO()
            {
                EscolaId = 3,
                Name = "Escola Estadual Lucas Lima",
                Image = "EscolaIconDefaut",
                Distancia = "1.5 KM",
                AlunosDisponiveis = "6",
                TipoInclusao1 = "VisualGraveIcon",
                TipoInclusao2 = "BaixaRendaIcon",
                TipoInclusao3 = "AltismoIcon",
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
