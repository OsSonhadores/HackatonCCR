using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackatonCCR.Model
{

    [Table("Escolas")]
    public class Escola
    {
        [PrimaryKey, AutoIncrement]
        public int EscolaId { get; set; }
        public string DTO { get; set; }
    }
}
