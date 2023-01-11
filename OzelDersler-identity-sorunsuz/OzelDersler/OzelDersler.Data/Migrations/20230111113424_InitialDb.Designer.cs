﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OzelDersler.Data.Concrete.EfCore.Contexts;

#nullable disable

namespace OzelDersler.Data.Migrations
{
    [DbContext(typeof(OzelDerslerContext))]
    [Migration("20230111113424_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "student",
                            RoleId = "40c5c420-be46-44c8-821d-437699183ff3"
                        },
                        new
                        {
                            UserId = "teacher",
                            RoleId = "815b03d3-708f-4495-967b-96a4c42061d4"
                        },
                        new
                        {
                            UserId = "teacher1",
                            RoleId = "815b03d3-708f-4495-967b-96a4c42061d4"
                        },
                        new
                        {
                            UserId = "teacher2",
                            RoleId = "815b03d3-708f-4495-967b-96a4c42061d4"
                        },
                        new
                        {
                            UserId = "teacher3",
                            RoleId = "815b03d3-708f-4495-967b-96a4c42061d4"
                        },
                        new
                        {
                            UserId = "teacher4",
                            RoleId = "815b03d3-708f-4495-967b-96a4c42061d4"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OzelDersler.Entity.Concrete.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Branches", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchName = "Matematik",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "mat.png",
                            Url = "matematik"
                        },
                        new
                        {
                            Id = 2,
                            BranchName = "Kimya",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "kimya.png",
                            Url = "kimya"
                        },
                        new
                        {
                            Id = 3,
                            BranchName = "İngilizce",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "ing.png",
                            Url = "ingilizce"
                        },
                        new
                        {
                            Id = 4,
                            BranchName = "Müzik",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "müzik.png",
                            Url = "muzik"
                        },
                        new
                        {
                            Id = 5,
                            BranchName = "Türkçe",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "turkce.png",
                            Url = "turkce"
                        },
                        new
                        {
                            Id = 6,
                            BranchName = "Bilgisayar",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "bilgisayar.png",
                            Url = "bilgisayar"
                        });
                });

            modelBuilder.Entity("OzelDersler.Entity.Concrete.Identity.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "815b03d3-708f-4495-967b-96a4c42061d4",
                            Description = "Teacher Rolü",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = "40c5c420-be46-44c8-821d-437699183ff3",
                            Description = "Student Rolü",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("OzelDersler.Entity.Concrete.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "student",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dab02978-adcf-4845-ab53-9df836348ca2",
                            Email = "harun@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "STUDENT",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f3cf1f03-1cf6-48a1-b9d0-74d921dd7b51",
                            TwoFactorEnabled = false,
                            UserName = "student"
                        },
                        new
                        {
                            Id = "teacher",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ace98a39-5b18-42ce-a72c-00c38cc75a2c",
                            Email = "teacher@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "TEACHER",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bfc972ef-07b5-4995-b886-35a19948f730",
                            TwoFactorEnabled = false,
                            UserName = "teacher"
                        },
                        new
                        {
                            Id = "teacher1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2a0731f1-8e7f-4a5d-adf5-faba12813b5b",
                            Email = "teacher@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "TEACHER1",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fcab1aed-1587-483e-b610-800397ba0a24",
                            TwoFactorEnabled = false,
                            UserName = "teacher1"
                        },
                        new
                        {
                            Id = "teacher2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cb6ebb5f-a5e2-4415-b134-edb1a4cf0f81",
                            Email = "teacher@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "TEACHER2",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e60033e7-fd47-4ba6-a1a7-aa1aca857663",
                            TwoFactorEnabled = false,
                            UserName = "teacher2"
                        },
                        new
                        {
                            Id = "teacher3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "44be262b-c716-4aee-a90c-64e905208abf",
                            Email = "teacher@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "TEACHER3",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "26974f97-9fdd-4b57-905b-6e32f9762432",
                            TwoFactorEnabled = false,
                            UserName = "teacher3"
                        },
                        new
                        {
                            Id = "teacher4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "569cc490-0f84-43f5-be38-ba13c620c07c",
                            Email = "teacher@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "TEACHER4",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fb93e81b-d910-4674-a21b-0fec9efc4073",
                            TwoFactorEnabled = false,
                            UserName = "teacher4"
                        });
                });

            modelBuilder.Entity("OzelDersler.Entity.Concrete.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Job")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Başakşehir",
                            City = "İstanbul",
                            FirstName = "Harun",
                            Gender = "Erkek",
                            ImageUrl = "harun.png",
                            Job = "Developer",
                            LastName = "Özer",
                            UserId = "student"
                        });
                });

            modelBuilder.Entity("OzelDersler.Entity.Concrete.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("About")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<int>("Experience")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Job")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("PricePerHour")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Şuanda Wissen Akademie'de yazılım kursundayım. Matematik alanında ders veriyorum.",
                            Address = "Esenler",
                            Age = 24,
                            City = "İstanbul",
                            Experience = 5,
                            FirstName = "Mert",
                            Gender = "Erkek",
                            ImageUrl = "10.png",
                            IsHome = true,
                            Job = "Developer",
                            LastName = "Muslu",
                            PricePerHour = 350,
                            UserId = "teacher"
                        },
                        new
                        {
                            Id = 2,
                            About = "Müziğe ilgi duyuyorum. Müzikle birlikte yabancı dillerin de öğrenilebileceğine inanıyorum.",
                            Address = "Başakşehir",
                            Age = 24,
                            City = "İstanbul",
                            Experience = 2,
                            FirstName = "Gonca",
                            Gender = "Kadın",
                            ImageUrl = "11.png",
                            IsHome = true,
                            Job = "Almanca Öğretmeni",
                            LastName = "Özer",
                            PricePerHour = 500,
                            UserId = "teacher1"
                        },
                        new
                        {
                            Id = 3,
                            About = "Sınıf öğretmenliği yapıyorum. Öğrencilerimi eğitmeyi ve onlara bir şeyler katmayı seviyorum.",
                            Address = "Göztepe",
                            Age = 30,
                            City = "İstanbul",
                            Experience = 8,
                            FirstName = "Hatice",
                            Gender = "Kadın",
                            ImageUrl = "11.png",
                            IsHome = true,
                            Job = "Sınıf Öğretmeni",
                            LastName = "Durmuş",
                            PricePerHour = 500,
                            UserId = "teacher2"
                        },
                        new
                        {
                            Id = 4,
                            About = "Aktif olarak ingilizce tercümanlığı ile meşgulüm. Senelerdir ingilizce alanınca tezler ve çeviriler hazırlıyorum. Öğrencilerime her seviyede ingilizce eğitimi verebilirim.",
                            Address = "Kartal",
                            Age = 45,
                            City = "İstanbul",
                            Experience = 20,
                            FirstName = "Ahmet",
                            Gender = "Erkek",
                            ImageUrl = "10.png",
                            IsHome = true,
                            Job = "İngilizce Tecrümanı",
                            LastName = "Yılmaz",
                            PricePerHour = 900,
                            UserId = "teacher3"
                        },
                        new
                        {
                            Id = 5,
                            About = "Yurtdışında gördüğüm müzik eğitimiyle birlikte türkiyede aktif olarak öğretmenlik yapmaktayım. Çeşitli organizasyonlarda ve yarışmalarda başarılarım bulunmakta. Ses eğitimi ve müzik bilgisi alanında öğrencilerimi ileri seviyeye taşımak için elimden geleni yapmaktayım.",
                            Address = "Çağlayan",
                            Age = 33,
                            City = "Ankara",
                            Experience = 10,
                            FirstName = "David",
                            Gender = "Erkek",
                            ImageUrl = "10.png",
                            IsHome = true,
                            Job = "Müzik Öğretmeni",
                            LastName = "Dark",
                            PricePerHour = 600,
                            UserId = "teacher4"
                        });
                });

            modelBuilder.Entity("OzelDersler.Entity.Concrete.TeacherBranch", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BranchId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeacherId", "BranchId");

                    b.HasIndex("BranchId");

                    b.ToTable("TeacherBranches", (string)null);

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            BranchId = 1
                        },
                        new
                        {
                            TeacherId = 2,
                            BranchId = 1
                        },
                        new
                        {
                            TeacherId = 3,
                            BranchId = 2
                        },
                        new
                        {
                            TeacherId = 1,
                            BranchId = 3
                        },
                        new
                        {
                            TeacherId = 4,
                            BranchId = 4
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("OzelDersler.Entity.Concrete.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OzelDersler.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OzelDersler.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("OzelDersler.Entity.Concrete.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OzelDersler.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OzelDersler.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OzelDersler.Entity.Concrete.Student", b =>
                {
                    b.HasOne("OzelDersler.Entity.Concrete.Identity.User", "User")
                        .WithOne("Students")
                        .HasForeignKey("OzelDersler.Entity.Concrete.Student", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OzelDersler.Entity.Concrete.Teacher", b =>
                {
                    b.HasOne("OzelDersler.Entity.Concrete.Identity.User", "User")
                        .WithOne("Teachers")
                        .HasForeignKey("OzelDersler.Entity.Concrete.Teacher", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OzelDersler.Entity.Concrete.TeacherBranch", b =>
                {
                    b.HasOne("OzelDersler.Entity.Concrete.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OzelDersler.Entity.Concrete.Teacher", "Teacher")
                        .WithMany("TeacherBranches")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("OzelDersler.Entity.Concrete.Identity.User", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("OzelDersler.Entity.Concrete.Teacher", b =>
                {
                    b.Navigation("TeacherBranches");
                });
#pragma warning restore 612, 618
        }
    }
}