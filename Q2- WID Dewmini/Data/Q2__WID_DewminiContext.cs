using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Q2__WID_Dewmini.Models;

namespace Q2__WID_Dewmini.Data
{
    public class Q2__WID_DewminiContext : DbContext
    {
        public Q2__WID_DewminiContext (DbContextOptions<Q2__WID_DewminiContext> options)
            : base(options)
        {
        }

        public DbSet<Q2__WID_Dewmini.Models.Student> Student { get; set; } = default!;
    }
}
