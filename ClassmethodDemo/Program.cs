using System;

namespace ClassmethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.İd = 1;
            customer1.Ad = "ali";
            customer1.Soyad = "turan";
            Customer customer2 = new Customer();
            customer2.İd = 2;
            customer2.Ad = "vali";
            customer2.Soyad = "aaturan";
            Customer customer3 = new Customer();
            customer3.İd = 3;
            customer3.Ad = "ttali";
            customer3.Soyad = "aasturan";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
            customerManager.Delete(customer1);
            customerManager.List(custom);
        }
    }
}
