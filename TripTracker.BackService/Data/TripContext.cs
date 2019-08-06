using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripTracker.BackService.Models;
using Microsoft.EntityFrameworkCore;

namespace TripTracker.BackService.Data
{
    public class TripContext:DbContext
    {
        public DbSet<Trip> Trips{ get; set; }
    }
}
