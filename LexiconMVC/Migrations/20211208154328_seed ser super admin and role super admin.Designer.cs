// <auto-generated />
using System;
using LexiconMVCData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LexiconMVCData.Migrations
{
    [DbContext(typeof(LexiconMVCDbContext))]
    [Migration("20211208154328_seed ser super admin and role super admin")]
    partial class seedsersuperadminandrolesuperadmin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LexiconMVCData.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "9c612ee6-fbef-4ea4-9d0c-8c3532a8430c",
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "32c425ce-113e-4afc-8817-8cf547b36d42",
                            Email = "superadmin@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Super",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@MAIL.COM",
                            NormalizedUserName = "SUPERADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEOgsjSvrGcalA87Uk3YS+qIHLXkRdYdcs/zwCG0ijFtlfVv0s3toLyJtBQb4ikL+rw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4e19cca9-e416-4344-b57b-b730c309e29d",
                            TwoFactorEnabled = false,
                            UserName = "SuperAdmin"
                        });
                });

            modelBuilder.Entity("LexiconMVCData.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Göteborg"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Malmö"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            Name = "Stockholm"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            Name = "Oslo"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 2,
                            Name = "Bergen"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 2,
                            Name = "Trondheim"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 3,
                            Name = "Köpenhamn"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 3,
                            Name = "Ålborg"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 3,
                            Name = "Helsingör"
                        });
                });

            modelBuilder.Entity("LexiconMVCData.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sverige"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Norge"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Danmark"
                        });
                });

            modelBuilder.Entity("LexiconMVCData.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Svenska"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Norska"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Danska"
                        });
                });

            modelBuilder.Entity("LexiconMVCData.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Adam Adamsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            Name = "Bertil Bertilsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 3,
                            Name = "Carl Carlsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 1,
                            Name = "Dan Danielsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 2,
                            Name = "Erik Eriksson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            Name = "Frans Fransson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 1,
                            Name = "Gustav Gustavsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 2,
                            Name = "Henrik Henriksson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 3,
                            Name = "Ivar Ivarsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 1,
                            Name = "Jan Jansson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 2,
                            Name = "Karl Karlsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 12,
                            CityId = 3,
                            Name = "Lars Larsson",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 13,
                            CityId = 4,
                            Name = "Ole Bramserud",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 14,
                            CityId = 5,
                            Name = "Petter Northug",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 15,
                            CityId = 6,
                            Name = "Theres Johaug",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 16,
                            CityId = 4,
                            Name = "Gunn-Rita Dahle Flesjå",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 17,
                            CityId = 5,
                            Name = "Fleksnes",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 18,
                            CityId = 6,
                            Name = "Max manus",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 19,
                            CityId = 7,
                            Name = "Nikolaj Coster-Waldau",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 20,
                            CityId = 8,
                            Name = "Iben Hjejle",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 21,
                            CityId = 9,
                            Name = "Mads Mikkelsen",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 22,
                            CityId = 7,
                            Name = "Kristian Tyrann",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 23,
                            CityId = 8,
                            Name = "Kim Larsen",
                            PhoneNumber = "031-123456"
                        },
                        new
                        {
                            Id = 24,
                            CityId = 9,
                            Name = "Tycho Brahe",
                            PhoneNumber = "031-123456"
                        });
                });

            modelBuilder.Entity("LexiconMVCData.Models.PersonLanguage", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("PersonLanguages");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 1,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 2,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 3,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 3,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 4,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 5,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 6,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 7,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 7,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 8,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 9,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 10,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 10,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 11,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 12,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 13,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 14,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 14,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 15,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 16,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 17,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 17,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 18,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 19,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 20,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 21,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 21,
                            LanguageId = 1
                        },
                        new
                        {
                            PersonId = 22,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 23,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 23,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 24,
                            LanguageId = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "9d9ea164-8644-4eb4-b635-42a0506da0c6",
                            ConcurrencyStamp = "878709a5-c031-4dbc-92cb-39b6a26e0350",
                            Name = "Super Admin",
                            NormalizedName = "SUPER ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "9c612ee6-fbef-4ea4-9d0c-8c3532a8430c",
                            RoleId = "9d9ea164-8644-4eb4-b635-42a0506da0c6"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LexiconMVCData.Models.City", b =>
                {
                    b.HasOne("LexiconMVCData.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LexiconMVCData.Models.Person", b =>
                {
                    b.HasOne("LexiconMVCData.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LexiconMVCData.Models.PersonLanguage", b =>
                {
                    b.HasOne("LexiconMVCData.Models.Language", "Language")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LexiconMVCData.Models.Person", "Person")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LexiconMVCData.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LexiconMVCData.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LexiconMVCData.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LexiconMVCData.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
