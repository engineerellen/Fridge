﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context;
public class GeladeiraContext : DbContext
{
    public DbSet<Item> Items { get; set; }

    public DbSet<Usuario>? Usuarios { get; set; }

    public GeladeiraContext(DbContextOptions<GeladeiraContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Item>()
            .HasKey(i => i.IdItem);

        modelBuilder.Entity<Item>()
            .Property(i => i.Descricao)
            .IsRequired()
            .HasMaxLength(100);
    }
}