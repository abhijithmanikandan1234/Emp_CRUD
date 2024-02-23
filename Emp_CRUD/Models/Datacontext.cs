using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Emp_CRUD.Models
{
    public class Datacontext:DbContext
    {
        public DbSet<Employee> employees { get; set; }
    }
}