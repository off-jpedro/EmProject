using Domain.Models;
using Repository;

namespace RepositoryTest;

public class AlunoRepositoryTest
{
        private AlunoRepository _repository;

        public AlunoRepositoryTest()
        {
            _repository = new AlunoRepository();
        }

        [Fact]
        public async void WhenGetByAll_ReturnsAlunos()
        {
            //Act
            var result = await _repository.GetAll();

            //Assert
            Assert.NotEmpty(result);
        }

        [Fact]
        public async void WhenGetById_ReturnsAluno()
        {
            //Act
            var model = new Aluno { Matricula = 1 };

            //Arrange 
            var result = await _repository.GetById(model.Matricula);

            //Assert
            Assert.NotNull(result);
        }

         [Fact]
        public async void WhenGetById_NotReturnsAluno()
        {
            //Act
            var model = new Aluno { Matricula = 0 };

            //Arrange 
            var result = await _repository.GetById(model.Matricula);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public async void WhenInsert_isValid(){
            
            //Act
            var model = new Aluno {
                Matricula = 1,
                Nome = "Teste",
                CPF = "70134512589",
                Nascimento = new DateTime(02,10,2009),
                Sexo = Domain.Enum.Sexo.Masculino
            };

            //Arrange
            var result = await _repository.Insert(model);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public async void WhenInsert_isInvalid(){
            
            //Act
            var model = new Aluno {
            };

            //Arrange
            var result = await _repository.Insert(model);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public async void WhenUpdate_isValid()
        {
            // Arrange
            var entity = new Aluno {
            Matricula = 1,
                Nome = "Teste Update",
                CPF = "80134512589",
                Nascimento = new DateTime(02,10,2009),
                Sexo = Domain.Enum.Sexo.Feminino
            };

            // Act
            var result = await _repository.Update(entity);

            // Assert
            Assert.True(result);
        }

         [Fact]
        public async void WhenUpdate_isInValid()
        {
            // Arrange
            var entity = new Aluno {
            Matricula = 0, 
            Nome = "Name Test",
            };

            // Act
            var result = await _repository.Update(entity);

            // Assert
            Assert.False(result);
            
        }
        
        [Fact]
        public async void WhenDelet_isValid(){
            //Act
            var entity = new Aluno { Matricula = 1};

            //Arrange
            var result = await _repository.Delete(entity);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public async void WhenDelet_isInValid(){
            //Act
            var entity = new Aluno { Matricula = 0};

            //Arrange
            var result = await _repository.Delete(entity);

            //Assert
            Assert.False(result);
        }
}
