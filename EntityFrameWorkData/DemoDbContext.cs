using EntityFrameWorkData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkData
{
    public class DemoDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeEducation> EmployeEducations { get; set; }
        public DemoDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=DESKTOP-AMR2CQS\MSSQLSERVER01;Initial Catalog=EfcoreCodeFirst;Integrated Security=True");
        }
        
        
    }
}
