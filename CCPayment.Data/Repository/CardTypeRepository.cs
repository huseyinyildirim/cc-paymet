using System.Collections.Generic;
using System.Linq;
using CCPayment.Data.Entities;

namespace CCPayment.Data.Repository
{
    public class CardTypeRepository : BaseRepository<CardType>, ICardTypeRepository
    {
        public CardTypeRepository(AppDbContext context) : base(context)
        {

        }

        public void CreateCardType(CardType cardType)
        {
            Create(cardType);
        }

        public void DeleteCardType(CardType cardType)
        {
            Delete(cardType);
        }

        public IEnumerable<CardType> GetAllCardTypes()
        {
            return FindAll();
        }

        public CardType GetCardTypeById(int cardTypeId)
        {
            return FindByCondition(x => x.Id == cardTypeId).FirstOrDefault();
        }

        public void UpdateCardType(CardType cardType)
        {
            Update(cardType);
        }
    }
}
