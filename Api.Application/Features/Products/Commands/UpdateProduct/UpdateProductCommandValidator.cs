using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommandRequest>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);
            RuleFor(x => x.Title)
            .NotEmpty()
            .WithName("Başlık");
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithName("Açılama");
            RuleFor(x => x.BrandId)
                .NotEmpty()
                .WithName("Marka");
            RuleFor(x => x.Price)
                .NotEmpty()
                .WithName("Fiyat");
            RuleFor(x => x.Discount)
                .NotEmpty()
                .WithName("İndirim Oranı");
            RuleFor(x => x.CategoryIds)
                .NotEmpty()
                .Must(categories => categories.Any())
                .WithName("Categoriler");
        }
    }
}
