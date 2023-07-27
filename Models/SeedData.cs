using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NeoTagger.Data;
using System;
using System.Linq;

namespace NeoTagger.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new NeoTaggerContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<NeoTaggerContext>>()))
        {
            // Look for any tags.
            if (context.Tag.Any())
            {
                return;   // DB has been seeded
            }
            context.Tag.AddRange(
                new Tag
                {
                    Name = "Mount Sanitas",
                    UserId = 1,
                    Lat = 40.03444842457057,
                    Lng = -105.30539923462995,
                    Public = true,
                    Archived = false,
                    InsertedAt = DateTime.Parse("2023-07-27 15:29:16")
                },
                new Tag
                {
                    Name = "Green Mountain",
                    UserId = 1,
                    Lat = 39.98220553525559,
                    Lng = -105.30172812786824,
                    Public = true,
                    Archived = false,
                    InsertedAt = DateTime.Parse("2023-07-27 15:29:16")
                },
                new Tag
                {
                    Name = "Bear Peak",
                    UserId = 1,
                    Lat = 39.96023664453469,
                    Lng = -105.29521534294383,
                    Public = true,
                    Archived = false,
                    InsertedAt = DateTime.Parse("2023-07-27 15:29:16")
                },
                new Tag
                {
                    Name = "James Peak",
                    UserId = 1,
                    Lat = 39.852212729402254,
                    Lng = -105.68999084802694,
                    Public = true,
                    Archived = false,
                    InsertedAt = DateTime.Parse("2023-07-27 15:29:16")
                },
                new Tag
                {
                    Name = "Longs Peak",
                    UserId = 1,
                    Lat = 40.25541188995004,
                    Lng = -105.6159460327693,
                    Public = true,
                    Archived = false,
                    InsertedAt = DateTime.Parse("2023-07-27 15:29:16")
                }
            );
            context.SaveChanges();
        }
    }
}