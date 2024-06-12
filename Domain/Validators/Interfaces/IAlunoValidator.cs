using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Library;
using Domain.Models;
using FluentValidation;

namespace Domain.Validators.Interfaces
{
    public interface IAlunoValidator
    {
         public void SetValidationForGetById();

        public void SetValidationForInsert();

        public void SetValidationForUpdate();

        public void  SetValidationForDelete();
    }
}