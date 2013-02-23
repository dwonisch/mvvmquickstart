﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data {
    public interface ICustomerRepository {
        IEnumerable<Customer> SelectAllCustomers();
    }
}
