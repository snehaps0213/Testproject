using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    public class Organization
    {
        int orgid;

        public int OrganizationId
        {
            get { return orgid; }
            set { orgid = value; }
        }
        string orgname;

        public string OrganizationName
        {
            get { return orgname; }
            set { orgname = value; }
        }
        string orgaddr;

        public string OrganizationAddress
        {
            get { return orgaddr; }
            set { orgaddr = value; }
        }
        string orgcategory;

        public string OrganizationCategory
        {
            get { return orgcategory; }
            set { orgcategory = value; }
        }

        List<Department> departments;

        internal List<Department> Departments
        {
            get { return departments; }
            set { departments = value; }
        }

    }
}
