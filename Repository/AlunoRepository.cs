using Domain.Models;
using EMRepository;


namespace Repository
{
    public class AlunoRepository : IAlunoRepository<Aluno>
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