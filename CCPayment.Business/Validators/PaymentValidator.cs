using CCPayment.Business.Dtos;
using FluentValidation;

namespace CCPayment.Business.Validators
{
    public class PaymentValidator : AbstractValidator<PaymentDto>
    {
        public PaymentValidator()
        {
            RuleFor(x => x.HolderName).NotEmpty().WithMessage("Lütfen adınızı giriniz.");
            RuleFor(x => x.CardNo).CreditCard().NotEmpty().WithMessage("Kredi kartı numaranızı giriniz.");
            RuleFor(x => x.ExpiryMonth).NotEmpty().WithMessage("Son kullanma tarihindeki ayı giriniz.");
            RuleFor(x => x.ExpiryYear).NotEmpty().WithMessage("Son kullanma tarihindeki yılı giriniz.");
            RuleFor(x => x.CVV).NotEmpty().WithMessage("Güvenlik kodunu giriniz.");
        }
    }
}
