using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    public class Service
    {

        int serviceid;

        public int ServiceId
        {
            get { return serviceid; }
            set { serviceid = value; }
        }

        string servicename;

        public string ServiceName
        {
            get { return servicename; }
            set { servicename = value; }
        }

        int departmentid;

        public int DepartmentId
        {
            get { return departmentid; }
            set { departmentid = value; }
        }


        List<Customer> customers;

        internal List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }


    }
}
