using System;
using System.Collections.Generic;
using System.Text;

namespace HackatonCCR.DTO
{
    public class AlunoDTO
    {
        public int AlunoId { get; set; }
        public string Name { get; set; }
        public string Infos { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public string Institution { get; set; }



        public int Lideranca { get; set; }
        public int TrabalhoEmGrupo { get; set; }
        public int Comunicacao { get; set; }
        public int ResolucaoDeProblema { get; set; }
        public int Flexibilidade { get; set; }
        public int HabilidadesInterpessoais { get; set; }
        public int TrabalhoEtico { get; set; }

        public string TipoInclusao { get; set; }
        public string Distancia { get; set; }
        public string Laudo { get; set; }
        public string HabilidadePrincipal { get; set; }
    }
}
