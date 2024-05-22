using Employee_Information;

public class Program
{
    public static void Main(string[] args)
    {
        //creating employee list
        List<Employee> employees = new List<Employee>();

        Console.Write("Enter how many Employee you want to add: ");
        int numOfEmployees = int.Parse(Console.ReadLine());


        for (int i =1;i<= numOfEmployees; i++)
        {
            Console.WriteLine($"\nEmployee {i} Information");

            Console.Write("Enter Employee Id : ");
            int id = int.Parse(Console.ReadLine());

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


            employees.Add(new Employee(id, name, code, dof, doj, blood, dId, active));

        }
       

       


        foreach (var employee in employees)
        {

            Console.WriteLine($" Employee Id :{employee.Id} \n Employee Name:  {employee.Name} \n Employee Code : { employee.Code}\n Employee Department: {employee.DepartmentId}\n Employee Blood Group:{employee.BloodGroup}\n Employee Date of Joing : {employee.DateofJoing}\n Employee Date of Birth:{employee.Dob}\n Employee Active/InActive: {employee.IsActive}");
        }



        List<Department> department = new List<Department>();
      

       
    }
}