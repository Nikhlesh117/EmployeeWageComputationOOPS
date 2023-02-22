namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage computation problem");


            IComputeEmgWage ManageCompanyInterface = new ComputeWage();

            ManageCompanyInterface.addCompanyEmpWage("TaTa", 20, 20, 160);
            ManageCompanyInterface.addCompanyEmpWage("Jindal", 10, 20, 120);
            ManageCompanyInterface.computeEmpWage();



        }
    }
}