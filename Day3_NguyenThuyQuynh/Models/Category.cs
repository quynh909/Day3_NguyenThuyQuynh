using System.ComponentModel.DataAnnotations;

namespace Day3_NguyenThuyQuynh.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 chara")]
        public string? Name { get; set; }
        public string Description { get; set; }=string.Empty; //2 cach tuong duong nhau

    }
}
