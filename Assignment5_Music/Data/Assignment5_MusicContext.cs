using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment5_Music.Models;

namespace Assignment5_Music.Data
{
    public class Assignment5_MusicContext : DbContext
    {
        public Assignment5_MusicContext (DbContextOptions<Assignment5_MusicContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment5_Music.Models.Music> Music { get; set; } = default!;
    }
}
