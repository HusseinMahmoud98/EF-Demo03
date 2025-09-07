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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Departments>
    {
        public void Configure(EntityTypeBuilder<Departments> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id)
                .UseIdentityColumn(100, 100);

            builder.Property(d => d.Name)
                .HasColumnName("Dept_Name")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.HasOne(d => d.Manager)
                .WithOne(e => e.ManageDept)
                .HasForeignKey<Departments>(d => d.ManagerId);
                

        }
    }
}
