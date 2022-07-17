using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace databaseModule4.Model
{
    internal class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenreId { get; set; }

        [MaxLength(20)]
        public string Title { get; set; }

        public List<Song> Songs { get; set; }
    }
}
