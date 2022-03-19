using AutoMapper;
using CCPayment.Business.Dtos;
using CCPayment.Data.Entities;
using CCPayment.POS.Requests;

namespace CCPayment.Payment.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Bank, BankDto>().ReverseMap();
            CreateMap<Bin, BinDto>().ReverseMap();
            CreateMap<CardType, CardTypeDto>().ReverseMap();
            CreateMap<Organization, OrganizationDto>().ReverseMap();
            CreateMap<Organization, OrganizationDto>().ReverseMap();
            CreateMap<Transaction, TransactionDto>().ReverseMap();

            CreateMap<Transaction, TransactionCreateDto>().ReverseMap();
            CreateMap<Transaction, TransactionUpdateDto>().ReverseMap();
            CreateMap<Transaction, TransactionDeleteDto>().ReverseMap();

            CreateMap<ThreeDRequest, PaymentDto>().ReverseMap();
            CreateMap<VerifyRequest, PaymentTransactionDto>().ReverseMap();
            CreateMap<RefundRequest, PaymentTransactionDto>().ReverseMap();
            CreateMap<CancelRequest, PaymentTransactionDto>().ReverseMap();
            CreateMap<DetailRequest, PaymentTransactionDto>().ReverseMap();

            //CreateMap<PaymentDto, ThreeDRequest>().ReverseMap();
            //CreateMap<PaymentTransactionDto, VerifyRequest>().ReverseMap();
            //CreateMap<PaymentTransactionDto, RefundRequest>().ReverseMap();
            //CreateMap<PaymentTransactionDto, CancelRequest>().ReverseMap();
            //CreateMap<PaymentTransactionDto, DetailRequest>().ReverseMap();
        }
    }
}
