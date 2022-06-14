using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zeroToHeroMVC.Models.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Email cant be EMPTY");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please Enter a Valid Email");

            RuleFor(x => x.ProductName).NotNull().NotEmpty().WithMessage("Please enter a Product Name");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Please enter a longer Product Name");
        }
    }
}