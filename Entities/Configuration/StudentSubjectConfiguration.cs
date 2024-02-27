﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasKey(s => new { s.StudentId, s.SubjectId });

            builder.HasOne(ss => ss.Student)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.StudentId);

            builder.HasOne(ss => ss.Subject)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.SubjectId);
        }
    }
}
