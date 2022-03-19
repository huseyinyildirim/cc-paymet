using System.Collections.Generic;
using CCPayment.Data.Entities;

namespace CCPayment.Data.Repository
{
    public interface ICardTypeRepository
    {
        IEnumerable<CardType> GetAllCardTypes();

        CardType GetCardTypeById(int cardTypeId);

        void CreateCardType(CardType cardType);

        void UpdateCardType(CardType cardType);

        void DeleteCardType(CardType cardType);
    }
}
