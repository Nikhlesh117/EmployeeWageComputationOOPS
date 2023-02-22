namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage computation problem");


            ComputeWage obj = new ComputeWage("TaTa", 20, 20, 160);
            obj.computeEmpWage();
            Console.WriteLine(obj.toString());

            ComputeWage obj1 = new ComputeWage("Jindal", 10, 20, 120);
            obj1.computeEmpWage();
            Console.WriteLine(obj1.toString());




        }
    }
}