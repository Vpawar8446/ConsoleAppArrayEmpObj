using System;

namespace ConsoleAppArrayEmpObj
{
    class Employee
    {
        int empId;
        string name;
        //Employee class constructor
        public Employee(int eid, string n)
        {
            empId = eid;
            name = n;
        }
        public void showData()
        {
            Console.WriteLine(" EmpId = " + empId + "\n" + " Employee Name = " + name);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //create array of employee object  
            Employee[] obj = new Employee[2];

            //create & initialize actual employee objects using constructor
            obj[0] = new Employee(100, "ABC");
            obj[1] = new Employee(200, "XYZ");

            //display the employee object data
            Console.WriteLine("Employee Object 1 :");
            obj[0].showData();
            Console.WriteLine("Employee Object 2 :");
            obj[1].showData();
        }
    }
}



