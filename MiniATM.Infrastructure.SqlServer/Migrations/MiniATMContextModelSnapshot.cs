﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniATM.Infrastructure.SqlServer.Repositories.SqlServer.DataContext;

#nullable disable

namespace MiniATM.Infrastructure.SqlServer.Migrations
{
    [DbContext(typeof(MiniATMContext))]
    partial class MiniATMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MiniATM.Infrastructure.SqlServer.Repositories.SqlServer.DataContext.BankAccount", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<double>("MinimumRequiredAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("MiniATM.Infrastructure.SqlServer.Repositories.SqlServer.DataContext.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("BankAccountId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateTimeUTC")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TransactionTypes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("MiniATM.Infrastructure.SqlServer.Repositories.SqlServer.DataContext.Transaction", b =>
                {
                    b.HasOne("MiniATM.Infrastructure.SqlServer.Repositories.SqlServer.DataContext.BankAccount", null)
                        .WithMany("Transactions")
                        .HasForeignKey("BankAccountId");
                });

            modelBuilder.Entity("MiniATM.Infrastructure.SqlServer.Repositories.SqlServer.DataContext.BankAccount", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}