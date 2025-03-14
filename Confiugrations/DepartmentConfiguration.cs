using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session03Assignment.Entities;

namespace Session03Assignment.Confiugrations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasOne(d => d.Manager)
            .WithOne(i => i.ManagedDepartment)
            .HasForeignKey<Department>(d => d.ManagerId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
