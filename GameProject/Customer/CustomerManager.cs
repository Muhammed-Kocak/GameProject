using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Customer
{
    class CustomerManager : ICustomerService
    {
        private readonly ICustomerVerificationService _customerVerificationService;
        public CustomerManager(ICustomerVerificationService customerVerificationService)
        {
            _customerVerificationService = customerVerificationService;
        }
        public void Add(Customer customer)
        {
            if (_customerVerificationService.CustomerControl(customer)==true)
            {
                Console.WriteLine($"{customer.Name} İsimli Müşteri Eklendi!");
            }
            else
            {
                Console.WriteLine("Doğrulama İşlemi Başarısız.");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Customer Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }
}
