using Microsoft.EntityFrameworkCore;
using MvcNetCoreEF2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Data
{
    public class DoctoresContext: DbContext
    {
        public DoctoresContext
            (DbContextOptions<DoctoresContext> options) : base(options) { }
        public DbSet<Doctor> Doctores { get; set; }
    }
}
