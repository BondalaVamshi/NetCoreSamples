using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessFormTask.Models;

namespace BusinessFormTask.Models
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<PersonPropertie> PersonProperties { get; set; }
    }
}
