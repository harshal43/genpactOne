//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConAppMethod
//{
//    public class Emp
//    {
//        public string Fullname(string fName, string lName)
//        {
//            return fName +" "+ lName;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Emp emp = new Emp();
//            Console.WriteLine(emp.Fullname("harshal", "bharatkar"));
//            Console.WriteLine(emp.Fullname("harshal1", "bharatkar1"));
//            Console.WriteLine(emp.Fullname(lName:"shrama", fName:"vivek"));
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;

//namespace ConAppMethod
//{
//    public class Emp
//    {
//        public void Display(string name, int id, string city = "delhi")
//        {
//            Console.WriteLine("Details as follows");
//            Console.WriteLine($"ID:\t{id} Name:\t{name} City:\t{city}");
//        }
//         public void Add(int num1 = 10, int num2 = 20, int num3 = 30)
//        {
//            int result = num1 + num2 + num3;
//            Console.WriteLine($"Result after adding {num1}, {num2} and {num3} is =\t {result}");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Emp emp = new Emp();
//            emp.Display("harshal", 10);
//            emp.Display("harshal", 10, "noida");

//            emp.Add();
//            emp.Add(1);
//            emp.Add(1,1,2);
//            emp.Add(1,2);

//            Console.ReadKey();
//        }
//    }
//}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConAppMethod
{
    public class Employee
    {
        public void Salary(int wHors, int nWDays, int projHandles, int extra)
        {
            int salary = wHors * nWDays * 100 + projHandles * 3000 + extra * 2000;
            Console.WriteLine($"Salary is:\tRs.{salary}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string desig;
            Employee emp = new Employee();
            Console.WriteLine("Enter employee designation");
            desig = Console.ReadLine();
            switch (desig)
            {
                case "HR":
                    {
                        int wh;
                        int wd;
                        Console.WriteLine("Enter working hours");
                        wh = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter working days");
                        wd = int.Parse(Console.ReadLine());
                        emp.Salary(wh, wd, 1, 0);
                        break;
                    }
                case "Admin":
                    {
                        int wh;
                        int wd;
                        int ph;
                        Console.WriteLine("Enter working hours");
                        wh = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter working days");
                        wd = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter projects handle");
                        ph = int.Parse(Console.ReadLine());
                        emp.Salary(wh, wd, ph, 0);
                        break;
                    }
                case "Software Developer":
                    {
                        int wh;
                        int wd;
                        int ph;
                        int ex;
                        Console.WriteLine("Enter working hours");
                        wh = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter working days");
                        wd = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter projects handle");
                        ph = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter extras");
                        ex = int.Parse(Console.ReadLine());
                        emp.Salary(wh, wd, ph, ex);
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
