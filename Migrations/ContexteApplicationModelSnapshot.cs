﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetJardin;

#nullable disable

namespace ProjetJardin.Migrations
{
    [DbContext(typeof(ContexteApplication))]
    partial class ContexteApplicationModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlimentJardin", b =>
                {
                    b.Property<int>("AlimentID")
                        .HasColumnType("int");

                    b.Property<int>("JardinsId")
                        .HasColumnType("int");

                    b.HasKey("AlimentID", "JardinsId");

                    b.HasIndex("JardinsId");

                    b.ToTable("AlimentJardin");
                });

            modelBuilder.Entity("ProjetJardin.Models.Aliment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Aliment");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Aliment");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ProjetJardin.Models.Jardin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Emplacement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Surface")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Jardins");
                });

            modelBuilder.Entity("ProjetJardin.Models.Fruit", b =>
                {
                    b.HasBaseType("ProjetJardin.Models.Aliment");

                    b.Property<string>("Sucre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Fruit");
                });

            modelBuilder.Entity("ProjetJardin.Models.Legume", b =>
                {
                    b.HasBaseType("ProjetJardin.Models.Aliment");

                    b.Property<string>("Vitamine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Legume");
                });

            modelBuilder.Entity("AlimentJardin", b =>
                {
                    b.HasOne("ProjetJardin.Models.Aliment", null)
                        .WithMany()
                        .HasForeignKey("AlimentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetJardin.Models.Jardin", null)
                        .WithMany()
                        .HasForeignKey("JardinsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
