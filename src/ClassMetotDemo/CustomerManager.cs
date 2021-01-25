using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer  cust)
        {
            Console.WriteLine("{0}" + cust.Name + " Kisisi Eklendi.{0}", Environment.NewLine);
        }
        public void Dell(Customer cust)
        {
            Console.WriteLine("{0}" + cust.Name + " Kisisi Silindi.", Environment.NewLine);
        }
        public void List()
        {
            Customer customer1 = new Customer();
            customer1.Id = 348265;
            customer1.Name = "Mert";
            customer1.Nickname = "manlyy";

            Customer customer2 = new Customer();
            customer2.Id = 273669;
            customer2.Name = "Samet";
            customer2.Nickname = "solVe";

            Customer customer3 = new Customer();
            customer3.Id = 497615;
            customer3.Name = "Umut";
            customer3.Nickname = "trakS";

            Customer[] customers = new Customer[]
            {
                customer1, customer2, customer3
            };

            foreach (var i in customers)
            {
                Console.WriteLine(i.Id + " " + i.Name + " " + i.Nickname);
            }
        }
    }
}
