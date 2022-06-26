using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string? PublicId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } 
        public int ApplicationUserId { get; set; }
    }
}