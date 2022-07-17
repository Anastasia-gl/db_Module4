using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseModule4.Model
{
    internal class Song
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongId { get; set; }

        [MaxLength(20)]
        public string Title { get; set; }

        public float Duration { get; set; }

        public DateTime ReleasedDate { get; set; }

        [ForeignKey("GenreId")]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public List<ArtistSong> ArtistSongs { get; set; }
    }
}
