using System;
using System.Collections.Generic;

namespace Devbuild_Lab_4._3
{
    class Customer
    {
        private string Company;
        private string ContactName;
        private string ContactEmail;
        private string Phone;

        public Customer(string _Company, string _ContactName, string _ContactEmail, string _Phone)
        {
            SetCompany(_Company);
            SetContactName(_ContactName);
            SetContactEmail(_ContactEmail);
            SetPhone(_Phone);
        }

        public string GetCompany()
        {
            return Company;
        }
        public string GetContactName()
        {
            return ContactName;
        }
        public string GetContactEmail()
        {
            return ContactEmail;
        }
        public string GetPhone()
        {
            return Phone;
        }
        public void SetCompany(string _Company)
        {
            Company = _Company;
        }
        public void SetContactName(string _ContactName)
        {
            ContactName = _ContactName;
        }
        public void SetContactEmail(string _ContactEmail)
        {
            ContactEmail = _ContactEmail;
        }
        public void SetPhone(string _Phone)
        {
            Phone = _Phone;
        }
        public override string ToString()
        {
            return $"{Company} {ContactName} {ContactEmail} {Phone}";
        }
    }
    class Program
    {
        static void ListCustomers(List<Customer> Customers)
        {
            foreach (Customer next in Customers)
            {
                Console.WriteLine(next);
            }
        }

        static Customer SearchForCustomer(List<Customer> Customers, string _ContactName)
        {
            foreach (Customer next in Customers)
            {
                if (next.GetContactName() == _ContactName)
                {
                    return next;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {

            List<Customer> Customers = new List<Customer>();

            Customer sucker = new Customer("IBM", "Allen", "Allen@allen.com", "6876879096");
            Customers.Add(sucker);

            sucker = new Customer("Microsoft", "Betty", "Betty@betty.com", "432413241");
            Customers.Add(sucker);

            sucker = new Customer("Downriver Baking Company", "Bel", "Bel@Bel.com", "3141324214");
            Customers.Add(sucker);

            Console.WriteLine("Here are the customers:");
            ListCustomers(Customers);

            sucker = SearchForCustomer(Customers, "IBM");
            if (sucker != null)
            {
                Console.WriteLine($"\n The customers that work at IBM are: {sucker.GetContactName()}");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
            Console.WriteLine("\nHere are all customers:");
            ListCustomers(Customers);

            Console.WriteLine("\nPlease search for a customer by name:");
            string searchTerm = Console.ReadLine();
            sucker = SearchForCustomer(Customers, searchTerm);
            if (sucker != null)
            {
                Console.WriteLine($"Here is that customer's info: {sucker} ");
            }
            else
            {
                Console.WriteLine("Not found.");
            }



        }
    }
}
