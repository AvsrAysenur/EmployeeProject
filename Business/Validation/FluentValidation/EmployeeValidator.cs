using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage("personel adı boş olamaz");
            RuleFor(r => r.Name).MinimumLength(3).WithMessage("personel adı 3 karakterden az olamaz");
            RuleFor(r => r.LastName).NotEmpty().WithMessage("personel Soyadı boş olamaz");
            RuleFor(r => r.LastName).MinimumLength(3).WithMessage("personel Soyadı 3 karakterden az olamaz");
            RuleFor(r => r.Salary).GreaterThan(0).WithMessage("Personel ücreti asgari ücretten büyük olmalıdır ");
            RuleFor(r => r.BirthDate).LessThan(DateTime.Now.AddYears(-18)).WithMessage("18 yaşından küçükler işe alınamaz");
            RuleFor(r => r.DepartmentId).GreaterThan(0).WithMessage("personel bölümü seçiniz");
            RuleFor(r => r.IdentityNumber).NotEmpty().MinimumLength(11).MaximumLength(11).WithMessage("TC numarası 11 hane olmalıdır ve boş olamaz.").WithMessage("TC numarası 11 hane olmalıdır ve boş olamaz.").WithMessage("TC numarası 11 hane olmalıdır ve boş olamaz.") ;
        }
    }
}
