using Microsoft.EntityFrameworkCore;
using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.DataAccess
{
    class ParkingLocationsOnTheMapDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-H45A4ON; Database=ParkingLocationsOnTheMapDb;uid=sefa;password=sefa");
        }
        public DbSet<ISPARK_DATA> IsparkData { get; set; }
        public DbSet<NEW_ISPARK_DATA> NewIsparkData { get; set; }
        public DbSet<USER> Users { get; set; }
        public DbSet<USER_ACCESS> UserAccess { get; set; }
    }

}
