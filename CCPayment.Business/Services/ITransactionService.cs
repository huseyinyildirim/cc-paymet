using System.Collections.Generic;
using CCPayment.Business.Dtos;
using CCPayment.Shared.Dtos;

namespace CCPayment.Business.Services
{
    public interface ITransactionService
    {
        Response<List<TransactionDto>> GetAll();

        Response<TransactionDto> GetById(int id);

        Response<TransactionDto> Create(TransactionCreateDto transactionCreateDto);

        Response<NoContent> Update(TransactionUpdateDto transactionUpdateDto);

        Response<NoContent> Delete(TransactionDeleteDto transactionDeleteDto);
    }
}
