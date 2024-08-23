using Domain.Models;
using EMRepository;
using Microsoft.Extensions.Configuration;


namespace Repository
{
    public class AlunoRepository : IAlunoRepository<Aluno>
    {
        private List<Aluno> _listAlunos = new List<Aluno>();

        public AlunoRepository()
        {
            this._listAlunos.Add(new Aluno{ Matricula = 1, CPF = "048.056.916-97", Nascimento = new DateTime(02/05/2009), Nome = "Heloise Agatha Vitória Lopes", Sexo = Domain.Enum.Sexo.Feminino });
            this._listAlunos.Add(new Aluno{ Matricula = 2, CPF = "774.337.181-68", Nascimento = new DateTime(11/03/2010), Nome = "Brenda Isabelle Caldeira", Sexo = Domain.Enum.Sexo.Feminino });
            this._listAlunos.Add(new Aluno{ Matricula = 3, CPF = "464.504.723-08", Nascimento = new DateTime(22/01/2010), Nome = "Matheus Filipe Drumond", Sexo = Domain.Enum.Sexo.Masculino });
            this._listAlunos.Add(new Aluno{ Matricula = 4, CPF = "396.544.681-90", Nascimento = new DateTime(06/02/2009), Nome = "Thiago Geraldo Martins", Sexo = Domain.Enum.Sexo.Masculino });
            this._listAlunos.Add(new Aluno{ Matricula = 5, CPF = "382.408.312-49", Nascimento = new DateTime(05/04/2010), Nome = "Geraldo Márcio Igor Figueiredo", Sexo = Domain.Enum.Sexo.Masculino });
            this._listAlunos.Add(new Aluno{ Matricula = 6, CPF = "941.959.670-23", Nascimento = new DateTime(24/02/2010), Nome = "Caroline Sarah Andreia Novaes", Sexo = Domain.Enum.Sexo.Feminino});
            this._listAlunos.Add(new Aluno{ Matricula = 7, CPF = "780.464.146-03", Nascimento = new DateTime(23/07/2009), Nome = "Cláudia Emily Freitas", Sexo = Domain.Enum.Sexo.Feminino });
            
        }

        public async Task<IEnumerable<Aluno>> GetAll()
        {
            return _listAlunos.AsEnumerable();
        }

        public async Task<Aluno> GetById(long id)
        {
            var entity = _listAlunos.FirstOrDefault(x => x.Matricula == id);

            if(entity != null){
                return await Task.FromResult(entity);    
            }
            return await Task.FromResult<Aluno>(null);
        }

        public async Task<bool> Insert(Aluno entity)
        {
             entity.Matricula = _listAlunos.Count + 1;

             this._listAlunos.Add(entity);

             return await Task.FromResult(true);
        }

        public async Task<bool> Update(Aluno entity)
        {
            var model = _listAlunos.FirstOrDefault(x => x.Matricula == entity.Matricula);

            if(model != null){
                model.Nome = entity.Nome;
                model.CPF = entity.CPF;
                model.Nascimento = entity.Nascimento;
                model.Sexo = entity.Sexo;
            }

            return await Task.FromResult(false);
        }

        public async Task<bool> Delete(Aluno entity)
        {
            var model = _listAlunos.FirstOrDefault(x => x.Matricula == entity.Matricula);

            if(model != null){
                this._listAlunos.Remove(model);
                return await Task.FromResult(true);
            }

            return await Task.FromResult(false);
        }
    }
}