using System;
using System.Collections;

namespace Employee_Wage_Computation1
{

    public interface IWageCalculator
    {
        void AddCompanyDetails(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
        void CalculateTotalEmpWage();
        void GetWagesOfCompany(string companyName);
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmpWageCalculator empWageCalculator = new EmpWageCalculator();

            //Add the details of all the companyList first
            empWageCalculator.AddCompanyDetails("Reliance", 60, 20, 100);
            empWageCalculator.AddCompanyDetails("Flipkart", 40, 20, 80);

            //Compute emp wage of the added companies
            empWageCalculator.CalculateTotalEmpWage();                        

            //Get the emp wage of the queried company
            empWageCalculator.GetWagesOfCompany("Reliance");                    

        }

       
    }

}
