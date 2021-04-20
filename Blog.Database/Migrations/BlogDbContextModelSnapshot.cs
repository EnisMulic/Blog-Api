﻿// <auto-generated />
using System;
using Blog.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.Database.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    partial class BlogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blog.Domain.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique()
                        .HasFilter("[Slug] IS NOT NULL");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "Et aspernatur inventore delectus sit reprehenderit commodi explicabo repudiandae odit. Vitae voluptas impedit est dolore nostrum beatae. Eaque aliquid voluptatem et mollitia numquam labore nobis iure. Quisquam nostrum reprehenderit nihil aut ut magnam. Laborum ut laborum est.",
                            CreatedAt = new DateTime(2020, 4, 21, 10, 50, 0, 961, DateTimeKind.Local).AddTicks(6945),
                            Description = "At eum corrupti odit deleniti sed aut quaerat. Aut aliquid corporis in ut alias ab explicabo nemo optio. Corrupti laborum ratione aspernatur occaecati possimus et porro.",
                            Slug = "temporibus-vel-beatae",
                            Title = "Et enim illum sunt ducimus blanditiis omnis.",
                            UpdatedAt = new DateTime(2021, 4, 20, 14, 43, 23, 980, DateTimeKind.Local).AddTicks(5070)
                        },
                        new
                        {
                            Id = 2,
                            Body = "Sit enim magnam quia. Amet aliquid occaecati eius repellendus eos. Et porro corrupti velit est voluptatibus accusantium et a. Ad temporibus asperiores cumque dolorem ut a iste ut earum.",
                            CreatedAt = new DateTime(2020, 9, 4, 8, 41, 15, 10, DateTimeKind.Local).AddTicks(5588),
                            Description = "Placeat explicabo impedit aut molestias adipisci. Consequuntur vel accusamus voluptatum voluptatum repellat soluta quia sed. Ex possimus voluptatum corrupti consequatur.",
                            Slug = "officia-odit-ea",
                            Title = "Iusto quis ad totam dolorem ut sint dolorum porro.",
                            UpdatedAt = new DateTime(2021, 4, 20, 13, 9, 4, 6, DateTimeKind.Local).AddTicks(2500)
                        },
                        new
                        {
                            Id = 3,
                            Body = "Facilis veritatis delectus. Ea provident ea ea at laudantium neque et. Fugiat nesciunt voluptatum error. Ipsum et reprehenderit officia qui et sit at officiis.",
                            CreatedAt = new DateTime(2020, 9, 24, 14, 9, 59, 708, DateTimeKind.Local).AddTicks(9050),
                            Description = "Et iste cumque molestias dolor natus nostrum quia. Laudantium magni temporibus. Vitae natus nam. Sint sit ducimus omnis exercitationem quaerat vitae ut fugiat.",
                            Slug = "tenetur-adipisci-earum",
                            Title = "Harum consectetur sint tenetur aliquam non qui commodi.",
                            UpdatedAt = new DateTime(2021, 4, 20, 17, 0, 47, 895, DateTimeKind.Local).AddTicks(8911)
                        },
                        new
                        {
                            Id = 4,
                            Body = "In rerum iusto. Aut et veniam eius libero nihil nemo. Illo quo fugiat pariatur illo in.",
                            CreatedAt = new DateTime(2021, 4, 4, 17, 31, 16, 341, DateTimeKind.Local).AddTicks(5319),
                            Description = "Quos soluta nesciunt consequatur aliquid facere. Ad non dolores. Occaecati quas nam tenetur laborum illo nam veritatis ducimus. Expedita fugiat odit ut nemo numquam saepe. Ex sit reiciendis veritatis blanditiis soluta facere incidunt dolor quae.",
                            Slug = "dolorum-nesciunt-hic",
                            Title = "Veniam deleniti aut dolores.",
                            UpdatedAt = new DateTime(2021, 4, 20, 11, 9, 42, 907, DateTimeKind.Local).AddTicks(1375)
                        },
                        new
                        {
                            Id = 5,
                            Body = "Sed quasi dolorum nemo unde. Suscipit voluptates aut atque ab et expedita molestiae dolor. Accusantium nisi possimus porro.",
                            CreatedAt = new DateTime(2020, 11, 8, 21, 19, 7, 43, DateTimeKind.Local).AddTicks(949),
                            Description = "Qui deserunt magni expedita non tempore numquam non. Perspiciatis aut dolorum nulla ut dolor sed alias est. Sit autem atque impedit facilis id ullam sit quis. Est occaecati libero eos. Blanditiis laudantium dignissimos reprehenderit. Omnis quia rerum architecto voluptatem ducimus et.",
                            Slug = "tempora-reprehenderit-sunt",
                            Title = "Aut blanditiis ab maiores sed eum ad dolorum repudiandae iure.",
                            UpdatedAt = new DateTime(2021, 4, 20, 7, 2, 54, 168, DateTimeKind.Local).AddTicks(5929)
                        },
                        new
                        {
                            Id = 6,
                            Body = "Tempore quam at. Ipsam aut enim ut repellendus id. Iusto quis debitis totam itaque nulla.",
                            CreatedAt = new DateTime(2020, 8, 6, 5, 45, 22, 836, DateTimeKind.Local).AddTicks(3333),
                            Description = "Porro vitae beatae et. Sed quasi autem perspiciatis. A laboriosam voluptatibus eveniet dolore vero necessitatibus.",
                            Slug = "possimus-laborum-asperiores",
                            Title = "Consequatur minus velit ducimus velit.",
                            UpdatedAt = new DateTime(2021, 4, 20, 21, 17, 45, 171, DateTimeKind.Local).AddTicks(5902)
                        },
                        new
                        {
                            Id = 7,
                            Body = "Ea sint id ullam debitis accusantium qui reiciendis tempora consectetur. Qui architecto magnam earum veritatis voluptates. Ea id at maiores consequuntur. Et molestiae ex quisquam placeat dolor non sint et.",
                            CreatedAt = new DateTime(2020, 5, 23, 5, 53, 17, 19, DateTimeKind.Local).AddTicks(2725),
                            Description = "Id et deserunt omnis inventore ut at. Amet quae qui tempore praesentium. A ea sequi assumenda molestiae aut maiores.",
                            Slug = "vel-modi-est",
                            Title = "Ut magni quibusdam enim perferendis iure possimus officiis occaecati quia.",
                            UpdatedAt = new DateTime(2021, 4, 20, 18, 36, 2, 682, DateTimeKind.Local).AddTicks(5862)
                        },
                        new
                        {
                            Id = 8,
                            Body = "Vero reprehenderit aut cupiditate qui ducimus quo rem et. Exercitationem porro magni sint. Non fugit iusto voluptatum enim corporis maxime sed vitae ut. Et amet dolor veniam non repellat. Neque quo aliquid et accusamus. Eum hic animi qui et quam eum.",
                            CreatedAt = new DateTime(2021, 3, 26, 0, 26, 45, 161, DateTimeKind.Local).AddTicks(8310),
                            Description = "Excepturi qui possimus aspernatur autem reprehenderit non. Ducimus tempore aut tempora ducimus voluptatibus eos corrupti neque. Optio quod nemo. Ratione minima temporibus quasi facilis est. Unde sed excepturi ipsa ut cumque recusandae corrupti.",
                            Slug = "dolore-voluptatem-id",
                            Title = "Quaerat praesentium et sint deleniti dicta dolor aut voluptatem non.",
                            UpdatedAt = new DateTime(2021, 4, 20, 0, 15, 29, 948, DateTimeKind.Local).AddTicks(2339)
                        },
                        new
                        {
                            Id = 9,
                            Body = "Quia laudantium aut voluptatem. Nisi laboriosam et consequatur ratione at. Deleniti veritatis omnis quisquam ducimus ut dolorem. Et ipsam cupiditate ea tenetur ducimus itaque. Iusto voluptas veritatis reprehenderit cum quas ut est exercitationem amet. Dolor ea illum et cumque possimus numquam nobis.",
                            CreatedAt = new DateTime(2020, 8, 4, 5, 4, 15, 280, DateTimeKind.Local).AddTicks(7101),
                            Description = "Hic et nostrum. Ullam ullam consequatur ut. Laborum quo et debitis facilis ea cumque animi. Distinctio quasi in quas aut quia optio et. Nulla est est dolorem est dolore odio aut exercitationem enim.",
                            Slug = "architecto-illo-qui",
                            Title = "Perferendis quas iste aut amet est.",
                            UpdatedAt = new DateTime(2021, 4, 20, 7, 31, 7, 203, DateTimeKind.Local).AddTicks(1864)
                        },
                        new
                        {
                            Id = 10,
                            Body = "Quidem quis sit quidem sit et exercitationem vel impedit. Placeat ullam ipsum et. Dolore quis aut fugit eos fuga magnam sit aperiam. Ut est non similique consequatur temporibus. Officiis odio quaerat perferendis qui.",
                            CreatedAt = new DateTime(2020, 11, 21, 9, 46, 20, 914, DateTimeKind.Local).AddTicks(398),
                            Description = "Perferendis voluptate laboriosam dolor animi. Praesentium fugiat reiciendis. Rerum nihil quaerat saepe iure nesciunt ab. Dolorem id id omnis modi corporis quo sit. Dolore ut dolorem minus libero.",
                            Slug = "quisquam-et-possimus",
                            Title = "Voluptate suscipit aut itaque.",
                            UpdatedAt = new DateTime(2021, 4, 20, 7, 51, 24, 446, DateTimeKind.Local).AddTicks(9582)
                        });
                });

            modelBuilder.Entity("Blog.Domain.PostTag", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            TagId = 1
                        },
                        new
                        {
                            PostId = 2,
                            TagId = 2
                        },
                        new
                        {
                            PostId = 3,
                            TagId = 3
                        },
                        new
                        {
                            PostId = 4,
                            TagId = 4
                        },
                        new
                        {
                            PostId = 5,
                            TagId = 5
                        },
                        new
                        {
                            PostId = 6,
                            TagId = 6
                        },
                        new
                        {
                            PostId = 7,
                            TagId = 7
                        },
                        new
                        {
                            PostId = 8,
                            TagId = 8
                        },
                        new
                        {
                            PostId = 9,
                            TagId = 9
                        },
                        new
                        {
                            PostId = 10,
                            TagId = 10
                        },
                        new
                        {
                            PostId = 2,
                            TagId = 1
                        });
                });

            modelBuilder.Entity("Blog.Domain.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 11, 17, 8, 44, 22, 743, DateTimeKind.Local).AddTicks(5053),
                            Name = "et",
                            UpdatedAt = new DateTime(2021, 4, 20, 18, 49, 33, 755, DateTimeKind.Local).AddTicks(2654)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 3, 6, 34, 2, 120, DateTimeKind.Local).AddTicks(2190),
                            Name = "eveniet",
                            UpdatedAt = new DateTime(2021, 4, 20, 7, 23, 46, 747, DateTimeKind.Local).AddTicks(6075)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 1, 18, 10, 9, 45, 289, DateTimeKind.Local).AddTicks(173),
                            Name = "laboriosam",
                            UpdatedAt = new DateTime(2021, 4, 20, 4, 8, 50, 60, DateTimeKind.Local).AddTicks(7015)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 5, 6, 19, 22, 27, 523, DateTimeKind.Local).AddTicks(9273),
                            Name = "ea",
                            UpdatedAt = new DateTime(2021, 4, 20, 19, 56, 49, 379, DateTimeKind.Local).AddTicks(8143)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2020, 9, 5, 15, 11, 21, 386, DateTimeKind.Local).AddTicks(4107),
                            Name = "quasi",
                            UpdatedAt = new DateTime(2021, 4, 20, 10, 46, 38, 660, DateTimeKind.Local).AddTicks(8448)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2020, 8, 29, 0, 28, 40, 414, DateTimeKind.Local).AddTicks(3076),
                            Name = "sed",
                            UpdatedAt = new DateTime(2021, 4, 20, 14, 1, 11, 621, DateTimeKind.Local).AddTicks(5977)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2020, 6, 10, 19, 50, 23, 483, DateTimeKind.Local).AddTicks(2619),
                            Name = "voluptatem",
                            UpdatedAt = new DateTime(2021, 4, 20, 17, 23, 40, 995, DateTimeKind.Local).AddTicks(7391)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2021, 2, 11, 12, 0, 57, 928, DateTimeKind.Local).AddTicks(8409),
                            Name = "libero",
                            UpdatedAt = new DateTime(2021, 4, 20, 18, 53, 52, 198, DateTimeKind.Local).AddTicks(4995)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2021, 2, 6, 14, 52, 27, 806, DateTimeKind.Local).AddTicks(8514),
                            Name = "pariatur",
                            UpdatedAt = new DateTime(2021, 4, 20, 14, 44, 55, 1, DateTimeKind.Local).AddTicks(2210)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2020, 9, 3, 22, 27, 33, 494, DateTimeKind.Local).AddTicks(6876),
                            Name = "rerum",
                            UpdatedAt = new DateTime(2021, 4, 20, 15, 54, 3, 799, DateTimeKind.Local).AddTicks(6838)
                        });
                });

            modelBuilder.Entity("Blog.Domain.PostTag", b =>
                {
                    b.HasOne("Blog.Domain.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Domain.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Blog.Domain.Post", b =>
                {
                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("Blog.Domain.Tag", b =>
                {
                    b.Navigation("PostTags");
                });
#pragma warning restore 612, 618
        }
    }
}
