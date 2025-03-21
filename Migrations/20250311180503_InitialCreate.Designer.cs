﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisitorLog_PDFD.Data;

#nullable disable

namespace VisitorLog_PDFD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250311180503_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VisitorLog_PDFD.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<int>("CountyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NameTypeId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountyId");

                    b.HasIndex("NameTypeId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CountyId = 1,
                            Name = "Ellicott City",
                            NameTypeId = 5
                        },
                        new
                        {
                            CityId = 2,
                            CountyId = 1,
                            Name = "Columbia",
                            NameTypeId = 5
                        });
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.Continent", b =>
                {
                    b.Property<int>("ContinentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContinentId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NameTypeId")
                        .HasColumnType("int");

                    b.HasKey("ContinentId");

                    b.HasIndex("NameTypeId");

                    b.ToTable("Continents");

                    b.HasData(
                        new
                        {
                            ContinentId = 1,
                            Name = "Asia",
                            NameTypeId = 1
                        },
                        new
                        {
                            ContinentId = 2,
                            Name = "North America",
                            NameTypeId = 1
                        });
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<int>("ContinentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NameTypeId")
                        .HasColumnType("int");

                    b.HasKey("CountryId");

                    b.HasIndex("ContinentId");

                    b.HasIndex("NameTypeId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            ContinentId = 2,
                            Name = "USA",
                            NameTypeId = 2
                        },
                        new
                        {
                            CountryId = 2,
                            ContinentId = 2,
                            Name = "Canada",
                            NameTypeId = 2
                        });
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.County", b =>
                {
                    b.Property<int>("CountyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountyId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NameTypeId")
                        .HasColumnType("int");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("CountyId");

                    b.HasIndex("NameTypeId");

                    b.HasIndex("StateId");

                    b.ToTable("Counties");

                    b.HasData(
                        new
                        {
                            CountyId = 1,
                            Name = "Howard",
                            NameTypeId = 4,
                            StateId = 1
                        },
                        new
                        {
                            CountyId = 2,
                            Name = "Boltimore",
                            NameTypeId = 4,
                            StateId = 1
                        });
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.NameType", b =>
                {
                    b.Property<int>("NameTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NameTypeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NameTypeId");

                    b.ToTable("NameTypes");

                    b.HasData(
                        new
                        {
                            NameTypeId = 1,
                            Name = "Continent"
                        },
                        new
                        {
                            NameTypeId = 2,
                            Name = "Country"
                        },
                        new
                        {
                            NameTypeId = 3,
                            Name = "State"
                        },
                        new
                        {
                            NameTypeId = 4,
                            Name = "County"
                        },
                        new
                        {
                            NameTypeId = 5,
                            Name = "City"
                        },
                        new
                        {
                            NameTypeId = 6,
                            Name = "District"
                        },
                        new
                        {
                            NameTypeId = 7,
                            Name = "Province"
                        },
                        new
                        {
                            NameTypeId = 8,
                            Name = "Station"
                        },
                        new
                        {
                            NameTypeId = 9,
                            Name = "Special Administrative Region"
                        },
                        new
                        {
                            NameTypeId = 10,
                            Name = "Separate Political Entity"
                        },
                        new
                        {
                            NameTypeId = 11,
                            Name = "Region"
                        });
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            Email = "tester@test.com",
                            FirstName = "Test",
                            LastName = "Tester",
                            MiddleName = "T"
                        });
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.Report", b =>
                {
                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContinentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("vw_Report", (string)null);
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.SelectedCity", b =>
                {
                    b.Property<int>("SelectedCityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelectedCityId"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("SelectedCountyId")
                        .HasColumnType("int");

                    b.HasKey("SelectedCityId");

                    b.HasIndex("CityId");

                    b.HasIndex("SelectedCountyId");

                    b.ToTable("SelectedCities");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.SelectedContinent", b =>
                {
                    b.Property<int>("SelectedContinentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelectedContinentId"));

                    b.Property<int>("ContinentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("SelectedContinentId");

                    b.HasIndex("ContinentId");

                    b.HasIndex("PersonId");

                    b.ToTable("SelectedContinents");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.SelectedCountry", b =>
                {
                    b.Property<int>("SelectedCountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelectedCountryId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("SelectedContinentId")
                        .HasColumnType("int");

                    b.HasKey("SelectedCountryId");

                    b.HasIndex("CountryId");

                    b.HasIndex("SelectedContinentId");

                    b.ToTable("SelectedCountries");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.SelectedCounty", b =>
                {
                    b.Property<int>("SelectedCountyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelectedCountyId"));

                    b.Property<int>("CountyId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("SelectedStateId")
                        .HasColumnType("int");

                    b.HasKey("SelectedCountyId");

                    b.HasIndex("CountyId");

                    b.HasIndex("SelectedStateId");

                    b.ToTable("SelectedCounties");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.SelectedState", b =>
                {
                    b.Property<int>("SelectedStateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelectedStateId"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("SelectedCountryId")
                        .HasColumnType("int");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("SelectedStateId");

                    b.HasIndex("SelectedCountryId");

                    b.HasIndex("StateId");

                    b.ToTable("SelectedStates");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NameTypeId")
                        .HasColumnType("int");

                    b.HasKey("StateId");

                    b.HasIndex("CountryId");

                    b.HasIndex("NameTypeId");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            StateId = 1,
                            CountryId = 1,
                            Name = "Maryland",
                            NameTypeId = 3
                        },
                        new
                        {
                            StateId = 2,
                            CountryId = 1,
                            Name = "Viginia",
                            NameTypeId = 3
                        });
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.City", b =>
                {
                    b.HasOne("VisitorLog_PDFD.Models.County", "County")
                        .WithMany("Cities")
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisitorLog_PDFD.Models.NameType", "NameType")
                        .WithMany()
                        .HasForeignKey("NameTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("County");

                    b.Navigation("NameType");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.Continent", b =>
                {
                    b.HasOne("VisitorLog_PDFD.Models.NameType", "NameType")
                        .WithMany()
                        .HasForeignKey("NameTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("NameType");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.Country", b =>
                {
                    b.HasOne("VisitorLog_PDFD.Models.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisitorLog_PDFD.Models.NameType", "NameType")
                        .WithMany()
                        .HasForeignKey("NameTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Continent");

                    b.Navigation("NameType");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.County", b =>
                {
                    b.HasOne("VisitorLog_PDFD.Models.NameType", "NameType")
                        .WithMany()
                        .HasForeignKey("NameTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VisitorLog_PDFD.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NameType");

                    b.Navigation("State");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.SelectedCity", b =>
                {
                    b.HasOne("VisitorLog_PDFD.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisitorLog_PDFD.Models.SelectedCounty", "SelectedCounty")
                        .WithMany()
                        .HasForeignKey("SelectedCountyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("SelectedCounty");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.SelectedContinent", b =>
                {
                    b.HasOne("VisitorLog_PDFD.Models.Continent", "Continent")
                        .WithMany()
                        .HasForeignKey("ContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisitorLog_PDFD.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Continent");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.SelectedCountry", b =>
                {
                    b.HasOne("VisitorLog_PDFD.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VisitorLog_PDFD.Models.SelectedContinent", "SelectedContinent")
                        .WithMany()
                        .HasForeignKey("SelectedContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("SelectedContinent");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.SelectedCounty", b =>
                {
                    b.HasOne("VisitorLog_PDFD.Models.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisitorLog_PDFD.Models.SelectedState", "SelectedState")
                        .WithMany()
                        .HasForeignKey("SelectedStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("County");

                    b.Navigation("SelectedState");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.SelectedState", b =>
                {
                    b.HasOne("VisitorLog_PDFD.Models.SelectedCountry", "SelectedCountry")
                        .WithMany()
                        .HasForeignKey("SelectedCountryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VisitorLog_PDFD.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("SelectedCountry");

                    b.Navigation("State");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.State", b =>
                {
                    b.HasOne("VisitorLog_PDFD.Models.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisitorLog_PDFD.Models.NameType", "NameType")
                        .WithMany()
                        .HasForeignKey("NameTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("NameType");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.Continent", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("VisitorLog_PDFD.Models.County", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
