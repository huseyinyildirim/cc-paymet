using System.Collections.Generic;
using System.Linq;
using CCPayment.Data.Entities;

namespace CCPayment.Data.Repository
{
    public class BinRepository : BaseRepository<Bin>, IBinRepository
    {
        public BinRepository(AppDbContext context) : base(context)
        {

        }

        public void CreateBin(Bin bin)
        {
            Create(bin);
        }

        public void DeleteBin(Bin bin)
        {
            Delete(bin);
        }

        public IEnumerable<Bin> GetAllBins()
        {
            return FindAll();
        }

        public Bin GetBinById(int binId)
        {
            return FindByCondition(x => x.Id == binId).FirstOrDefault();
        }

        public Bin GetBinByBinCode(string binCode)
        {
            return FindByCondition(x => x.BinCode == binCode).FirstOrDefault();
        }

        public void UpdateBin(Bin bin)
        {
            Update(bin);
        }
    }
}
