using LMS.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositary
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public EmployeeDbContext() : base("EmployeeDbContext")
        {

        }
    }
}
