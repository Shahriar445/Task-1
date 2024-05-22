using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Information
{
    public class Employee
    {
        public int Id { get;  }
        public string Name { get;  }
        public string Code { get; }
        public string Dob { get; }
        public string DateofJoing { get;  }
        public string BloodGroup { get;  }
        public int DepartmentId { get;  }
        public bool IsActive { get;  }
       

       public Employee(int id, string name, string code, string dob, string dateofjoin, string bloodgroup, int departmentid,bool isactive)
        {
            Id = id;
                Name = name;
                Code = code;
                Dob = dob;  
                DateofJoing = dateofjoin;
                BloodGroup = bloodgroup;
               DepartmentId = departmentid;
                IsActive = isactive;
                   
        }

       
    }
}
