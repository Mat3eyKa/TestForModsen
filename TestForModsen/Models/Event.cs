using System;

namespace TestForModsen.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Plan { get; set; } = string.Empty;
        public string Sponsor { get; set; } = string.Empty;
        public string Speaker { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public string Location { get; set; } = string.Empty;
    }
}
