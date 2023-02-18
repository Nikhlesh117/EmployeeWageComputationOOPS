namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage computation problem");


            ComputeWage MultipleCompany = new ComputeWage();
            MultipleCompany.calculateWage("TaTa", 20, 20, 160);
            MultipleCompany.calculateWage("Jindal", 10, 20, 120);



        }
    }
}