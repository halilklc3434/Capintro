using System;
using System.Collections.Generic;
using System.Text;

namespace ClassmethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine(customer.Ad + "  Eklendi");
        
        
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Ad + "  Silindi");


        }
        public void List(Customer[] customer)
        {
            foreach (var customers in customer)
            {
                Console.WriteLine(customers);
            }


        }

    }
}
