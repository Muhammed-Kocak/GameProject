using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Customer
{
    interface ICustomerService
    {
        void Add(Customer customer);
        void Delete();
        void Update();
    }
}
