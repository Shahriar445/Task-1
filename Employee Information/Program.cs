using Employee_Information;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Security.Cryptography;

public class Program
{

    // Deserilazation 
    static List<Department> LoadDepartmentsFromJson(string filePath)
    {
        var json = File.ReadAllText("C:\\Users\\Hameem\\Desktop\\Intern - Shahriar Haque (Shipon)\\C# Console\\Employee Information\\Employee Information\\Department.json");
        return JsonConvert.DeserializeObject<List<Department>>(json);
    }
    public static void Main(string[] args)
    {

        // Deserilazation 
        string jsonFilePath = "Department.json";
        var departments = LoadDepartmentsFromJson(jsonFilePath);

        //foreach (var department in departments)
        //{
        //    Console.WriteLine($"DepartmentId: {department.DepartmentId}");
        //    Console.WriteLine($"DepartmentName: {department.DepartmentName}");
        //    Console.WriteLine($"IsActive: {department.IsActive}");
        //    Console.WriteLine();
        //}

        


        // Called the employee class and methods 

        Employee employee_1 = new Employee();
    
     
        


        int choice;
        do
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Modify Employee");
            Console.WriteLine("3. Display All Employees");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    employee_1.AddEmployee();
                    employee_1.SaveEmployeeData();
                    break;
                case 2:
                    employee_1.ModifyEmployee();
                    break;
                case 3:
                    employee_1.DisplayAllEmployees();
                    break;
            }

        } while (choice != 4);




        Console.WriteLine();

       
    }

    
}