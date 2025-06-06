﻿// <auto-generated />
using System;
using AdithyaBank.BackEnd.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdithyaBank.BackEnd.Migrations
{
    [DbContext(typeof(AdithyaBankDatabaseContext))]
    partial class AdithyaBankDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AdithyaBank.BackEnd.Entities.ApplicationDocumentUploads", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("ApplicationId")
                        .HasColumnType("bigint");

                    b.Property<string>("DocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DocumentTypeId")
                        .HasColumnType("bigint");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte?>("Rowstate")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("DocumentTypeId");

                    b.ToTable("ApplicationDocumentUploads");
                });

            modelBuilder.Entity("AdithyaBank.BackEnd.Entities.ApplicationRegister", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ApplicationAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Application_Address");

                    b.Property<decimal?>("ApplicationApprovedAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Application_ApprovedAmount");

                    b.Property<long?>("ApplicationApprovedBy")
                        .HasColumnType("bigint")
                        .HasColumnName("Application_ApprovedBy");

                    b.Property<DateTime?>("ApplicationApprovedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("Application_ApprovedOn");

                    b.Property<long>("ApplicationCountryId")
                        .HasColumnType("bigint")
                        .HasColumnName("Application_CountryId");

                    b.Property<long>("ApplicationDistrictId")
                        .HasColumnType("bigint")
                        .HasColumnName("Application_DistrictId");

                    b.Property<string>("ApplicationHobbies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Application_Hobbies");

                    b.Property<bool>("ApplicationIsAcceptedTermsandConditions")
                        .HasColumnType("bit")
                        .HasColumnName("Application_IsAcceptedTermsandConditions");

                    b.Property<bool?>("ApplicationIsApproved")
                        .HasColumnType("bit")
                        .HasColumnName("Application_IsApproved");

                    b.Property<string>("ApplicationMartialStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Application_MartialStatus");

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Application_name");

                    b.Property<DateTime>("ApplicationRegisterdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Application_Registerdate");

                    b.Property<decimal>("ApplicationRequestedAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Application_RequestedAmount");

                    b.Property<long>("ApplicationStateId")
                        .HasColumnType("bigint")
                        .HasColumnName("Application_StateId");

                    b.Property<bool>("ApplicationStatus")
                        .HasColumnType("bit")
                        .HasColumnName("Application_Status");

                    b.Property<DateTime>("Applicationdob")
                        .HasColumnType("datetime2")
                        .HasColumnName("Application_dob");

                    b.Property<string>("Applicationemail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Application_email");

                    b.Property<string>("Applicationfathername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Application_fathername");

                    b.Property<string>("Applicationgender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("Application_gender");

                    b.Property<string>("Applicationmobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Application_mobile");

                    b.Property<string>("Applicationmothername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Application_mothername");

                    b.Property<string>("Applicationqualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Application_qualification");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte?>("Rowstate")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("ApplicationRegister", (string)null);
                });

            modelBuilder.Entity("AdithyaBank.BackEnd.Entities.DocumentTypes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("Rowstate")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("AdithyaBank.BackEnd.Entities.ApplicationDocumentUploads", b =>
                {
                    b.HasOne("AdithyaBank.BackEnd.Entities.ApplicationRegister", "ApplicationRegister")
                        .WithMany("ApplicationDocumentUploads")
                        .HasForeignKey("ApplicationId")
                        .IsRequired()
                        .HasConstraintName("FK_ApplicationDocumentUploads_ApplicationRegister");

                    b.HasOne("AdithyaBank.BackEnd.Entities.DocumentTypes", "DocumentTypes")
                        .WithMany("ApplicationDocumentUploads")
                        .HasForeignKey("DocumentTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_ApplicationDocumentUploads_DocumentTypes");

                    b.Navigation("ApplicationRegister");

                    b.Navigation("DocumentTypes");
                });

            modelBuilder.Entity("AdithyaBank.BackEnd.Entities.ApplicationRegister", b =>
                {
                    b.Navigation("ApplicationDocumentUploads");
                });

            modelBuilder.Entity("AdithyaBank.BackEnd.Entities.DocumentTypes", b =>
                {
                    b.Navigation("ApplicationDocumentUploads");
                });
#pragma warning restore 612, 618
        }
    }
}
