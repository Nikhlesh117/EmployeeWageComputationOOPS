namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage computation problem");


            EmployeeCheck SwitchCase = new EmployeeCheck();
            SwitchCase.CheckEmployee();



        }
    }
}