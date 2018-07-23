using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeInfo e1 = new EmployeeInfo { Name = "Deepa", Dept = "Training", Salary = 45000 };
            EmployeeInfo e2 = new EmployeeInfo { Name = "Martin", Dept = "Accounts", Salary = 22000 };
            CodeDBEntities db = new CodeDBEntities();
            db.EmployeeInfos.Add(e1);
            db.EmployeeInfos.Add(e2);
            var res = db.SaveChanges();
            if (res > 0)
                Console.WriteLine("Data Inserted");
        }
    }
}
