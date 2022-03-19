using System.Collections.Generic;
using CCPayment.Data.Entities;

namespace CCPayment.Data.Repository
{
    public interface IBankRepository
    {
        IEnumerable<Bank> GetAllBanks();

        Bank GetBankById(int bankId);

        void CreateBank(Bank bank);

        void UpdateBank(Bank bank);

        void DeleteBank(Bank bank);
    }
}
