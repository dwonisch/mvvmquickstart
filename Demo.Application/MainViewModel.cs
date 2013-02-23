using Demo.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application {
    public class MainViewModel {
        public MainViewModel(ICustomerRepository repository) {
            Customers = new ObservableCollection<Customer>(repository.SelectAllCustomers());
        }

        public ICollection<Customer> Customers { get; private set; }
    }
}
