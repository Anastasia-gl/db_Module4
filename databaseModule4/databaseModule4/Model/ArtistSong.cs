using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseModule4.Model
{
    internal class ArtistSong
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("ArtistId")]
        public int ArtistId { get; set; }

        public Artist Artist { get; set; }

        [ForeignKey("SongId")]
        public int SongId { get; set; }

        public Song Song { get; set; }

        public int? SungNum { get; set; }
    }
}
