using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    internal class Crud
    {
        private static void Main(string[] args)
        {
            var emp = new Employee()
            {
                empName = "Jognesh",
                empNo = 2000,
                salary = 60000,
                dptCode = 102,
                mgrEmpNo = 1001,
            };
            var cemp = new CrudEmployee();
            cemp.addEmployee(emp);
        }
    }
}