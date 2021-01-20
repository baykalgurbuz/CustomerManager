using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Id = 1;
            c1.Name = "Baykal";
            c1.Surname = "Gürbüz";
            c1.Age = 21;

            Customer c2 = new Customer();
            c2.Id = 2;
            c2.Name = "Ahmet";
            c2.Surname = "Gürbüz";
            c2.Age = 10;

            Customer c3 = new Customer();
            c3.Id = 3;
            c3.Name = "Beyza";
            c3.Surname = "Krcn";
            c3.Age = 21;

            Customer[] customers = new Customer[] {c1,c2,c3 };

            CustomerManager cm1 = new CustomerManager();
            cm1.CustomerAdd(c1);
            cm1.CustomerDelete(c1);
            cm1.CustomerAdd(c2);
            cm1.CustomerDelete(c2);
            cm1.CustomerAdd(c3);
            cm1.CustomerDelete(c3);
            cm1.CustomerList(customers);
        }
    }
}
