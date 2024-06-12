using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Library.Interfaces;
using FluentValidation;

namespace Domain.Library
{
    public class BaseValidator<T> : AbstractValidator<T>, IBaseValidator<T>
    {
        
    }
}