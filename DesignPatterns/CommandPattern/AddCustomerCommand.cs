using DesignPatterns.CommandPattern.Fx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class AddCustomerCommand : Command
    {
        private CustomerService _customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }
        public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}
