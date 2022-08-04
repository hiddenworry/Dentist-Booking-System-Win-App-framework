using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusinessObject.Models
{
    public partial class DBSContext : DbContext
    {
        public DBSContext()
        {
        }

        public DBSContext(DbContextOptions<DBSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppointmentService> AppointmentServices { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server =(local); Database = DBS; Uid=sa; Pwd=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("role");

                entity.Property(e => e.Status)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("status");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DentistId).HasColumnName("dentist_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Status)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("status");

                entity.Property(e => e.Time)
                    .HasColumnType("date")
                    .HasColumnName("time");

                entity.Property(e => e.WorkingHour)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("working_hour");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointme__custo__2E1BDC42");

                entity.HasOne(d => d.Dentist)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DentistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointme__denti__2F10007B");
            });

            modelBuilder.Entity<AppointmentService>(entity =>
            {
                entity.HasKey(e => new { e.AppointmentId, e.ServiceId })
                    .HasName("PK__Appointm__46E8F376D4B620EB");

                entity.ToTable("Appointment_Service");

                entity.Property(e => e.AppointmentId).HasColumnName("appointment_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentServices)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointme__appoi__300424B4");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.AppointmentServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointme__servi__30F848ED");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EstimatedTime).HasColumnName("estimated_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name");

                entity.Property(e => e.ServiceTypeId).HasColumnName("service_type_id");

                entity.Property(e => e.Status)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("status");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Service__service__31EC6D26");
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.ToTable("Service_Type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
