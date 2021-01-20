using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.Name+" "+customer.Surname+" "+customer.Age);
            Console.WriteLine("Addition is succesfully");
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " " + customer.Age);
            Console.WriteLine("Deletion is succesfully");
        }
        public void CustomerList(Customer[] customers )
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("List 's results is : "+customer.Name+" "+customer.Surname+" "+customer.Age);
            }
        }

    }
}
