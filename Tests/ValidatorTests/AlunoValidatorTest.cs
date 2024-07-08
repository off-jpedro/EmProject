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
        public void WhenModelsGetById_IsValid(){
            //Act
            var aluno = new Aluno { Matricula = 1};

            //Arrange
            _alunoValidator.SetValidationForGetById();
            var result = _alunoValidator.Validate(aluno);

            //Assert
            Assert.True(result.IsValid);
        }

        [Fact]
        public void WhenModelsGetById_IsInvalid(){
            //Act
            var aluno = new Aluno { Matricula = 0};

            //Arrange
            _alunoValidator.SetValidationForGetById();
            var result = _alunoValidator.Validate(aluno);

            //Assert
            Assert.False(result.IsValid);
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

        [Fact]
        public void WhenModelsInsert_IsInvalid()
        {
            //Act
            var aluno = new Aluno { Matricula = 0,
                                    //Nome = "Aluno 01",
                                    //CPF = "987654321",
                                    //Nascimento = new DateTime(2000, 5, 15),
                                    //Sexo = Domain.Enum.Sexo.Masculino
                                    };
            //Arrange
            _alunoValidator.SetValidationForInsert();
            var result = _alunoValidator.Validate(aluno);

            //Assert
            Assert.False(result.IsValid);
        }

        [Fact]
        public void WhenModelsUpdate_IsValid()
        {
            // Act
            var aluno = new Aluno { Matricula = 1,
                                    Nome = "Aluno 01",
                                    CPF = "987654321",
                                    Nascimento = new DateTime(2000, 5, 15),
                                    Sexo = Domain.Enum.Sexo.Masculino };
            // Arrange
            _alunoValidator.SetValidationForUpdate();
            var result = _alunoValidator.Validate(aluno);           
            // Assert
            Assert.True(result.IsValid);
        }

        [Fact]
        public void WhenModelsUpdate_IsInvalid()
        {
            // Act
            var aluno = new Aluno { Matricula = 0,
                                    // Nome = "Aluno 01",
                                    // CPF = "987654321",
                                    // Nascimento = new DateTime(2000, 5, 15),
                                    //Sexo = Domain.Enum.Sexo.Masculino 
                                    };
            // Arrange
            _alunoValidator.SetValidationForUpdate();
            var result = _alunoValidator.Validate(aluno);           
            // Assert
            Assert.False(result.IsValid);
        }

        [Fact]
        public void WhenModelsDelete_IsValid()
        {
            // Act
            var aluno = new Aluno { Matricula = 1,
                                    Nome = "Aluno 01",
                                    // CPF = "987654321",
                                    // Nascimento = new DateTime(2000, 5, 15),
                                    //Sexo = Domain.Enum.Sexo.Masculino 
                                    };
            // Arrange
            _alunoValidator.SetValidationForDelete();
            var result = _alunoValidator.Validate(aluno);           
            // Assert
            Assert.True(result.IsValid);
        }

        [Fact]
        public void WhenModelsDelete_IsInValid()
        {
            // Act
            var aluno = new Aluno { Matricula = 0,
                                    Nome = "Aluno 01",
                                    // CPF = "987654321",
                                    // Nascimento = new DateTime(2000, 5, 15),
                                    //Sexo = Domain.Enum.Sexo.Masculino 
                                    };
            // Arrange
            _alunoValidator.SetValidationForDelete();
            var result = _alunoValidator.Validate(aluno);           
            // Assert
            Assert.False(result.IsValid);
        }
    }
}