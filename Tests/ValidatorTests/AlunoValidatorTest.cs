using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Validators;
using Domain.Validators.Interfaces;
using Xunit;

namespace ValidatorTests
{
    public class AlunoValidatorTest
    {
        private AlunoValidator _alunoValidator;

        public AlunoValidatorTest()
        {
            _alunoValidator = new AlunoValidator();
        }

        [Fact]
        public void WhenModelsInsert_IsValid()
        {
            //Act
            var aluno = new Aluno { Matricula = 1,
                                    Nome = "Aluno 01",
                                    CPF = "987654321",
                                    Nascimento = new DateTime(2000, 5, 15),
                                    Sexo = Domain.Enum.Sexo.Masculino
                                    };
            //Arrange
            _alunoValidator.SetValidationForInsert();
            var result = _alunoValidator.Validate(aluno);

            //Assert
            Assert.True(result.IsValid);
        }
    }
}