﻿using System;

namespace EmployeeMangement2
{
    internal class Program_uc_6
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_W0KING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;


        static void Main(string[] args)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs < MAX_HRS_IN_MONTH && totalWorkingDays < MAX_HRS_IN_MONTH)
            {
                totalWorkingDays++;
                Random randon = new Random();
                int empCheck = randon.Next(0, 3);

                switch (empCheck)
                {

                    case IS_PART_TIME: empHrs = 4; break;

                    case IS_FULL_TIME: empHrs = 8; break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day#:"+totalWorkingDays + "Emp Hrs : " + empHrs);



            }
            int totalEmpWage = totalEmpHrs + EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);

        }
    }
}