using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entities.Entities;

public partial class VerduleriaContext : DbContext
{
    public VerduleriaContext()
    {
    }

    public VerduleriaContext(DbContextOptions<VerduleriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<HorariosEmpleado> HorariosEmpleados { get; set; }

    public virtual DbSet<VentasVerdura> VentasVerduras { get; set; }

    public virtual DbSet<Verdura> Verduras { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=NIKKOLITO\\SQLEXPRESS;Database=verduleria;Integrated Security=True;Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__empleado__1299A86142190B18");

            entity.ToTable("empleados");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.CarEmpId).HasColumnName("car_emp_id");
            entity.Property(e => e.DepEmpId).HasColumnName("dep_emp_id");
            entity.Property(e => e.EmpApellido1)
                .HasMaxLength(20)
                .HasColumnName("emp_apellido1");
            entity.Property(e => e.EmpDireccion)
                .HasMaxLength(45)
                .HasColumnName("emp_direccion");
            entity.Property(e => e.EmpEmail)
                .HasMaxLength(45)
                .HasColumnName("emp_email");
            entity.Property(e => e.EmpNombre1)
                .HasMaxLength(20)
                .HasColumnName("emp_nombre1");
            entity.Property(e => e.EmpTelcelular)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("emp_telcelular");
            entity.Property(e => e.EspEmpId).HasColumnName("esp_emp_id");
            entity.Property(e => e.GenGeneroGenId).HasColumnName("gen_genero_gen_id");
        });

        modelBuilder.Entity<HorariosEmpleado>(entity =>
        {
            entity.HasKey(e => e.HorarioId).HasName("PK__Horarios__BB881A9E194D2C0E");

            entity.Property(e => e.HorarioId)
                .ValueGeneratedNever()
                .HasColumnName("HorarioID");
            entity.Property(e => e.DiaSemana)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
        });

        modelBuilder.Entity<VentasVerdura>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__VentasVe__BC1240BD03A50DE6");

            entity.Property(e => e.IdVenta).ValueGeneratedNever();
            entity.Property(e => e.CostoTotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Verdura>(entity =>
        {
            entity.HasKey(e => e.VerduraId).HasName("PK__Verduras__7DE62A95A9FAD328");

            entity.Property(e => e.VerduraId)
                .ValueGeneratedNever()
                .HasColumnName("Verdura_id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
