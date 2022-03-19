using System.Collections.Generic;
using CCPayment.Data.Entities;

namespace CCPayment.Data.Repository
{
    public interface IOrganizationRepository
    {
        IEnumerable<Organization> GetAllOrganizations();

        Organization GetOrganizationById(int organizationId);

        void CreateOrganization(Organization organization);

        void UpdateOrganization(Organization organization);

        void DeleteOrganization(Organization organization);
    }
}
