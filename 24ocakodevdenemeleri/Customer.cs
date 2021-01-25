using System;
using System.Collections.Generic;
using System.Text;

namespace _24ocakodevdenemeleri
{
    class Customer
    {
        public int Id { get; set; }
        private string _firstName;
        public string Firstname
        { 
            get { return "Mrs." + _firstName; }
            set { _firstName = value; }
        
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
