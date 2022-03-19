using System.Collections.Generic;
using System.Linq;
using CCPayment.Data.Entities;

namespace CCPayment.Data.Repository
{
    public class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(AppDbContext context) : base(context)
        {

        }

        public void CreateTransaction(Transaction transaction)
        {
            Create(transaction);
        }

        public void DeleteTransaction(Transaction transaction)
        {
            Delete(transaction);
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            return FindAll();
        }

        public Transaction GetTransactionById(int transactionId)
        {
            return FindByCondition(x => x.Id == transactionId).FirstOrDefault();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            Update(transaction);
        }
    }
}
