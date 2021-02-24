using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PmcDeveloperAssessment.Entities
{
    public partial class DBInterviewContext : DbContext
    {
        public DBInterviewContext()
        {
        }

        public DBInterviewContext(DbContextOptions<DBInterviewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerVehicle> CustomerVehicle { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<ZipCode> ZipCode { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=DB-Interview;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.Address1);

                entity.HasIndex(e => e.City);

                entity.HasIndex(e => e.DateCreated)
                    .HasName("ix_Address_DateCreated");

                entity.HasIndex(e => e.DateModified)
                    .HasName("ix_Address_DateModified");

                entity.HasIndex(e => e.State);

                entity.HasIndex(e => e.Zip);

                entity.Property(e => e.AddressId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address1)
                    .HasColumnName("Address")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.CustomerVehicleId);

                entity.HasIndex(e => e.DateModified)
                    .HasName("ix_Contract_DateModified");

                entity.HasIndex(e => e.InternalId)
                    .HasName("UN_Contract_InternalId")
                    .IsUnique();

                entity.Property(e => e.ContractId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCancelled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InternalId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Customer");

                entity.HasOne(d => d.CustomerVehicle)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.CustomerVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_CustomerVehicle");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.AddressId);

                entity.HasIndex(e => e.DateCreated);

                entity.HasIndex(e => e.DateModified);

                entity.HasIndex(e => e.EmailAddress);

                entity.HasIndex(e => e.FirstName);

                entity.HasIndex(e => e.LastName);

                entity.HasIndex(e => e.Phone);

                entity.Property(e => e.CustomerId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeOwner)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SpouceLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpouseFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Address");
            });

            modelBuilder.Entity<CustomerVehicle>(entity =>
            {
                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.DateCreated)
                    .HasName("ix_CustomerVehicle_DateCreated");

                entity.HasIndex(e => e.DateModified)
                    .HasName("ix_CustomerVehicle_DateModified");

                entity.Property(e => e.CustomerVehicleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Awd).HasColumnName("AWD");

                entity.Property(e => e.Aws).HasColumnName("AWS");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Make)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyClass)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Style)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Trim)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Vinnumber)
                    .HasColumnName("VINNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerVehicle)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerVehicle_Customer");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.CustomerVehicle)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_CustomerVehicle_Vehicle");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasIndex(e => e.DateCreated)
                    .HasName("ix_Vehicle_DateCreated");

                entity.HasIndex(e => e.DateModified)
                    .HasName("ix_Vehicle_DateModified");

                entity.HasIndex(e => e.Make);

                entity.HasIndex(e => e.Model);

                entity.HasIndex(e => e.Style);

                entity.HasIndex(e => e.Trim);

                entity.HasIndex(e => e.VehicleYear);

                entity.HasIndex(e => e.VinPattern);

                entity.HasIndex(e => new { e.Trim, e.VehicleYear, e.Make, e.Model })
                    .HasName("IX_Vehicle_Make_Model");

                entity.HasIndex(e => new { e.VehicleYear, e.Make, e.Model, e.DateCreated, e.AmbassadorClass })
                    .HasName("ix_Vehicle_AmbassadorClass");

                entity.HasIndex(e => new { e.VehicleYear, e.Make, e.Model, e.DateCreated, e.DiamondClass })
                    .HasName("ix_Vehicle_DiamondClass");

                entity.HasIndex(e => new { e.VehicleYear, e.Make, e.Model, e.DateCreated, e.PolicyClass })
                    .HasName("ix_Vehicle_PolicyClass");

                entity.Property(e => e.VehicleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AmbassadorClass)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BodySubType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BodyType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CurbWeight)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefEngineAspriation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DefEngineBlock)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DefEngineCylinders)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DefEngineSize)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DefTransSpeed)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DefTransType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiamondClass)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Doors)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DriveType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EngineSizeOum)
                    .HasColumnName("EngineSizeOUM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FuelType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GrossVehicleWeightRating)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gvwrange)
                    .HasColumnName("GVWRange")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Length)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LengthNoBumpers)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Make)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaxPayload)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Msrp)
                    .HasColumnName("MSRP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Plant)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyClass)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RestraintType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Style)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tmptake1Gallon)
                    .HasColumnName("TMPTake1Gallon")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TmpwheelDiamiter)
                    .HasColumnName("TMPWheelDiamiter")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tonnage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Trim)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.VinPattern)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.WheelBase)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Width)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WidthNoMirros)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.Property(e => e.ZipCodeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Postal)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
