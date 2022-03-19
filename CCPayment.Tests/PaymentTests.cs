using System;
using CCPayment.Business.Services;
using CCPayment.POS.Providers;
using Xunit;

namespace CCPayment.Tests
{
    public class PaymentTests
    {
        [Fact]
        public void AkbankPayment()
        {
            PaymentService payment = new(new AkbankProvider());

            var result = payment.ThreeD(new Business.Dtos.PaymentDto()
            {
                BankId = 1,
                HolderName = "Hüseyin Yıldırım",
                CardNo = "1234123412341234",
                ExpiryMonth = "02",
                ExpiryYear = "26",
                CVV = "123",
                Amount = 5000
            });

            Assert.True(result.IsSuccessful);
        }

        [Fact]
        public void GarantiPayment()
        {
            PaymentService payment = new(new GarantiProvider());

            var result = payment.ThreeD(new Business.Dtos.PaymentDto()
            {
                BankId = 1,
                HolderName = "Hüseyin Yıldırım",
                CardNo = "1234123412341234",
                ExpiryMonth = "02",
                ExpiryYear = "26",
                CVV = "123",
                Amount = 5000
            });

            Assert.True(result.IsSuccessful);
        }

        [Fact]
        public void OtherPayment()
        {
            PaymentService payment = new(new OtherProvider());

            var result = payment.ThreeD(new Business.Dtos.PaymentDto()
            {
                BankId = 1,
                HolderName = "Hüseyin Yıldırım",
                CardNo = "1234123412341234",
                ExpiryMonth = "02",
                ExpiryYear = "26",
                CVV = "123",
                Amount = 5000
            });

            Assert.True(result.IsSuccessful);
        }
    }
}
