using System.ComponentModel.DataAnnotations;

namespace Journal.API.Core.DTOs.Requests
{
    public class AddJournalRequest
    {
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Journal name must be at least 4 characters and maximum of 20")]
        public string name { get; set; }
    }

    public class AddJournalEntry
    {
        [Required]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Journal name must be at least 4 characters and maximum of 20")]
        public string entry { get; set; }
    }

}
