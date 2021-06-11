using System;
using System.Collections.Generic; 

namespace CatWorx.BadgeMaker
{
    class Program
    {
         static List<Employee> GetEmployees(){

       List<Employee> employees = new List<Employee>();
       
while (true) 
{
Console.WriteLine("Please enter a name: ");
string firstName = Console.ReadLine();
if(firstName == ""){
    break;
}
// Console.Write("Enter first name: ");
// string firstName = Console.ReadLine();
Console.Write("Enter last name: ");
string lastName = Console.ReadLine();
Console.Write("Enter ID: ");
int id = Int32.Parse(Console.ReadLine());
Console.Write("Enter Photo URL: ");
string photoUrl = Console.ReadLine();


Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
employees.Add(currentEmployee);

// for(int i = 0; i < employees.Count; i++){
//     Console.WriteLine(employees[i]);
// };

};
 return employees;

         }

        // static void PrintEmployees(List<Employee> employees){
           
        // }
    
      


//          }

// Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);
       
        

        static void Main(string[] args)
        {

            List<Employee> employees = GetEmployees();
            // PrintEmployees(employees);
                 Util.PrintEmployees(employees);
                 Util.MakeCsv(employees);
                 Util.MakeBadges(employees);

        }

       

//             for(int i = 0; i < employees.Count; i++){
//     Console.WriteLine(employees[i]);
// };
            // Console.WriteLine("Hello World!");
            // string greeting = "Hello";
            // greeting = greeting + "World";
            // Console.WriteLine("greeting: {0}", greeting);

            // double side = 3.14;
            // double area = side * side;
            // // Console.WriteLine($"area {area}");
            // Console.WriteLine("area is a {0}", area.GetType());

        // string stringNum = "2";
        // int intNum = Convert.ToInt16(stringNum);
        // Console.WriteLine(intNum);
        // Console.WriteLine(intNum.GetType());

        // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
        //     {"firstInning", 10},
        //      {"secondInning", 20},
        //       {"thirdInning", 30},
        //        {"fourthInning", 40},
        //         {"fifthInning", 50},

        // };
        // Console.WriteLine("------------------");
        // Console.WriteLine(" Scoreboeard");
        // Console.WriteLine("------------------");
        // Console.WriteLine("Inning | Score");
        // Console.WriteLine(" 1 | {0}", myScoreBoard["firstInning"]);
        //  Console.WriteLine(" 2 | {0}", myScoreBoard["secondInning"]);
        //   Console.WriteLine(" 3 | {0}", myScoreBoard["thirdInning"]);
        //    Console.WriteLine(" 4 | {0}", myScoreBoard["fourthInning"]);
        //     Console.WriteLine(" 5 | {0}", myScoreBoard["fifthInning"]);

        // 
       
     
    
}

}