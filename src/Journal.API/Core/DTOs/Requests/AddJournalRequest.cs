using System.ComponentModel.DataAnnotations;

namespace Journal.API.Core.DTOs.Requests
{
    public class AddJournalRequest
    {
        [Required]
        public string name { get; set; }
    }

    public class AddJournalEntry
    {
        [Required]
        public string entry { get; set; }
    }

}
