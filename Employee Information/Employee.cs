using Employee_Information.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employee_Information
{
    public class Employee
    {
        string Path = @"C:\Users\Hameem\Desktop\Intern - Shahriar Haque (Shipon)\C# Console\Employee Information\Employee Information\employeeData.json";
        //creating employee list
        List<EmployeeModel> employees = new List<EmployeeModel>();
       
        
       
        public async void SaveEmployeeData()
        {
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            var json = JsonSerializer.Serialize(employees,option);

           await File.WriteAllTextAsync(Path, json);
            Console.WriteLine("Employee data saved to " + Path);
        }

        public void  AddEmployee()
        {
            Console.Write("Enter how many Employee you want to add: ");
            int numOfEmployees = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numOfEmployees; i++)

            {

                Console.WriteLine($"\nEmployee {i} Information");

                Console.Write("Enter Employee Id : ");
                int id = int.Parse(Console.ReadLine());
                // Check if an employee with the same ID already exists
                if (employees.Any(e => e.Id == id))
                {
                    Console.WriteLine($"Employee with ID {id} already exists. Skipping this employee.");
                    continue;
                }
                else
                {
                    Console.Write("Enter Employee Name : ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Employee Code : ");
                    string code = Console.ReadLine();

                    Console.Write("Enter Emplyee Date of Birth : ");
                    string dof = Console.ReadLine();
                    Console.Write("Enter Employee Date of Joing : ");
                    string doj = Console.ReadLine();

                    Console.Write("Enter Employee Blood Group : ");
                    string blood = Console.ReadLine();

                    Console.Write("Enter Employee Department id : ");
                    int dId = int.Parse(Console.ReadLine());

                    Console.Write("Enter Employee IsActive? (true/false) : ");
                    bool active = bool.Parse(Console.ReadLine());

                    employees.Add(new EmployeeModel { Id = id, Name = name, BloodGroup = blood, Code = code, DateofJoing = doj, DepartmentId = dId, Dob = dof, IsActive = active });
                }

               

            }
        }
        public void ModifyEmployee()
        {
            Console.Write("Enter Employee ID to modify: ");
            int employeeId = int.Parse(Console.ReadLine());

            EmployeeModel employee = employees.Find(e => e.Id == employeeId);
            if (employee == null)
            {
                Console.WriteLine("Employee not found.");
                return;
            }

            //employee.ModifyEmployee();
        }
      public void  ReadFromJson()
        {
            var op = File.ReadAllText(Path);

            employees = JsonSerializer.Deserialize<List<EmployeeModel>>(op);
      

        }
       public  void DisplayAllEmployees()
        {
            ReadFromJson();
            foreach (var employee in employees)
            {

                Console.WriteLine($" Employee Id :{employee.Id} \n Employee Name:  {employee.Name} \n Employee Code : {employee.Code}\n Employee Department: {employee.DepartmentId}\n Employee Blood Group:{employee.BloodGroup}\n Employee Date of Joing : {employee.DateofJoing}\n Employee Date of Birth:{employee.Dob}\n Employee Active/InActive: {employee.IsActive}");
                Console.WriteLine
                    ();
            }
        }

       
    }
}
