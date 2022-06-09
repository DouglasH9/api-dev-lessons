using System.ComponentModel.DataAnnotations;

namespace api_dev_lessons.Models.Country
{
    public abstract class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public double? Rating { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; }
    }
}