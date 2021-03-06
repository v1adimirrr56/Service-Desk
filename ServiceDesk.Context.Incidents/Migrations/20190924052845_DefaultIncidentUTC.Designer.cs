﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceDesk.Context.Incidents;

namespace ServiceDesk.Context.Incidents.Migrations
{
    [DbContext(typeof(IncidentsContext))]
    [Migration("20190924052845_DefaultIncidentUTC")]
    partial class DefaultIncidentUTC
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "New York"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Los Angeles"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Chicago"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Houston"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Phoenix"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Philadelphia"
                        },
                        new
                        {
                            Id = 7L,
                            Name = "Jacksonville"
                        },
                        new
                        {
                            Id = 8L,
                            Name = "Columbus"
                        },
                        new
                        {
                            Id = 9L,
                            Name = "Seattle"
                        });
                });

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.Impact", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Impact");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Single"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Group"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Mass"
                        });
                });

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.Incident", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CityId");

                    b.Property<string>("ContactEmail")
                        .IsRequired();

                    b.Property<string>("ContactPhone");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("CreatorName");

                    b.Property<long>("ImpactId");

                    b.Property<bool>("IsComposite");

                    b.Property<long>("ManagerId");

                    b.Property<DateTime>("PassVendorDate");

                    b.Property<long>("PhaseId");

                    b.Property<DateTime>("PlanDateResolve");

                    b.Property<long>("PriorityId");

                    b.Property<double>("Rate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(1.0);

                    b.Property<int>("ShareType");

                    b.Property<long>("StateId");

                    b.Property<long>("StatusId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<bool>("UseNotification");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("ImpactId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("PhaseId");

                    b.HasIndex("PriorityId");

                    b.HasIndex("StateId");

                    b.HasIndex("StatusId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CityId = 1L,
                            ContactEmail = "ching.hso-lin89@example.com",
                            ContactPhone = "+1(137)-691-2995",
                            CreateDate = new DateTime(2019, 9, 24, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(426),
                            CreatorName = "Ching Hso-lin",
                            ImpactId = 1L,
                            IsComposite = true,
                            ManagerId = 1L,
                            PassVendorDate = new DateTime(2019, 10, 26, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(2171),
                            PhaseId = 1L,
                            PlanDateResolve = new DateTime(2019, 10, 4, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(4853),
                            PriorityId = 1L,
                            Rate = 5.0,
                            ShareType = 0,
                            StateId = 1L,
                            StatusId = 1L,
                            Title = "The Evitable Conflict: The Eastern Region",
                            UseNotification = true
                        },
                        new
                        {
                            Id = 2L,
                            CityId = 2L,
                            ContactEmail = "ngoma42@example.com",
                            ContactPhone = "+1(137)-691-2995",
                            CreateDate = new DateTime(2019, 9, 24, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7343),
                            CreatorName = "Ngoma",
                            ImpactId = 2L,
                            IsComposite = false,
                            ManagerId = 2L,
                            PassVendorDate = new DateTime(2019, 10, 17, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7353),
                            PhaseId = 2L,
                            PlanDateResolve = new DateTime(2019, 10, 10, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7369),
                            PriorityId = 2L,
                            Rate = 7.0,
                            ShareType = 1,
                            StateId = 2L,
                            StatusId = 2L,
                            Title = "The Evitable Conflict: The Tropic Region",
                            UseNotification = false
                        },
                        new
                        {
                            Id = 3L,
                            CityId = 3L,
                            ContactEmail = "szegeczowska90@example.com",
                            ContactPhone = "+1(137)-691-2995",
                            CreateDate = new DateTime(2019, 9, 24, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7390),
                            CreatorName = "Szegeczowska",
                            ImpactId = 3L,
                            IsComposite = false,
                            ManagerId = 3L,
                            PassVendorDate = new DateTime(2019, 11, 23, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7390),
                            PhaseId = 3L,
                            PlanDateResolve = new DateTime(2019, 9, 26, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7391),
                            PriorityId = 3L,
                            Rate = 2.0,
                            ShareType = 0,
                            StateId = 3L,
                            StatusId = 3L,
                            Title = "The Evitable Conflict: The European Region",
                            UseNotification = true
                        },
                        new
                        {
                            Id = 4L,
                            CityId = 1L,
                            ContactEmail = "hiram-mackenzie9@example.com",
                            ContactPhone = "+1(137)-691-2995",
                            CreateDate = new DateTime(2019, 9, 24, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7393),
                            CreatorName = "Hiram Mackenzie",
                            ImpactId = 1L,
                            IsComposite = true,
                            ManagerId = 1L,
                            PassVendorDate = new DateTime(2019, 9, 26, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7396),
                            PhaseId = 1L,
                            PlanDateResolve = new DateTime(2019, 10, 2, 5, 28, 44, 767, DateTimeKind.Utc).AddTicks(7398),
                            PriorityId = 1L,
                            Rate = 5.0,
                            ShareType = 0,
                            StateId = 1L,
                            StatusId = 1L,
                            Title = "The Evitable Conflict: The Northern Region",
                            UseNotification = true
                        });
                });

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.Job", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("IncidentId");

                    b.Property<string>("JobTitle");

                    b.HasKey("Id");

                    b.HasIndex("IncidentId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.Manager", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Manager");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "linda.armstrong76@example.com",
                            FirstName = "Linda",
                            LastName = "Armstrong"
                        },
                        new
                        {
                            Id = 2L,
                            Email = "dylan.cole27@example.com",
                            FirstName = "Dylan",
                            LastName = "Cole"
                        },
                        new
                        {
                            Id = 3L,
                            Email = "travis.murphy20@example.com",
                            FirstName = "Travis",
                            LastName = "Murphy"
                        },
                        new
                        {
                            Id = 4L,
                            Email = "barry.frazier29@example.com",
                            FirstName = "Barry",
                            LastName = "Frazier"
                        });
                });

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.Phase", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Phase");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Registration"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "In working"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Resolving"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Closed"
                        });
                });

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.Priority", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PriorityType");

                    b.HasKey("Id");

                    b.ToTable("Priority");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            PriorityType = "None"
                        },
                        new
                        {
                            Id = 2L,
                            PriorityType = "Normal"
                        },
                        new
                        {
                            Id = 3L,
                            PriorityType = "Major"
                        },
                        new
                        {
                            Id = 4L,
                            PriorityType = "Critical"
                        });
                });

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.State", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("State");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "New York"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "California"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Illinois"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Texas"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Arizona"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Pennsylvania"
                        },
                        new
                        {
                            Id = 7L,
                            Name = "Florida"
                        },
                        new
                        {
                            Id = 8L,
                            Name = "Ohio"
                        },
                        new
                        {
                            Id = 9L,
                            Name = "Washington"
                        });
                });

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.StateCityRelation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CityId");

                    b.Property<long>("StateId");

                    b.HasKey("Id");

                    b.ToTable("StateCityRelations");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CityId = 1L,
                            StateId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CityId = 2L,
                            StateId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            CityId = 3L,
                            StateId = 3L
                        },
                        new
                        {
                            Id = 4L,
                            CityId = 4L,
                            StateId = 4L
                        },
                        new
                        {
                            Id = 5L,
                            CityId = 5L,
                            StateId = 5L
                        },
                        new
                        {
                            Id = 6L,
                            CityId = 6L,
                            StateId = 6L
                        },
                        new
                        {
                            Id = 7L,
                            CityId = 7L,
                            StateId = 7L
                        },
                        new
                        {
                            Id = 8L,
                            CityId = 8L,
                            StateId = 8L
                        },
                        new
                        {
                            Id = 9L,
                            CityId = 9L,
                            StateId = 9L
                        });
                });

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.Status", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Open"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "In work"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Pass vendor"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Hold"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Resolve"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Closed"
                        });
                });

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.Incident", b =>
                {
                    b.HasOne("ServiceDesk.Incidents.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceDesk.Incidents.Entities.Impact", "Impact")
                        .WithMany()
                        .HasForeignKey("ImpactId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceDesk.Incidents.Entities.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceDesk.Incidents.Entities.Phase", "Phase")
                        .WithMany()
                        .HasForeignKey("PhaseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceDesk.Incidents.Entities.Priority", "Priority")
                        .WithMany()
                        .HasForeignKey("PriorityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceDesk.Incidents.Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ServiceDesk.Incidents.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ServiceDesk.Incidents.Entities.Job", b =>
                {
                    b.HasOne("ServiceDesk.Incidents.Entities.Incident", "Incident")
                        .WithMany("Jobs")
                        .HasForeignKey("IncidentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
