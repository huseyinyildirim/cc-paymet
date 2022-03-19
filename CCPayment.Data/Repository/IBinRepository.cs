using System.Collections.Generic;
using CCPayment.Data.Entities;

namespace CCPayment.Data.Repository
{
    public interface IBinRepository
    {
        IEnumerable<Bin> GetAllBins();

        Bin GetBinById(int binId);

        Bin GetBinByBinCode(string binCode);

        void CreateBin(Bin bin);

        void UpdateBin(Bin bin);

        void DeleteBin(Bin bin);
    }
}
