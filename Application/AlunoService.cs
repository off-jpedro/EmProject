using Domain.Models;
using Domain.Validators;
using Repository;

namespace Application
{
    public class AlunoService
    {
        private readonly new AlunoRepository _alunoRepository;
        private readonly new AlunoValidator _alunoValidator;

        public AlunoService(AlunoRepository alunoRepository, AlunoValidator alunoValidator)
        {
            alunoRepository = _alunoRepository;
            alunoValidator = _alunoValidator;
        }

        public async Task<IEnumerable<Aluno>> GetAll(){
            
            try{
                return await _alunoRepository.GetAll();
            }
            catch(Exception ex){
                throw new Exception($"Erro ao listar os alunos! {ex.Message}");
            }
        }

        public async Task<Aluno> GetById(long id){

            _alunoValidator.SetValidationForGetById();

            try{
                return await _alunoRepository.GetById(id);
            }

            catch(Exception ex) {
                throw new Exception($"Não foi possivel encontrar o Aluno com a Matricula {id} {ex.Message}" );
            }
        }

        public async Task<bool> Insert(Aluno entity){
            
            _alunoValidator.SetValidationForInsert();

            var sucess = await _alunoRepository.Insert(entity);

            try{

                if(!sucess){
                    throw new Exception ("Erro ao inserir o Aluno!");
                }
                    return sucess;
            }
            
            catch(Exception ex){
                throw new Exception($"Erro ao inserir o Aluno - Catch Exception Service Insert {ex.Message}");
            }
        }

        public async Task<bool> Update(Aluno entity){

            _alunoValidator.SetValidationForUpdate();

            var sucess = await _alunoRepository.Update(entity);

            try{
                if(!sucess){
                    throw new Exception($"Erro ao atualizar os dados do Aluno");
                }
                    return sucess;
                }
            catch(Exception ex){
                throw new Exception($"Erro ao atualizar os dados do Aluno - Exception Service Update {ex.Message}");
            }
        }
    }
}