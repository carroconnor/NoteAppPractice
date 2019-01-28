using System.ComponentModel.DataAnnotations;

namespace NoteApp.Models
{
    public class NoteCreate
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        public override string ToString() => Title;
    }
}
