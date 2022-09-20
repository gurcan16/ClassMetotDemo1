using ClassMetotDemo;

class Program
{
    static void Main(string[] args)
    {

        Customer customer1 = new Customer();
        customer1.Id = 27;
        customer1.Name = "Gürcan";
        customer1.Surname = "ALTIPARMAK";

        Customer customer2 = new Customer();
        customer2.Id = 16;
        customer2.Name = "Barış";
        customer2.Surname = "YARAŞ";

        Customer[] customers = new Customer[] { customer1, customer2 };

        foreach (var customer in customers)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname);
        }
        Console.WriteLine(" ");

        CustomerManager customerManager = new CustomerManager();

        customerManager.Add(customer1);
        Console.WriteLine(" ");
        customerManager.Add(customer2);
        Console.WriteLine("----------------------------");
        customerManager.Delete(customer1);
        Console.WriteLine(" ");
        customerManager.Delete(customer2);
        customerManager.Show();
    }
}
