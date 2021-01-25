namespace _24ocakodevdenemeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Update();
            productManager.Add();

            Customer customer = new Customer();
            customer.Id = 11;
            customer.Firstname = "Emre";
            customer.LastName = "Çabuk";
            customer.City = "İstanbu";

            Customer customer1 = new Customer
            {
                Id = 2,
                City = "istanbul",
                Firstname = "Kumsal",
                LastName = "Masal"
            };

            System.Console.WriteLine(customer1.Firstname);
            System.Console.WriteLine(customer.Firstname);
        }
    }
}
