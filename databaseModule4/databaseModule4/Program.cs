using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
namespace databaseModule4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext applicationContext = new ApplicationContext())
            {
                // first

                var first = applicationContext.ArtistSongs.Include(a => a.Artist).
                    Include(s => s.Song).ThenInclude(g => g.Genre);

                foreach (var f in first)
                {
                    Console.Write($"{f.Song.Title}, {f.Artist.Name}, {f.Song.Genre.Title}");
                    Console.WriteLine();
                }

                //second

                var youngArtist = applicationContext.Artists.AsEnumerable().Select(a => (DateTime.Now - a.DateOfBirth).TotalDays).Min();
                var oldSongs = applicationContext.Songs.Select(a => (DateTime.Now - a.ReleasedDate).TotalDays);

                foreach (var songs in oldSongs)
                {
                    if (songs > youngArtist)
                    {
                            Console.WriteLine(songs);
                    }
                }
            }
        }
    }
}