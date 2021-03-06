﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Weapsy.Data;

namespace Weapsy.Data.Migrations
{
    [DbContext(typeof(WeapsyDbContext))]
    [Migration("20170217100258_CreateSchema")]
    partial class CreateSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Weapsy.Data.Entities.App", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Folder");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("App");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.DomainAggregate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("DomainAggregate");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.DomainEvent", b =>
                {
                    b.Property<Guid>("DomainAggregateId");

                    b.Property<int>("SequenceNumber");

                    b.Property<string>("Body");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<string>("Type");

                    b.Property<Guid>("UserId");

                    b.HasKey("DomainAggregateId", "SequenceNumber");

                    b.HasIndex("DomainAggregateId");

                    b.ToTable("DomainEvent");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.EmailAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<bool>("DefaultCredentials");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Host");

                    b.Property<string>("Password");

                    b.Property<int>("Port");

                    b.Property<Guid>("SiteId");

                    b.Property<bool>("Ssl");

                    b.Property<int>("Status");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("EmailAccount");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CultureName");

                    b.Property<string>("Name");

                    b.Property<Guid>("SiteId");

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid>("SiteId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.MenuItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Link");

                    b.Property<Guid>("MenuId");

                    b.Property<Guid>("PageId");

                    b.Property<Guid>("ParentId");

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuItem");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.MenuItemLocalisation", b =>
                {
                    b.Property<Guid>("MenuItemId");

                    b.Property<Guid>("LanguageId");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("MenuItemId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("MenuItemId");

                    b.ToTable("MenuItemLocalisation");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.MenuItemPermission", b =>
                {
                    b.Property<Guid>("MenuItemId");

                    b.Property<string>("RoleId");

                    b.HasKey("MenuItemId", "RoleId");

                    b.HasIndex("MenuItemId");

                    b.ToTable("MenuItemPermission");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.Module", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ModuleTypeId");

                    b.Property<Guid>("SiteId");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ModuleTypeId");

                    b.HasIndex("SiteId");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.ModuleType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AppId");

                    b.Property<string>("Description");

                    b.Property<int>("EditType");

                    b.Property<string>("EditUrl");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<string>("ViewName");

                    b.Property<int>("ViewType");

                    b.HasKey("Id");

                    b.ToTable("ModuleType");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.Page", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("Name");

                    b.Property<Guid>("SiteId");

                    b.Property<DateTime?>("StartDate");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Page");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.PageLocalisation", b =>
                {
                    b.Property<Guid>("PageId");

                    b.Property<Guid>("LanguageId");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("PageId", "LanguageId");

                    b.HasIndex("PageId");

                    b.ToTable("PageLocalisation");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.PageModule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("InheritPermissions");

                    b.Property<Guid>("ModuleId");

                    b.Property<Guid>("PageId");

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<string>("Zone");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.ToTable("PageModule");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.PageModuleLocalisation", b =>
                {
                    b.Property<Guid>("PageModuleId");

                    b.Property<Guid>("LanguageId");

                    b.Property<string>("Title");

                    b.HasKey("PageModuleId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PageModuleId");

                    b.ToTable("PageModuleLocalisation");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.PageModulePermission", b =>
                {
                    b.Property<Guid>("PageModuleId");

                    b.Property<string>("RoleId");

                    b.Property<int>("Type");

                    b.HasKey("PageModuleId", "RoleId", "Type");

                    b.HasIndex("PageModuleId");

                    b.ToTable("PageModulePermission");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.PagePermission", b =>
                {
                    b.Property<Guid>("PageId");

                    b.Property<string>("RoleId");

                    b.Property<int>("Type");

                    b.HasKey("PageId", "RoleId", "Type");

                    b.HasIndex("PageId");

                    b.ToTable("PagePermission");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.Site", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AddLanguageSlug");

                    b.Property<string>("Copyright");

                    b.Property<Guid>("HomePageId");

                    b.Property<string>("Logo");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<Guid>("ModuleTemplateId");

                    b.Property<string>("Name");

                    b.Property<Guid>("PageTemplateId");

                    b.Property<int>("Status");

                    b.Property<Guid>("ThemeId");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.SiteLocalisation", b =>
                {
                    b.Property<Guid>("SiteId");

                    b.Property<Guid>("LanguageId");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("Title");

                    b.HasKey("SiteId", "LanguageId");

                    b.HasIndex("SiteId");

                    b.ToTable("SiteLocalisation");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.Theme", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Folder");

                    b.Property<string>("Name");

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Theme");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<int>("Status");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Weapsy.Data.Entities.DomainEvent", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.DomainAggregate", "DomainAggregate")
                        .WithMany("DomainEvents")
                        .HasForeignKey("DomainAggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.EmailAccount", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.Menu", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.MenuItem", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.Menu", "Menu")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.MenuItemLocalisation", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Weapsy.Data.Entities.MenuItem", "MenuItem")
                        .WithMany("MenuItemLocalisations")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.MenuItemPermission", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.MenuItem", "MenuItem")
                        .WithMany("MenuItemPermissions")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.Module", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.ModuleType", "ModuleType")
                        .WithMany("Modules")
                        .HasForeignKey("ModuleTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Weapsy.Data.Entities.Site", "Site")
                        .WithMany("Modules")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.Page", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.Site", "Site")
                        .WithMany("Pages")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.PageLocalisation", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.Page", "Page")
                        .WithMany("PageLocalisations")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.PageModule", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.Page")
                        .WithMany("PageModules")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.PageModuleLocalisation", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Weapsy.Data.Entities.PageModule", "PageModule")
                        .WithMany("PageModuleLocalisations")
                        .HasForeignKey("PageModuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.PageModulePermission", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.PageModule")
                        .WithMany("PageModulePermissions")
                        .HasForeignKey("PageModuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.PagePermission", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.Page", "Page")
                        .WithMany("PagePermissions")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Weapsy.Data.Entities.SiteLocalisation", b =>
                {
                    b.HasOne("Weapsy.Data.Entities.Site")
                        .WithMany("SiteLocalisations")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
