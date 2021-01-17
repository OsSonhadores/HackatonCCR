using HackatonCCR.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HackatonCCR.Repository
{
    public class Repository
    {
        readonly SQLiteAsyncConnection _database;

        public Repository(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Aluno>().Wait();
            _database.CreateTableAsync<Escola>().Wait();
        }

        //CRUD
        public Task<List<Aluno>> GetAlunoAsync()
        {
            return _database.Table<Aluno>().ToListAsync();
        }

        public Task<Aluno> GetAlunoAsync(int id)
        {
            return _database.Table<Aluno>()
                            .Where(i => i.AlunoId == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveAlunoAsync(Aluno aluno)
        {
            if (aluno.AlunoId != 0)
            {
                return _database.UpdateAsync(aluno);
            }
            else
            {
                return _database.InsertAsync(aluno);
            }
        }

        public Task<int> DeleteAlunoAsync(Aluno aluno)
        {
            return _database.DeleteAsync(aluno);
        }



        //CRUD
        public Task<List<Escola>> GetEscolaAsync()
        {
            return _database.Table<Escola>().ToListAsync();
        }

        public Task<Escola> GetEscolaAsync(int id)
        {
            return _database.Table<Escola>()
                            .Where(i => i.EscolaId == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveEscolaAsync(Escola escola)
        {
            if (escola.EscolaId != 0)
            {
                return _database.UpdateAsync(escola);
            }
            else
            {
                return _database.InsertAsync(escola);
            }
        }

        public Task<int> DeleteEscolaAsync(Escola escola)
        {
            return _database.DeleteAsync(escola);
        }




    }
}
