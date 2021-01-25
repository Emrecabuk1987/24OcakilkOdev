using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            IcustomerDal[] customerDals = new IcustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal(),
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Delete();


            }



        }

        private static void Demo()
        {
                CustomerManager customerManager = new CustomerManager();
                customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer1 = new Customer
            {
                    Id = 1,
                    FirstName = "Emre",
                    LastName = "Çabuk",
                    Address = "Tomruk Sk.",

            };

            Student student = new Student
            {
                    Id = 2,
                    FirstName = "Kumsal",
                    LastName = "Masal",
                    Departmant = "High School",
            };

            personManager.Add(customer1);
            personManager.Add(student);
            
        }
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }



        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }

        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
