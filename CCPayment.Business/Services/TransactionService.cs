using System.Collections.Generic;
using AutoMapper;
using CCPayment.Business.Dtos;
using CCPayment.Data.Entities;
using CCPayment.Data.Repository;
using CCPayment.Shared;
using CCPayment.Shared.Dtos;

namespace CCPayment.Business.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;

        public TransactionService(IMapper mapper, ITransactionRepository transactionRepository)
        {
            _mapper = mapper;
            _transactionRepository = transactionRepository;
        }

        public Response<List<TransactionDto>> GetAll()
        {
            var transactions = _transactionRepository.GetAllTransactions();

            return Response<List<TransactionDto>>.Success(_mapper.Map<List<TransactionDto>>(transactions), HttpStatusCode.OK);
        }

        public Response<TransactionDto> GetById(int id)
        {
            var transaction = _transactionRepository.GetTransactionById(id);

            if (transaction == null)
            {
                return Response<TransactionDto>.Fail(Messages.NOT_FOUND, HttpStatusCode.NOT_FOUND);
            }

            return Response<TransactionDto>.Success(_mapper.Map<TransactionDto>(transaction), HttpStatusCode.OK);
        }

        public Response<TransactionDto> Create(TransactionCreateDto transactionCreateDto)
        {
            var newTransaction = _mapper.Map<Transaction>(transactionCreateDto);

            _transactionRepository.CreateTransaction(newTransaction);

            return Response<TransactionDto>.Success(_mapper.Map<TransactionDto>(newTransaction), HttpStatusCode.OK);
        }

        public Response<NoContent> Update(TransactionUpdateDto transactionUpdateDto)
        {
            var updateTransaction = _mapper.Map<Transaction>(transactionUpdateDto);

            _transactionRepository.UpdateTransaction(updateTransaction);

            return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);
        }

        public Response<NoContent> Delete(TransactionDeleteDto transactionDeleteDto)
        {
            var deleteTransaction = _mapper.Map<Transaction>(transactionDeleteDto);

            _transactionRepository.DeleteTransaction(deleteTransaction);

            return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);

        }
    }
}