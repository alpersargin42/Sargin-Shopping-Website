using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;

namespace BussinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezsiniz.");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori en fazla 50 karakter olmalıdır.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori en az 3 karakter olmalıdır.");
        }

    }
}
