using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentRegistration.Models;

public partial class StudentEducationPortalDbContext : DbContext
{
    public StudentEducationPortalDbContext()
    {
    }

    public StudentEducationPortalDbContext(DbContextOptions<StudentEducationPortalDbContext> options)
        : base(options)
    {
    }

    public static IEnumerable<object> TblStudentRegTable { get; internal set; }
    public virtual DbSet<TblStudentRegTable> TblStudentRegTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=DESKTOP-OKN4EUA\\SQLEXPRESS;Database=StudentEducationPortalDb;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblStudentRegTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblStude__3214EC07BB135439");

            entity.ToTable("tblStudentRegTable");

            entity.Property(e => e.SchoolName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchoolNameHindi).HasMaxLength(50);
            entity.Property(e => e.SchoolTypeCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SchoolUdisecode)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SchoolUDISECode");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
