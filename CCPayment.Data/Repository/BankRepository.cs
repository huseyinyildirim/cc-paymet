using System.Collections.Generic;
using System.Linq;
using CCPayment.Data.Entities;

namespace CCPayment.Data.Repository
{
    public class BankRepository : BaseRepository<Bank>, IBankRepository
    {
        public BankRepository(AppDbContext context) : base(context)
        {

        }

        public void CreateBank(Bank bank)
        {
            Create(bank);
        }

        public void DeleteBank(Bank bank)
        {
            Delete(bank);
        }

        public IEnumerable<Bank> GetAllBanks()
        {
            return FindAll();
        }

        public Bank GetBankById(int bankId)
        {
            return FindByCondition(x => x.Id == bankId).FirstOrDefault();
        }

        public void UpdateBank(Bank bank)
        {
            Update(bank);
        }
    }
}
