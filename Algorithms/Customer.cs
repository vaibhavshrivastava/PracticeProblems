using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Customer
    {
        int CustomerID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        // Some customer properties
    }



    public class CustomerInfo
    {
        public List<Customer> CustomerList=new List<Customer>();


        public Customer FindMaxOccuringCustomer()
        {
            //Creating a customer map , to add customer and its correstonding occurance
            Dictionary<Customer, int> customerMap = new Dictionary<Customer, int>();
            foreach (var item in CustomerList)
            {
                if (customerMap.Keys.Contains(item))
                {
                    customerMap[item] = customerMap[item] + 1;
                }
                else customerMap.Add(item, 1);
            }

            //logic to fetch the max number from the map
            int max = 0;
            foreach (var customer in customerMap)
            {
                if (customer.Value > max)
                    max = customer.Value;
            }

            // Getting dictionary key by value that we identified in the above step
            return customerMap.FirstOrDefault(x => x.Value == max).Key;
        }

    }



}
