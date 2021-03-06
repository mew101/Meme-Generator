﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using meme_generator;

namespace memegenerator.Migrations
{
    [DbContext(typeof(MemeContext))]
    partial class MemeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("meme_generator.Models.Meme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BottomText");

                    b.Property<string>("ImagePath");

                    b.Property<string>("TopText");

                    b.HasKey("Id");

                    b.ToTable("Memes");

                    b.HasData(
                        new { Id = 1, BottomText = "Is anybody in there?", ImagePath = "/Images/Grandma.jpg", TopText = "Hellooo.." },
                        new { Id = 2, BottomText = "for the money!", ImagePath = "/Images/money.jpg", TopText = "I'm just in this" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
