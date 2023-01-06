namespace EmployeeMangement2
{
    internal class Program_uc_5
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_W0KING_DAYS = 20;


        static void Main(string[] args)
        {
            int empHrs = 0, empWages = 0, totalEmpWage = 0;

            for (int day = 0; day < NUM_OF_W0KING_DAYS; day++)
            {

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
                empWages = empHrs * EMP_RATE_PER_HOUR;

                totalEmpWage = totalEmpWage + empWages;
                Console.WriteLine("Emp wage : " + empWages);

            }

            Console.WriteLine("Total Emp Wage : " + totalEmpWage);



        }
    }
}