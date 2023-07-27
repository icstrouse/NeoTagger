using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NeoTagger.Models;

namespace NeoTagger.Data
{
    public class NeoTaggerContext : DbContext
    {
        public NeoTaggerContext (DbContextOptions<NeoTaggerContext> options)
            : base(options)
        {
        }

        public DbSet<NeoTagger.Models.Tag> Tag { get; set; } = default!;
    }
}
