using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Customer
{
    class CustomerVerificationManager : ICustomerVerificationService
    {
        public CustomerVerificationManager()
        {
            Console.WriteLine("Bilgilerinizi kontrol ediyoruz lütfen bekleyiniz.");
        }
        public bool CustomerControl(Customer customer)
        {
            if (customer.Id == 1 && customer.Name == "Muhammed" && customer.SurName == "Koçak" && customer.IdentificationNumber == "32141355132" && customer.BirtYear == 1997)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
