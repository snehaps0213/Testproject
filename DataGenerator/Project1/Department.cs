using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    public class Department
    {
        int deptid;

        public int DepartmentId
        {
            get { return deptid; }
            set { deptid = value; }
        }
        string deptname;

        public string DepartmentName
        {
            get { return deptname; }
            set { deptname = value; }
        }

        string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        int orgid;

        public int Organizationid
        {
            get { return orgid; }
            set { orgid = value; }
        }

        List<Service> services;

        internal List<Service> Services
        {
            get { return services; }
            set { services = value; }
        }

    }
}
