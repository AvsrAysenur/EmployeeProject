using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns
{
    public static class ValidationTool
    {
        public static bool Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context); // bu kodu chatten aldım normalde altındakini yazıyordum.artık kodum çalışıyor.     
            //var result = validator.Validate((IValidationContext)entity);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    MessageBox.Show(error.ErrorMessage, "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            return true;
            //DepartmentValidator validationRules = new DepartmentValidator();
            //ValidationResult validationResult = validationRules.Validate(department);
            //IList<ValidationFailure> failures = validationResult.Errors;
            //if (!validationResult.IsValid)
            //{
            //    foreach (ValidationFailure failure in failures)
            //    {
            //        MessageBox.Show(failure.ErrorMessage, "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    return false;
            //}
        }
    }
}
