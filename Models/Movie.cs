using System.ComponentModel.DataAnnotations;

namespace CInemaBookings.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        public string? MovieName { get; set; }
        public string? Genre { get; set; }
        [Display(Name = "Running Time")]
        public string? RunningTime { get; set; }
        [Display(Name = "Main Lead")]
        public string? MainLead { get; set; }
    }
}