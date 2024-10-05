using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model.Context
{
    public static class HomieContextSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData
            (
                new Role
                {
                    RoleId = 1,
                    RoleName = "Admin"
                }

            );
        }
    }
}
