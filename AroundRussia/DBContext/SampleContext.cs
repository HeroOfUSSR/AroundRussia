using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AroundRussia.DBContext
{
    public class SampleContext : IDesignTimeDbContextFactory<AroundRussiaContext>
    {
        public AroundRussiaContext CreateDbContext(string[] args) => new AroundRussiaContext(DBOptions.Options());
    }
}
