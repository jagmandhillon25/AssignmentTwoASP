using System.ComponentModel.DataAnnotations;

namespace AssignmentTwo.Models
{
    public class Event
    {
        public int EventId { get; set; }

        public string EventName { get; set; }

        public string EventDescription { get; set; }


        public string? EventPhoto { get; set; }


        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
