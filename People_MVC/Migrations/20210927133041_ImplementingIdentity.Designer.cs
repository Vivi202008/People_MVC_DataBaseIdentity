// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using People_MVC.Data;

namespace People_MVC.Migrations
{
    [DbContext(typeof(PeopleDbContext))]
    [Migration("20210927133041_ImplementingIdentity")]
    partial class ImplementingIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("People_MVC.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CountryId = 5,
                            Name = "Stockholm"
                        },
                        new
                        {
                            CityId = 2,
                            CountryId = 5,
                            Name = "Göteborg"
                        },
                        new
                        {
                            CityId = 3,
                            CountryId = 1,
                            Name = "Berlin"
                        },
                        new
                        {
                            CityId = 4,
                            CountryId = 2,
                            Name = "Beijing"
                        },
                        new
                        {
                            CityId = 5,
                            CountryId = 2,
                            Name = "Guangzhou"
                        },
                        new
                        {
                            CityId = 6,
                            CountryId = 3,
                            Name = "Houston"
                        },
                        new
                        {
                            CityId = 7,
                            CountryId = 4,
                            Name = "Oslo"
                        });
                });

            modelBuilder.Entity("People_MVC.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "Other"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "China"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "USA"
                        },
                        new
                        {
                            CountryId = 4,
                            Name = "Norway"
                        },
                        new
                        {
                            CountryId = 5,
                            Name = "Sweden"
                        });
                });

            modelBuilder.Entity("People_MVC.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            LanguageId = 1,
                            Name = "Other"
                        },
                        new
                        {
                            LanguageId = 2,
                            Name = "German"
                        },
                        new
                        {
                            LanguageId = 3,
                            Name = "Italian"
                        },
                        new
                        {
                            LanguageId = 4,
                            Name = "English"
                        },
                        new
                        {
                            LanguageId = 5,
                            Name = "Spanish"
                        },
                        new
                        {
                            LanguageId = 6,
                            Name = "Chinese"
                        },
                        new
                        {
                            LanguageId = 7,
                            Name = "Swedish"
                        });
                });

            modelBuilder.Entity("People_MVC.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeleNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.HasIndex("CityId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            CityId = 1,
                            Name = "King",
                            TeleNumber = "031111111111"
                        },
                        new
                        {
                            PersonId = 2,
                            CityId = 1,
                            Name = "Olle",
                            TeleNumber = "071111111111"
                        },
                        new
                        {
                            PersonId = 3,
                            CityId = 3,
                            Name = "Jenny",
                            TeleNumber = "07333333333"
                        },
                        new
                        {
                            PersonId = 4,
                            CityId = 5,
                            Name = "Anna",
                            TeleNumber = "071123123123"
                        },
                        new
                        {
                            PersonId = 5,
                            CityId = 2,
                            Name = "Sunny",
                            TeleNumber = "03155555555"
                        },
                        new
                        {
                            PersonId = 6,
                            CityId = 4,
                            Name = "Molly",
                            TeleNumber = "07166666666"
                        },
                        new
                        {
                            PersonId = 7,
                            CityId = 5,
                            Name = "Jonnasson",
                            TeleNumber = "0737777777"
                        },
                        new
                        {
                            PersonId = 8,
                            CityId = 5,
                            Name = "Hugo",
                            TeleNumber = "0788888888"
                        });
                });

            modelBuilder.Entity("People_MVC.Models.PersonLanguage", b =>
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
                            PersonId = 2,
                            LanguageId = 6
                        },
                        new
                        {
                            PersonId = 3,
                            LanguageId = 7
                        },
                        new
                        {
                            PersonId = 4,
                            LanguageId = 3
                        },
                        new
                        {
                            PersonId = 4,
                            LanguageId = 5
                        },
                        new
                        {
                            PersonId = 4,
                            LanguageId = 7
                        },
                        new
                        {
                            PersonId = 5,
                            LanguageId = 4
                        },
                        new
                        {
                            PersonId = 6,
                            LanguageId = 2
                        },
                        new
                        {
                            PersonId = 7,
                            LanguageId = 5
                        },
                        new
                        {
                            PersonId = 7,
                            LanguageId = 7
                        },
                        new
                        {
                            PersonId = 8,
                            LanguageId = 7
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("People_MVC.Models.City", b =>
                {
                    b.HasOne("People_MVC.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("People_MVC.Models.Person", b =>
                {
                    b.HasOne("People_MVC.Models.City", "City")
                        .WithMany("Persons")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("People_MVC.Models.PersonLanguage", b =>
                {
                    b.HasOne("People_MVC.Models.Language", "Language")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("People_MVC.Models.Person", "Person")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
