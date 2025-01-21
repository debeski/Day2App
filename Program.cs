// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** DAY2 APP ***");
List<Employee> lstEmployees=new List<Employee>
{
    new Employee{Id=1,Name="John",Designation="Manager",Salary=9800.70,DoJ=new DateTime(day:12,month:12,year:2022)},
    new Employee{Id=2,Name="Jane",Designation="Developer",Salary=8500.50,DoJ=new DateTime(day:10,month:10,year:2021)},
    new Employee{Id=3,Name="David",Designation="Hr",Salary=7800.30,DoJ=new DateTime(day:8,month:8,year:2020)},
    new Employee{Id=4,Name="Mark",Designation="Developer",Salary=8800.15,DoJ=new DateTime(day:10,month:8,year:2021)},
    new Employee{Id=5,Name="Sophia",Designation="Tester",Salary=9200.95,DoJ=new DateTime(day:12,month:6,year:2022)},
    new Employee{Id=6,Name="Emma",Designation="Developer",Salary=9000.70,DoJ=new DateTime(day:15,month:1,year:2022)}

};
System.Console.WriteLine($"Number of employees: {lstEmployees.Count}");
System.Console.WriteLine("ID \t Name \t Designation \t Salary \t Date of Joining");
foreach (Employee e in lstEmployees)
{
    Console.WriteLine(e.Id+"\t"+e.Name+"\t"+e.Designation+"\t \t"+e.Salary+"\t \t"+e.DoJ.ToShortDateString());
}