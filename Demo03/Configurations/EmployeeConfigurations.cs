using Demo03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
           builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).UseIdentityColumn(10, 10);
            builder.Property(e => e.Name)
                .HasColumnName("Emp_Name")
                .HasColumnType("varchar")
                .HasMaxLength(100);
            builder.Property(e => e.Salary)
                .HasColumnType("money");

            builder.Property(e=>e.Address)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.HasOne(e => e.WorkFor)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DeptId);

        }
    }
}
