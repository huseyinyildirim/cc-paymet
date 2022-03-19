using System.Collections.Generic;
using CCPayment.Data.Entities;

namespace CCPayment.Data.Repository
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> GetAllTransactions();

        Transaction GetTransactionById(int transactionId);

        void CreateTransaction(Transaction transaction);

        void UpdateTransaction(Transaction transaction);

        void DeleteTransaction(Transaction transaction);
    }
}
