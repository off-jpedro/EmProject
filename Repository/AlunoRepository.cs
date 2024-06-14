using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;

namespace Repository
{
    public class AlunoRepository : IAlunoRepository
    {        
        public Task<IEnumerable<Aluno>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Aluno> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(Aluno entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Aluno entity)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Delete(Aluno entity)
        {
            throw new NotImplementedException();
        }

    }
}