﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation1
{
    class Company
    {
        
        internal string companyName;
        internal int wagePerHour;
        internal int maxWorkingDays = 0;
        internal int maxWorkingHours;
        internal int totalEmpWage;
        public List<int> dailyWage = new List<int>() ;
        

        public Company(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }

        public void SaveDailyWage(int dailyWage)
        {
            // Add working day and its daily wage
            this.dailyWage.Add(dailyWage);
        }
    

        public void SaveTotalWage(int totalWage)
        {
            //Save total emp wage
            totalEmpWage = totalWage;
        }
       
    }
}
