﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SlopCrew.Server.Database;

#nullable disable

namespace SlopCrew.Server.Migrations
{
    [DbContext(typeof(SlopDbContext))]
    partial class SlopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("CrewUser", b =>
                {
                    b.Property<string>("CrewsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("MembersDiscordId")
                        .HasColumnType("TEXT");

                    b.HasKey("CrewsId", "MembersDiscordId");

                    b.HasIndex("MembersDiscordId");

                    b.ToTable("CrewUser");
                });

            modelBuilder.Entity("CrewUser1", b =>
                {
                    b.Property<string>("OwnedCrewsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("OwnersDiscordId")
                        .HasColumnType("TEXT");

                    b.HasKey("OwnedCrewsId", "OwnersDiscordId");

                    b.HasIndex("OwnersDiscordId");

                    b.ToTable("CrewUser1");
                });

            modelBuilder.Entity("SlopCrew.Server.Database.Crew", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("InviteCodes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Tag")
                        .IsUnique();

                    b.ToTable("Crews");
                });

            modelBuilder.Entity("SlopCrew.Server.Database.User", b =>
                {
                    b.Property<string>("DiscordId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiscordAvatar")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiscordRefreshToken")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DiscordToken")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DiscordTokenExpires")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiscordUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GameToken")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCommunityContributor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RepresentingCrewId")
                        .HasColumnType("TEXT");

                    b.HasKey("DiscordId");

                    b.HasIndex("RepresentingCrewId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CrewUser", b =>
                {
                    b.HasOne("SlopCrew.Server.Database.Crew", null)
                        .WithMany()
                        .HasForeignKey("CrewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SlopCrew.Server.Database.User", null)
                        .WithMany()
                        .HasForeignKey("MembersDiscordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CrewUser1", b =>
                {
                    b.HasOne("SlopCrew.Server.Database.Crew", null)
                        .WithMany()
                        .HasForeignKey("OwnedCrewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SlopCrew.Server.Database.User", null)
                        .WithMany()
                        .HasForeignKey("OwnersDiscordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SlopCrew.Server.Database.User", b =>
                {
                    b.HasOne("SlopCrew.Server.Database.Crew", "RepresentingCrew")
                        .WithOne()
                        .HasForeignKey("SlopCrew.Server.Database.User", "RepresentingCrewId");

                    b.Navigation("RepresentingCrew");
                });
#pragma warning restore 612, 618
        }
    }
}
