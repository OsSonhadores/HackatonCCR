using HackatonCCR.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HackatonCCR.Repository
{
    public class AlunoRepository
    {
        readonly SQLiteAsyncConnection _database;

        public AlunoRepository(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Aluno>().Wait();
        }

        //ROUTES CRUD
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


    }
}
