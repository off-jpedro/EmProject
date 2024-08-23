using Application;
using Domain.Validators;
using Repository;

namespace ServiceTests;

public class AlunoServiceTest
{    
        private AlunoService _alunoService;
        private AlunoRepository _alunoRepository;
        private AlunoValidator _alunoValidator;

        public AlunoServiceTest()
        {
            _alunoValidator = new AlunoValidator();
            _alunoRepository = new AlunoRepository();
            _alunoService = new AlunoService(_alunoRepository,_alunoValidator);
        }

        [Fact]
        public async void WhenGetByAll_ReturnsAlunos()
        {
            //Arrange | Act
            var result = await _alunoService.GetAll();

            //Assert
            Assert.NotEmpty(result);
        }
}