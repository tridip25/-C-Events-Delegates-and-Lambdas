using System;
using System.Collections.Generic;
using System.Linq;

namespace lambdaWIthLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var Customer = new List<CustomerDetails>();
            Customer.Add(new CustomerDetails(){Id = "DC2016BTE901" , Firstname = "Brad" , Lastname = "Das" , City = "Ghy"});
            Customer.Add(new CustomerDetails(){Id = "DC2016BTE987" , Firstname = "Rajveer" , Lastname = "Dey" , City = "Azara"});
            Customer.Add(new CustomerDetails(){Id = "DC2016BTE921" , Firstname = "Nilav" , Lastname = "Choudhary" , City = "Dharapur"});
            Customer.Add(new CustomerDetails(){Id = "DC2016BTE872" , Firstname = "Roshan" , Lastname = "Sharma" , City = "Ghy"});
            Customer.Add(new CustomerDetails(){Id = "DC2016BTE342" , Firstname = "Abhishek" , Lastname = "Sharma" , City = "Ghy"});

            var query = Customer.Where(c => c.City=="Ghy" && c.Lastname=="Sharma").OrderBy(c => c.Firstname );

            foreach(var cust in query)
            {
                Console.WriteLine(cust.Firstname);
            }
        }
    }
}
