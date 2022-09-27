using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;
using FluentValidation;

namespace BussinessLayer.ValidationRules
{
    public class ProductValidator:AbstractValidator<Pruduct>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductTitle).NotEmpty().WithMessage("Bu alan boş bırakılamaz!");
            RuleFor(x => x.ProductContent).NotEmpty().WithMessage("Bu alan boş bırakılamaz!");
            RuleFor(x => x.ProductImage).NotEmpty().WithMessage("Bu alan boş bırakılamaz!");
            RuleFor(x => x.ProductTitle).MaximumLength(100).WithMessage("Bu alana maksimum 100 karakter girebilirsiniz.");
            RuleFor(x => x.ProductContent).MaximumLength(500).WithMessage("Bu alana maksimum 500 karakter girebilirsiniz.");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Bu alan boş bırakılamaz!");

        }
    }
}
