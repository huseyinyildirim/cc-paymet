using System.Collections.Generic;
using System.Linq;
using CCPayment.Data.Entities;

namespace CCPayment.Data.Repository
{
    public class OrganizationRepository : BaseRepository<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(AppDbContext context) : base(context)
        {

        }

        public void CreateOrganization(Organization organization)
        {
            Create(organization);
        }

        public void DeleteOrganization(Organization organization)
        {
            Delete(organization);
        }

        public IEnumerable<Organization> GetAllOrganizations()
        {
            return FindAll();
        }

        public Organization GetOrganizationById(int organizationId)
        {
            return FindByCondition(x => x.Id == organizationId).FirstOrDefault();
        }

        public void UpdateOrganization(Organization organization)
        {
            Update(organization);
        }
    }
}
