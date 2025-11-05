using CarBook.Application.Features.Mediator.Commands.ReviewCommand;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Validators.ReviewValidators
{
    public class UpdateReviewValidator:AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Lütfen Müşteri Adını Boş Geçmeyin");
            RuleFor(x => x.CustomerName).MaximumLength(5).WithMessage("En Az 5 Karakter Giriniz");
            RuleFor(x => x.RaytingValue).NotEmpty().WithMessage("Puan Değerini Boş Bırakmayınız");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Yorum Kısmını Boş Bırakmayınız");
            RuleFor(x => x.Comment).MinimumLength(20).WithMessage("Minimum 20 Karakterlik Bir Şey Yazınız");
            RuleFor(x => x.Comment).MaximumLength(500).WithMessage("Maksimum 500 Karakterlik Bir Şey Yazınız");
            RuleFor(x => x.CustomerImage).NotEmpty().WithMessage("Lütfen Müşteri Göreselini Boş Geçmeyiniz");
        }
    }
}
