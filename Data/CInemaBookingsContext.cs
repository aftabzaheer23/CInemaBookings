using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CInemaBookings.Models;

namespace CInemaBookings.Data
{
    public class CInemaBookingsContext : DbContext
    {
        public CInemaBookingsContext (DbContextOptions<CInemaBookingsContext> options)
            : base(options)
        {
        }

        public DbSet<CInemaBookings.Models.Movie> Movie { get; set; } = default!;
    }
}
