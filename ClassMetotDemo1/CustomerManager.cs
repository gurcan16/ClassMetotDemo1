using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customersList = new List<Customer>();
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi");
            Console.WriteLine("Hoş Geldiniz " + customer.Name + " " + customer.Surname);
            customersList.Add(customer);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi");
            Console.WriteLine(customer.Name + " " + customer.Surname);
        }


        public void Show()
        {
            foreach (var item in customersList)
            {
                var customerInfo = $" {item.Id} {item.Name} {item.Surname}";
                Console.WriteLine("Müşteri:" + customerInfo);
            }

            Console.WriteLine("Toplam Kullanıcı Sayısı:" + (customersList.Count));
        }


    }
}





