using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Information
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool IsActive { get; set; }

    
        public Department(int id, string Dname, bool isactive)
        {
            DepartmentId = id;
                DepartmentName = Dname;
            IsActive = isactive;
        }
        public void Departmentdetails()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department(001, "HR", true));
            list.Add(new Department(002, "IT", true));
            list.Add(new Department(003, "Business", false));
            list.Add(new Department(004, "Admin", true));
           
        }
    }
   
}
