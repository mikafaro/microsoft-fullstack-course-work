using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [FutureDate(ErrorMessage = "Event date must be in the future.")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Location { get; set; }
    }
}