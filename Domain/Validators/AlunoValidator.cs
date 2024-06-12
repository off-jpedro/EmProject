using Domain.Library;
using Domain.Models;
using Domain.Validators.Interfaces;
using FluentValidation;

namespace Domain.Validators
{
    public class AlunoValidator : BaseValidator<Aluno>, IAlunoValidator
    {
        public void SetValidationForGetById()
        {
            RuleFor(a => a.Matricula)
            .NotEqual(0).WithMessage("Certifique-se de ter inserido a Matricula!");
        }

        public void SetValidationForInsert()
        {
            RuleFor(a => a.Nome)
            .NotEmpty().WithMessage("Certifique-se de ter inserido o Nome!")
            .Length(2, 50).WithMessage("O nome deve ter entre 2 a 50 caracteres!");

            RuleFor(a => a.CPF)
            .NotEmpty().WithMessage("Certifique-se de ter inserido o CPF!");

            RuleFor(a => a.Nascimento)
            .NotEmpty().WithMessage("Certifique-se de ter inserido a Data de Nascimento!");

            RuleFor(a => a.Sexo)
            .NotEmpty().WithMessage("Certifique-se de ter inserido o Sexo!");
            
        }

        public void SetValidationForUpdate()
        {
            RuleFor(a => a.Matricula)
            .NotEqual(0).WithMessage("Certifique-se de ter inserido a Matricula!");
            
           RuleFor(a => a.Nome)
            .NotEmpty().WithMessage("Certifique-se de ter inserido o Nome!");

            RuleFor(a => a.CPF)
            .NotEmpty().WithMessage("Certifique-se de ter inserido o CPF!");

            RuleFor(a => a.Nascimento)
            .NotEmpty().WithMessage("Certifique-se de ter inserido a Data de Nascimento!");

            RuleFor(a => a.Sexo)
            .NotEmpty().WithMessage("Certifique-se de ter inserido o Sexo!");
        }
        public void SetValidationForDelete()
        {
           RuleFor(a => a.Matricula)
            .NotEqual(0).WithMessage("Certifique-se de ter inserido a Matricula!");
        }

    }
}