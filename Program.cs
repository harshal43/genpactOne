using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethod
{
    public class Emp
    {
        public string Fullname(string fName, string lName)
        {
            return fName +" "+ lName;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            Console.WriteLine(emp.Fullname("harshal", "bharatkar"));
            Console.WriteLine(emp.Fullname("harshal1", "bharatkar1"));
            Console.WriteLine(emp.Fullname(lName:"shrama", fName:"vivek"));
            Console.ReadKey();
        }
    }
}
