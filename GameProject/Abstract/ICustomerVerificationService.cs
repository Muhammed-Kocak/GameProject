using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Customer
{
    interface ICustomerVerificationService
    {
        bool CustomerControl(Customer customer);
    }
}
