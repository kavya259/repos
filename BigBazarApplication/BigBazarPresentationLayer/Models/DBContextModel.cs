using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigBazarPresentationLayer.Models
    {
        public partial class DBContextModel : DbContext
            {
            public DBContextModel()
                {
                }

            public DBContextModel(DbContextOptions<DBContextModel> options)
                : base(options)
                {
                }

            public virtual DbSet<CategoryModel> Categories
                {
                get; set;
                }
            public virtual DbSet<CustomerModel> Customers
                {
                get; set;
                }
            public virtual DbSet<ProductModel> Products
                {
                get; set;
                }
            public virtual DbSet<PurchaseModel> Purchases
                {
                get; set;
                }
            public virtual DbSet<ReceiptModel> Receipts
                {
                get; set;
                }
            public virtual DbSet<UserModel> Users
                {
                get; set;
                }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                if(!optionsBuilder.IsConfigured)
                    {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                    optionsBuilder.UseSqlServer("Data Source=DESKTOP-TEJJIDI;Initial Catalog=BigBazarDataBase;Integrated Security=True;");
                    }
                }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
                {
                modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

                modelBuilder.Entity<CategoryModel>(entity =>
                {
                    entity.ToTable("Category");

                    entity.Property(e => e.CategoryName)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<CustomerModel>(entity =>
                {
                    entity.ToTable("Customer");

                    entity.Property(e => e.CustomerName)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.Email)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.PhoneNumber)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<ProductModel>(entity =>
                {
                    entity.ToTable("Product");

                    entity.Property(e => e.ProductName)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.HasOne(d => d.Category)
                        .WithMany(p => p.Products)
                        .HasForeignKey(d => d.CategoryId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Product__Categor__29572725");
                });

                modelBuilder.Entity<PurchaseModel>(entity =>
                {
                    entity.ToTable("Purchase");

                    entity.Property(e => e.DateOfPurchase).HasColumnType("date");

                    entity.HasOne(d => d.Customer)
                        .WithMany(p => p.Purchases)
                        .HasForeignKey(d => d.CustomerId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Purchase__Custom__2D27B809");

                    entity.HasOne(d => d.Product)
                        .WithMany(p => p.Purchases)
                        .HasForeignKey(d => d.ProductId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Purchase__Produc__2C3393D0");
                });

                modelBuilder.Entity<ReceiptModel>(entity =>
                {
                    entity.ToTable("Receipt");

                    entity.Property(e => e.ReceiptDate).HasColumnType("date");

                    entity.HasOne(d => d.Customer)
                        .WithMany(p => p.Receipts)
                        .HasForeignKey(d => d.CustomerId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Receipt__Custome__300424B4");
                });

                modelBuilder.Entity<UserModel>(entity =>
                {
                    entity.Property(e => e.UserName)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.UserPassword)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.UserRole)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);
                });

                OnModelCreatingPartial(modelBuilder);
                }

            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
            }

        }
    
