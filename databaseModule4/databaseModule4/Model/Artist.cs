using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseModule4.Model
{
    internal class Artist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArtistId { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public long Phone { get ; set; }

        [MaxLength(50)]
        public string? Email { get; set; }

        public string? InstagramUrl { get; set; }
    
        public List<ArtistSong> ArtistSongs { get; set; }
    }
}
