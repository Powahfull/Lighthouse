﻿// <auto-generated />
using System;
using Lighthouse.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lighthouse.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("Lighthouse.Models.Announcements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnnouncementAttachmentContentType")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("AnnouncementAttachmentData")
                        .HasColumnType("BLOB");

                    b.Property<string>("AnnouncementAttachmentFileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AnnouncementText")
                        .HasColumnType("TEXT");

                    b.Property<string>("AttachmentContentType")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("AttachmentData")
                        .HasColumnType("BLOB");

                    b.Property<string>("AttachmentFileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<bool>("NotifyByEmail")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("NotifyByWebsite")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("Lighthouse.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClubAdmins")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("ClubId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Lighthouse.Models.Credentials", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsStudent")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsTeacher")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserName");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("Lighthouse.Models.Events", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IncludeEmail")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IncludeWebsite")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFree")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Lighthouse.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsStudent")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsTeacher")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SchoolEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Lighthouse.Models.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserRoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Lighthouse.Models.UserRole", b =>
                {
                    b.HasOne("Lighthouse.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Lighthouse.Models.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
