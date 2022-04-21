﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quote.Models;

namespace Quote.Migrations
{
    [DbContext(typeof(QuoteApplicationContext))]
    [Migration("20220421051918_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24");

            modelBuilder.Entity("Quote.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Citation")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quote")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("ApplicationId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            Author = "Emily Bronte",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quote = "Whatever our souls are made of, his and mine are the same.",
                            Subject = "Love"
                        },
                        new
                        {
                            ApplicationId = 2,
                            Author = "H. G. Wells",
                            Citation = "H. G. Wells (1866-1946)",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quote = "Moral indignation is jealousy with a halo.",
                            Subject = "Life"
                        },
                        new
                        {
                            ApplicationId = 3,
                            Author = "Henry Davis",
                            Citation = "Chessmaster Savielly Grigorievitch Tartakower (1887-1956)",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quote = "Victory goes to the player who makes the next-to-last mistake.",
                            Subject = "Victory"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}