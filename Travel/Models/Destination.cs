using System.ComponentModel.DataAnnotations;

namespace Travel.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Review { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        //[Required]
        //[Compare("User_Name", ErrorMessage = "username must match username of review")]
        //public string UserName { get; set; }
    }
}