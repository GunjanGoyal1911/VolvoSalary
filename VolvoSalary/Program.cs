namespace VolvoSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operator Oliver = new Operator("Oliver Brage", "Operator", "940815-9111",10,0,true,true);
            Operator Benjamin = new Operator("Benjamin Kjellgren", "Operator", "920805-1121",0,0,false,true);
            Operator Alexander = new Operator("Alexander Brasjo", "Operator","910528-4321", 5, 20, false,true);
            //Console.WriteLine("Oliver salary = " + (Oliver.CalculateSalary());
            //Console.WriteLine("Benjamin salary = " +Benjamin.CalculateSalary());
            //Console.WriteLine("Alexander salary = " + Alexander.CalculateSalary());

            Manager Vincent = new Manager("Vincent Kaveh", "Manager", "900608-1020", 3, true);

            Vincent.AddEmployee(Oliver);
            //Console.WriteLine("Vincent Salary= " + Vincent.CalculateSalary());
            Manager Ali = new Manager("Ali Kathes","Manager","900407-7777",7, false);
            Ali.AddEmployee(Benjamin);
            Ali.AddEmployee(Alexander);
            //Console.WriteLine("Alis salary= " + Ali.CalculateSalary());

            List<string> technologies = new List<string>() { "c#", "react",".net", "sql", "python"}; 
            Developer Angela = new Developer("Angela Emanuelsson", "Developer", "770813-1337", 2, Developer.DeveloperRole.Junior, technologies);
            Angela.FinishProject();
            Angela.FinishProject();
            //Console.WriteLine("Angelas Salary= " + Angela.CalculateSalary());

            Developer Robin = new Developer("Robin Kamo", "Developer", "910604-1336",0, Developer.DeveloperRole.Senior, technologies );
            Robin.FinishProject();
            //Console.WriteLine("Robins salary=" + Robin.CalculateSalary());

            Manager Robert = new Manager("Robert Jakobsen", "Manager", "841127-8181", 17, false);
            Robert.AddEmployee(Robin);
            Robert.AddEmployee(Angela);
            //Console.WriteLine("Roberts Salary = " + Robert.CalculateSalary());

            Console.WriteLine("------Salary breakdown-------- ");
            Console.WriteLine();
            Console.WriteLine($"Name: {Oliver.Name}");
            Console.WriteLine($"Position: {Oliver.Position}");
            Console.WriteLine($"Salary: {Oliver.CalculateSalary()}");
            Console.WriteLine("-------------------------------");

            Console.WriteLine($"Name: {Benjamin.Name}");
            Console.WriteLine($"Position: {Benjamin.Position}");
            Console.WriteLine($"Salary: {Benjamin.CalculateSalary()}");
            Console.WriteLine("-------------------------------");

            Console.WriteLine($"Name: {Alexander.Name}");
            Console.WriteLine($"Position: {Alexander.Position}");
            Console.WriteLine($"Salary: {Alexander.CalculateSalary()}");
            Console.WriteLine("-------------------------------");

            Console.WriteLine($"Name: {Angela.Name}");
            Console.WriteLine($"Position: {Angela.Position}");
            Console.WriteLine($"Salary: {Angela.CalculateSalary()}");
            Console.WriteLine("-------------------------------");

            Console.WriteLine($"Name: {Robin.Name}");
            Console.WriteLine($"Position: {Robin.Position}");
            Console.WriteLine($"Salary: {Robin.CalculateSalary()}");
            Console.WriteLine("-------------------------------");


            Console.WriteLine($"Name: {Robert.Name}");
            Console.WriteLine($"Position: {Robert.Position}");
            Console.WriteLine($"Salary: {Robert.CalculateSalary()}");
            Console.WriteLine("-------------------------------");



        }
    }
}