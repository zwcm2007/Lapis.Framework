﻿// <auto-generated />
using System;
using Laison.Lapis.Prepayment.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Prepayment.Migrations
{
    [DbContext(typeof(PrepaymentHttpApiHostMigrationsDbContext))]
    [Migration("20210411072019_third5")]
    partial class third5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Laison.Lapis.Prepayment.Domain.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<double>("Debt")
                        .HasColumnType("double");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("MakeCard")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("No")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Laison.Lapis.Prepayment.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("IdentityNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Remark")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telephone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Laison.Lapis.Prepayment.Domain.Entities.RechargeTradeDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("OperatorId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Recharge_Trade_Detail");
                });

            modelBuilder.Entity("Laison.Lapis.Prepayment.Domain.Entities.RegisterTradeDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("OpenAccountCharge")
                        .HasColumnType("double");

                    b.Property<Guid>("OperatorId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Register_Trade_Detail");
                });

            modelBuilder.Entity("Laison.Lapis.Prepayment.Domain.Entities.Account", b =>
                {
                    b.HasOne("Laison.Lapis.Prepayment.Domain.Entities.Customer", "Customer")
                        .WithOne()
                        .HasForeignKey("Laison.Lapis.Prepayment.Domain.Entities.Account", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Laison.Lapis.Prepayment.Domain.Entities.Customer", b =>
                {
                    b.OwnsOne("Laison.Lapis.Prepayment.Domain.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("CustomerId")
                                .HasColumnType("char(36)");

                            b1.Property<string>("City")
                                .HasColumnType("longtext CHARACTER SET utf8mb4");

                            b1.Property<string>("Province")
                                .HasColumnType("longtext CHARACTER SET utf8mb4");

                            b1.Property<string>("Town")
                                .HasColumnType("longtext CHARACTER SET utf8mb4");

                            b1.Property<string>("Village")
                                .HasColumnType("longtext CHARACTER SET utf8mb4");

                            b1.HasKey("CustomerId");

                            b1.ToTable("Customer");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });

                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
