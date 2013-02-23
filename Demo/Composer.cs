using Demo.Application;
using Demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo {
    public class Composer {
        private MainViewModel model = new MainViewModel(new DemoCustomerRepository());

        public MainViewModel MainViewModel { get { return model; } }
    }
}
