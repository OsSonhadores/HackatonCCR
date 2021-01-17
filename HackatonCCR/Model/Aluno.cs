using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackatonCCR.Model
{
    [Table("Alunos")]
    public class Aluno
    {
        [PrimaryKey, AutoIncrement]
        public int AlunoId { get; set; }
        public string DTO { get; set; }

    }
}
