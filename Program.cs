using System;

namespace Employee_Wage_Computation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Random r = new Random();
            int random_Num = r.Next(0, 2);
            string emp_Check = "";
            if(random_Num==1)
            {
                emp_Check = "Present";
                Console.WriteLine("Employee is {0}", emp_Check);
            }
            else
            {
                emp_Check = "Absent";
                Console.WriteLine("Employee is {0}", emp_Check);
            }
                
        }
    }
}
