using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using CCPayment.Data;
using CCPayment.Data.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CCPayment.Payment
{
    public class BinList
    {
        public int BinCode { get; set; }
        public int BankCode { get; set; }
        public string BankName { get; set; }
        public string CardType { get; set; }
        public int CardTypeId { get; set; }
        public string Organization { get; set; }
        public int OrganizationId { get; set; }
        public bool IsCommercialCard { get; set; }
        public bool IsSupportInstallment { get; set; }
        public bool IsActive { get; set; }
    }

    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<AppDbContext>();

            context.Database.Migrate();

            if (!context.Banks.Any())
            {
                /*context.Banks.AddRange(
                    new List<Bank>() {
                         new Bank() { Id=10, BankName = "T.C.ZİRAAT BANKASI A.Ş." },
                         new Bank() { Id=12, BankName = "T.HALK BANKASI A.Ş." },
                         new Bank() { Id=15, BankName = "T.VAKIFLAR BANKASI T.A.O." },
                         new Bank() { Id=32, BankName = "TÜRK EKONOMİ BANKASI A.Ş." },
                         new Bank() { Id=46, BankName = "AKBANK T.A.Ş." },
                         new Bank() { Id=59, BankName = "ŞEKERBANK T.A.Ş." },
                         new Bank() { Id=62, BankName = "T.GARANTİ BANKASI A.Ş." },
                         new Bank() { Id=64, BankName = "T.İŞ BANKASI A.Ş." },
                         new Bank() { Id=67, BankName = "YAPI VE KREDİ BANKASI A.Ş." },
                         new Bank() { Id=92, BankName = "CITIBANK A.Ş." },
                         new Bank() { Id=96, BankName = "TURKISH BANK A.Ş." },
                         new Bank() { Id=99, BankName = "ING BANK A.Ş." },
                         new Bank() { Id=103, BankName = "FİBABANKA A.Ş." },
                         new Bank() { Id=108, BankName = "TURKLAND BANK A.Ş." },
                         new Bank() { Id=109, BankName = "ICBC TURKEY BANK A.Ş." },
                         new Bank() { Id=111, BankName = "QNB FİNANSBANK A.Ş." },
                         new Bank() { Id=123, BankName = "HSBC BANK A.Ş." },
                         new Bank() { Id=124, BankName = "ALTERNATİFBANK A.Ş." },
                         new Bank() { Id=125, BankName = "BURGAN BANK A.Ş." },
                         new Bank() { Id=134, BankName = "DENİZBANK A.Ş." },
                         new Bank() { Id=135, BankName = "ANADOLUBANK A.Ş." },
                         new Bank() { Id=143, BankName = "AKTİF YATIRIM BANKASI A.Ş." },
                         new Bank() { Id=146, BankName = "ODEABANK A.Ş." },
                         new Bank() { Id=150, BankName = "GOLDEN GLOBAL YATIRIM BANKASI A.Ş." },
                         new Bank() { Id=203, BankName = "ALBARAKA TÜRK KATILIM BANKASI A.Ş." },
                         new Bank() { Id=205, BankName = "KUVEYT TÜRK KATILIM BANKASI A.Ş." },
                         new Bank() { Id=206, BankName = "T. FİNANS KATILIM BANKASI A.Ş." },
                         new Bank() { Id=209, BankName = "ZİRAAT KATILIM BANKASI A.Ş." },
                         new Bank() { Id=210, BankName = "VAKIF KATILIM BANKASI A.Ş." },
                         new Bank() { Id=211, BankName = "TÜRKİYE EMLAK KATILIM BANKASI A.Ş." },
                         new Bank() { Id=839, BankName = "OZAN ELEKTRONİK PARA A.Ş." },
                         new Bank() { Id=864, BankName = "İYZİ ÖDEME VE ELEKTRONİK PARA HİZMETLERİ A.Ş." },
                         new Bank() { Id=870, BankName = "TT ÖDEME VE ELEKTRONİK PARA HİZMETLERİ A.Ş." },
                         new Bank() { Id=890, BankName = "LYDİANS ELEKTRONİK PARA VE ÖDEME HİZMETLERİ A.Ş." },
                         new Bank() { Id=900, BankName = "PAYCORE ÖDEME HİZ. TAKAS VE MUTABAKAT SİS. A.Ş." },
                         new Bank() { Id=6001, BankName = "TÜRK ELEKTRONİK PARA A.Ş." },
                         new Bank() { Id=6002, BankName = "PAPARA ELEKTRONİK PARA VE ÖDEME HİZMETLERİ A.Ş." },
                         new Bank() { Id=6003, BankName = "POSTA VE TELGRAF TEŞKİLATI A.Ş." },
                         new Bank() { Id=6004, BankName = "İNİNAL ÖDEME VE ELEKTRONİK PARA HİZMETLERİ A.Ş." },
                         new Bank() { Id=6005, BankName = "TURKCELL ÖDEME VE ELEKTRONİK PARA HİZMETLERİ A.Ş." },
                         new Bank() { Id=6006, BankName = "PALADYUM ELEKTRONİK PARA VE ÖDEME HİZMETLERİ A.Ş." },
                    });*/

                context.Banks.AddRange(
                    new List<Bank>() {
                         new Bank() { BankName = "T.C.ZİRAAT BANKASI A.Ş." },
                         new Bank() { BankName = "T.HALK BANKASI A.Ş." },
                         new Bank() { BankName = "T.VAKIFLAR BANKASI T.A.O." },
                         new Bank() { BankName = "TÜRK EKONOMİ BANKASI A.Ş." },
                         new Bank() { BankName = "AKBANK T.A.Ş." },
                         new Bank() { BankName = "ŞEKERBANK T.A.Ş." },
                         new Bank() { BankName = "T.GARANTİ BANKASI A.Ş." },
                         new Bank() { BankName = "T.İŞ BANKASI A.Ş." },
                         new Bank() { BankName = "YAPI VE KREDİ BANKASI A.Ş." },
                         new Bank() { BankName = "CITIBANK A.Ş." },
                         new Bank() { BankName = "TURKISH BANK A.Ş." },
                         new Bank() { BankName = "ING BANK A.Ş." },
                         new Bank() { BankName = "FİBABANKA A.Ş." },
                         new Bank() { BankName = "TURKLAND BANK A.Ş." },
                         new Bank() { BankName = "ICBC TURKEY BANK A.Ş." },
                         new Bank() { BankName = "QNB FİNANSBANK A.Ş." },
                         new Bank() { BankName = "HSBC BANK A.Ş." },
                         new Bank() { BankName = "ALTERNATİFBANK A.Ş." },
                         new Bank() { BankName = "BURGAN BANK A.Ş." },
                         new Bank() { BankName = "DENİZBANK A.Ş." },
                         new Bank() { BankName = "ANADOLUBANK A.Ş." },
                         new Bank() { BankName = "AKTİF YATIRIM BANKASI A.Ş." },
                         new Bank() { BankName = "ODEABANK A.Ş." },
                         new Bank() { BankName = "GOLDEN GLOBAL YATIRIM BANKASI A.Ş." },
                         new Bank() { BankName = "ALBARAKA TÜRK KATILIM BANKASI A.Ş." },
                         new Bank() { BankName = "KUVEYT TÜRK KATILIM BANKASI A.Ş." },
                         new Bank() { BankName = "T. FİNANS KATILIM BANKASI A.Ş." },
                         new Bank() { BankName = "ZİRAAT KATILIM BANKASI A.Ş." },
                         new Bank() { BankName = "VAKIF KATILIM BANKASI A.Ş." },
                         new Bank() { BankName = "TÜRKİYE EMLAK KATILIM BANKASI A.Ş." },
                         new Bank() { BankName = "OZAN ELEKTRONİK PARA A.Ş." },
                         new Bank() { BankName = "İYZİ ÖDEME VE ELEKTRONİK PARA HİZMETLERİ A.Ş." },
                         new Bank() { BankName = "TT ÖDEME VE ELEKTRONİK PARA HİZMETLERİ A.Ş." },
                         new Bank() { BankName = "LYDİANS ELEKTRONİK PARA VE ÖDEME HİZMETLERİ A.Ş." },
                         new Bank() { BankName = "PAYCORE ÖDEME HİZ. TAKAS VE MUTABAKAT SİS. A.Ş." },
                         new Bank() { BankName = "TÜRK ELEKTRONİK PARA A.Ş." },
                         new Bank() { BankName = "PAPARA ELEKTRONİK PARA VE ÖDEME HİZMETLERİ A.Ş." },
                         new Bank() { BankName = "POSTA VE TELGRAF TEŞKİLATI A.Ş." },
                         new Bank() { BankName = "İNİNAL ÖDEME VE ELEKTRONİK PARA HİZMETLERİ A.Ş." },
                         new Bank() { BankName = "TURKCELL ÖDEME VE ELEKTRONİK PARA HİZMETLERİ A.Ş." },
                         new Bank() { BankName = "PALADYUM ELEKTRONİK PARA VE ÖDEME HİZMETLERİ A.Ş." },
                    });
            }

            if (!context.CardTypes.Any())
            {
                context.CardTypes.AddRange(
                    new List<CardType>() {
                         new CardType() { CardTypeName = "Credit" },
                         new CardType() { CardTypeName = "Debit" }
                    });
            }

            if (!context.Organizations.Any())
            {
                context.Organizations.AddRange(
                    new List<Organization>() {
                         new Organization() { OrganizationName = "Visa" },
                         new Organization() { OrganizationName = "Master" },
                         new Organization() { OrganizationName = "Troy" },
                         new Organization() { OrganizationName = "Amex" }
                    });
            }

            if (!context.Bins.Any())
            {
                string path = File.ReadAllText($@"/Users/huseyinyildirim/Projects/CCPayment/bin-list.json");

                var jsonResult = JsonSerializer.Deserialize<List<BinList>>(path);

                List<Bin> newBinList = new();

                jsonResult.ForEach(x =>
                {
                    newBinList.Add(new()
                    {
                        BinCode = x.BinCode.ToString(),
                        BankId = x.BankCode,
                        CardTypeId = x.CardTypeId,
                        OrganizationId = x.OrganizationId,
                        IsCommercialCard = x.IsCommercialCard,
                        IsSupportInstallment = x.IsSupportInstallment,
                        IsActive = x.IsActive
                    });
                });

                context.Bins.AddRange(newBinList);
            }

            if (!context.Transactions.Any())
            {
                context.Transactions.AddRange(
                    new List<Transaction>() {
                         new Transaction() { BankId = 10, HolderName="Hüseyin Yıldırım", CardNo="4045910012341234", ExpiryMonth="09", ExpiryYear="23", CVV="123", CreatedAt=DateTime.Now  },
                         new Transaction() { BankId = 10, HolderName="Mehtap Yıldırım", CardNo="4045910012341235", ExpiryMonth="10", ExpiryYear="24", CVV="124", CreatedAt=DateTime.Now  },
                         new Transaction() { BankId = 10, HolderName="Elif Duru Yıldırım", CardNo="4045910012341236", ExpiryMonth="11", ExpiryYear="25", CVV="125", CreatedAt=DateTime.Now  },
                         new Transaction() { BankId = 10, HolderName="Hüseyin Yıldırım", CardNo="4045910012341237", ExpiryMonth="12", ExpiryYear="26", CVV="126", CreatedAt=DateTime.Now  },
                    });
            }

            context.SaveChanges();

        }

    }
}
