using System;
using System.Collections.Generic;
using System.Text;

namespace HackatonCCR.DTO
{
    public class EscolaDTO
    {
        public int EscolaId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string AlunosDisponiveis { get; set; }
        public string Distancia { get; set; }
        public string TipoInclusao1 { get; set; }
        public string TipoInclusao2 { get; set; }
        public string TipoInclusao3 { get; set; }
        public string TipoInclusao4 { get; set; }

    }
}
