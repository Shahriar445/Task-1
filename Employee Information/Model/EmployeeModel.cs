using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Information.Model
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Dob { get; set; }
        public string DateofJoing { get; set; }
        public string BloodGroup { get; set; }
        public int DepartmentId { get; set; }
        public bool IsActive { get; set; }
    }
}
