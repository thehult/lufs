﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Database;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(LufsDbContext))]
    [Migration("20220528154908_CreateMember")]
    partial class CreateMember
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("api.Database.Entities.Member", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("City")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("EmailAdress")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("JoinedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastName")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("PersonalNumber")
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("PostAdress")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Guid>("Token")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(7)
                        .HasColumnType("varchar(7)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalNumber")
                        .IsUnique();

                    b.HasIndex("Token")
                        .IsUnique();

                    b.ToTable("Members");
                });

            modelBuilder.Entity("api.Database.Entities.MemberRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("MemberId")
                        .HasColumnType("bigint");

                    b.Property<int>("PDGA")
                        .HasColumnType("int");

                    b.Property<int>("RegistrationType")
                        .HasColumnType("int");

                    b.Property<int>("SDGF")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("Year", "MemberId")
                        .IsUnique();

                    b.ToTable("MemberRegistrations");
                });

            modelBuilder.Entity("api.Database.Entities.News", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Featured")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("PublishedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("api.Database.Entities.MemberRegistration", b =>
                {
                    b.HasOne("api.Database.Entities.Member", "Member")
                        .WithMany("MemberRegistrations")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("api.Database.Entities.Member", b =>
                {
                    b.Navigation("MemberRegistrations");
                });
#pragma warning restore 612, 618
        }
    }
}
