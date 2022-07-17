using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using databaseModule4.Model;

namespace databaseModule4
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }

        public DbSet<ArtistSong> ArtistSongs { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EP3R97J;Initial Catalog=Module4;Integrated Security=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ARTIST 

            modelBuilder.Entity<Artist>().HasData(
                new Artist
                {
                    ArtistId = 1,
                    Name = "Fisrt",
                    DateOfBirth = DateTime.Now,
                    Phone = 09984419,
                    Email = "aaa@a.coma",
                    InstagramUrl = "Aaaaaa"
                },
                new Artist
                {
                    ArtistId = 2,
                    Name = "Second",
                    DateOfBirth = DateTime.Parse("08-02-2022 00:00:00"),
                    Phone = 09984429,
                    Email = "aaa@a.coma",
                    InstagramUrl = "Bb"
                },
                new Artist
                {
                    ArtistId = 3,
                    Name = "Third",
                    DateOfBirth = DateTime.Parse("08-03-2022 00:00:00"),
                    Phone = 09989419,
                    Email = "aaa@a.coma",
                    InstagramUrl = "Ccc"
                }
            );

            //GENRE

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    GenreId = 1,
                    Title = "FirstTitle"
                },
                new Genre
                {
                    GenreId= 2,
                    Title = "SecondTitle"
                },
                new Genre
                {
                    GenreId =3,
                    Title = "ThirdTitle"
                }
            );

            //SONG

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId =1,
                    Title = "Song1",
                    Duration = 2.6F,
                    ReleasedDate = DateTime.Parse("22-03-2022 00:00:00"),
                    GenreId = 1
                },
                new Song
                {
                    SongId=2,
                    Title = "Song2",
                    Duration = 3.0F,
                    ReleasedDate = DateTime.Parse("22-04-2022 00:00:00"),
                    GenreId = 1
                },
                new Song
                {
                    SongId=3,
                    Title = "Song3",
                    Duration = 2.7F,
                    ReleasedDate = DateTime.Parse("22-03-2022 00:00:00"),
                    GenreId = 2
                }
                );

            //ARTIST_SONG

            modelBuilder.Entity<ArtistSong>().HasData(
                new ArtistSong
                {
                    Id = 1,
                    ArtistId = 1,
                    SongId = 1,
                    SungNum = 23
                },
                new ArtistSong
                {
                    Id = 2,
                    ArtistId = 2,
                    SongId = 2,
                    SungNum = 24
                },
                new ArtistSong
                {
                    Id = 3,
                    ArtistId = 3,
                    SongId = 3,
                    SungNum = 20
                }
                );
        }
    }
}