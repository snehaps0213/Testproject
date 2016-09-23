using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    public class Customer
    {
        int custid;

        public int CustomerId
        {
            get { return custid; }
            set { custid = value; }
        }
        string custname;

        public string CustomerName
        {
            get { return custname; }
            set { custname = value; }
        }
        string custemailid;

        public string CustomerEmail
        {
            get { return custemailid; }
            set { custemailid = value; }
        }
        string custphno;

        public string CustomerPhoneNumber
        {
            get { return custphno; }
            set { custphno = value; }
        }
        string custaddr;

        public string CustomerAddress
        {
            get { return custaddr; }
            set { custaddr = value; }
        }
        CustomerType custtype;

        internal CustomerType CustomerType
        {
            get { return custtype; }
            set { custtype = value; }
        }
        int serviceid;

        public int ServiceId
        {
            get { return serviceid; }
            set { serviceid = value; }
        }

    }
}
