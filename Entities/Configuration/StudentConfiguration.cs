using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.Property(s => s.Age)
                .IsRequired(false);
            builder.Property(s =>s.IsRegularStudent)
                .IsRequired(true);
            builder.HasMany(e => e.Evaluations)
                  .WithOne(s => s.Student)
                  .HasForeignKey(s => s.StudentId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Student
                {
                    StudentId = Guid.NewGuid(),
                    Name = "John Doe",
                    Age = 30
                },
                new Student
                {
                    StudentId = Guid.NewGuid(),
                    Name = "John Depp",
                    Age = 25
                },
                new Student
                {
                    StudentId = Guid.NewGuid(),
                    Name = "Mike Miles",
                    Age = 29
                },
                new Student
                {
                    StudentId = Guid.NewGuid(),
                    Name = "TEST Name",
                    Age = 100
                }
                );
        }
    }
}
