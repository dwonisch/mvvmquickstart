using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data {
    public class DemoCustomerRepository : ICustomerRepository {
        public IEnumerable<Customer> SelectAllCustomers() {
            yield return new Customer("Daniel", "@home");
            yield return new Customer("Desiree", "@work");
            yield return new Customer("Max", "@way");
        }
    }
}
