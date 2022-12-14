using Journal.API.Core.Context;
using Journal.API.Core.Models;
using System.Linq;

namespace Journal.API.Core.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(DatabaseContext context) : base(context)
        {
        }

        public Customer GetByEmailAddress(string email)
        {
            var user = FindByQuery("select * from customers where emailaddress = {0}", new object[] { email }).FirstOrDefault();
            return user;
        }

    }
}
