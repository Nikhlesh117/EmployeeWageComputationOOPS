namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage computation problem");


            ComputeWage ManageCompany = new ComputeWage();

            ManageCompany.addCompanyEmpWage("TaTa", 20, 20, 160);
            ManageCompany.addCompanyEmpWage("Jindal", 10, 20, 120);
            ManageCompany.computeEmpWage();



        }
    }
}