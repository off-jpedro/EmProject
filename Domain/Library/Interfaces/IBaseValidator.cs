using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace Domain.Library.Interfaces
{
    public interface IBaseValidator<T> : IValidator
    {
        
    }
}