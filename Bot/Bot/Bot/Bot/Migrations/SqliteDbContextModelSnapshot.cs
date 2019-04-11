﻿// <auto-generated />
using Bot.Resources.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bot.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    partial class SqliteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("Bot.Resources.Database.Items", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IName");

                    b.Property<int>("Price");

                    b.HasKey("ItemID");

                    b.ToTable("items");
                });

            modelBuilder.Entity("Bot.Resources.Database.MyUser", b =>
                {
                    b.Property<ulong>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Coins");

                    b.Property<bool>("Loggedin");

                    b.HasKey("UserID");

                    b.ToTable("myUser");
                });

            modelBuilder.Entity("Bot.Resources.Database.UserItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("ItemID");

                    b.Property<ulong>("UserID");

                    b.HasKey("ID");

                    b.ToTable("userItems");
                });
#pragma warning restore 612, 618
        }
    }
}
