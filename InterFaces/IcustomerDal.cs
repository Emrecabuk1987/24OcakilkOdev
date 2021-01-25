using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IcustomerDal
    {
        void Add();
        void Update();
        void Delete();


    }
    class SqlServerCustomerDal : IcustomerDal

    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    class OracleCustomerDal : IcustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }
    class MySqlCustomerDal : IcustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");
        }
    }
    class CustomerManager
    {
        public void Add(IcustomerDal customerdDal)
        {
            customerdDal.Add();
        }
    }
}
