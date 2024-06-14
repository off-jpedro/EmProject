using Domain.Library.Interfaces;
using FluentValidation;

namespace Domain.Library
{
    public class BaseValidator<T> : AbstractValidator<T>, IBaseValidator<T>
    {
        
    }
}