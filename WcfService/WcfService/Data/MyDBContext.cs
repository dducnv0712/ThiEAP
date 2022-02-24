using WcfService.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManage.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext():base("name=ThiEAPConnectionString")
        {

        }
        public DbSet<Employee> employees { get; set; }
 
       
    }
}