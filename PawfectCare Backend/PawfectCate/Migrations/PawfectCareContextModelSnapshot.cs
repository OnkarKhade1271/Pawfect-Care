﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PawfectCate.Models;

#nullable disable

namespace PawfectCate.Migrations
{
    [DbContext(typeof(PawfectCareContext))]
    partial class PawfectCareContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PawfectCate.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("adminId");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("role");

                    b.HasKey("AdminId")
                        .HasName("PK__Admins__AD0500A6AFD735CC");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("PawfectCate.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("appointmentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<DateOnly>("AppointmentDate")
                        .HasColumnType("date")
                        .HasColumnName("appointment_date");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customerId");

                    b.Property<int>("PetId")
                        .HasColumnType("int")
                        .HasColumnName("petId");

                    b.HasKey("AppointmentId")
                        .HasName("PK__tmp_ms_x__D06765FE230842D9");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PetId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("PawfectCate.Models.AppointmentService", b =>
                {
                    b.Property<int>("AppointmentId")
                        .HasColumnType("int")
                        .HasColumnName("appointmentId");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int")
                        .HasColumnName("serviceId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("ServiceId");

                    b.ToTable("AppointmentServices");
                });

            modelBuilder.Entity("PawfectCate.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("billId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int")
                        .HasColumnName("appointmentId");

                    b.Property<decimal>("BillAmount")
                        .HasColumnType("decimal(18, 0)")
                        .HasColumnName("billAmount");

                    b.HasKey("BillId")
                        .HasName("PK__Bill__6D903F03F4F462BA");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Bill", (string)null);
                });

            modelBuilder.Entity("PawfectCate.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("customerId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("role");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId")
                        .HasName("PK__Customer__703FF80E641F2B33");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("PawfectCate.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("feedbackId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customerId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("description");

                    b.HasKey("FeedbackId")
                        .HasName("PK__Feedback__2613FD24E56FCA71");

                    b.HasIndex("CustomerId");

                    b.ToTable("Feedback", (string)null);
                });

            modelBuilder.Entity("PawfectCate.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("paymentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<int>("BillId")
                        .HasColumnType("int")
                        .HasColumnName("billId");

                    b.Property<long>("Cardno")
                        .HasColumnType("bigint")
                        .HasColumnName("cardno");

                    b.Property<int>("Cvvno")
                        .HasColumnType("int")
                        .HasColumnName("cvvno");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("completed")
                        .HasColumnName("status");

                    b.HasKey("PaymentId")
                        .HasName("PK__Payments__A0D9EFC60A229E82");

                    b.HasIndex("BillId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("PawfectCate.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("petId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PetId"));

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("breed");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customerId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("PetId")
                        .HasName("PK__tmp_ms_x__DDF85079F0C061E0");

                    b.HasIndex("CustomerId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PawfectCate.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("serviceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("description ");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 0)")
                        .HasColumnName("price");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("ServiceId")
                        .HasName("PK__tmp_ms_x__455070DF5B3C7223");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("PawfectCate.Models.Appointment", b =>
                {
                    b.HasOne("PawfectCate.Models.Customer", "Customer")
                        .WithMany("Appointments")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_Table_ToTable");

                    b.HasOne("PawfectCate.Models.Pet", "Pet")
                        .WithMany("Appointments")
                        .HasForeignKey("PetId")
                        .IsRequired()
                        .HasConstraintName("FK_Table_ToTable_1");

                    b.Navigation("Customer");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("PawfectCate.Models.AppointmentService", b =>
                {
                    b.HasOne("PawfectCate.Models.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .IsRequired()
                        .HasConstraintName("FK_Table_ToTable7");

                    b.HasOne("PawfectCate.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .IsRequired()
                        .HasConstraintName("FK_Table_ToTable8");

                    b.Navigation("Appointment");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("PawfectCate.Models.Bill", b =>
                {
                    b.HasOne("PawfectCate.Models.Appointment", "Appointment")
                        .WithMany("Bills")
                        .HasForeignKey("AppointmentId")
                        .IsRequired()
                        .HasConstraintName("FK_Bill_ToTable");

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("PawfectCate.Models.Feedback", b =>
                {
                    b.HasOne("PawfectCate.Models.Customer", "Customer")
                        .WithMany("Feedbacks")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_ToTable");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PawfectCate.Models.Payment", b =>
                {
                    b.HasOne("PawfectCate.Models.Bill", "Bill")
                        .WithMany("Payments")
                        .HasForeignKey("BillId")
                        .IsRequired()
                        .HasConstraintName("FK_Payments_ToTable");

                    b.Navigation("Bill");
                });

            modelBuilder.Entity("PawfectCate.Models.Pet", b =>
                {
                    b.HasOne("PawfectCate.Models.Customer", "Customer")
                        .WithMany("Pets")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_Pets_ToTable");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PawfectCate.Models.Appointment", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("PawfectCate.Models.Bill", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("PawfectCate.Models.Customer", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Feedbacks");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("PawfectCate.Models.Pet", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
