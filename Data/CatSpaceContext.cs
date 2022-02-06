using ASPCatSpace.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCatSpace.Data
{

    public class CatSpaceContext : DbContext
    {
        public DbSet<Cat> Cat { get; set; }
        public CatSpaceContext(DbContextOptions<CatSpaceContext> options):base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{            
        //    if (optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=.;Database=CatsDB_MVC;Trusted_Connection=True;MultipleActiveResultSets=true");
        //            //"Data Source=.;Database=CatSpace;Integrated Security=True");
        //    }
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
