using Day3_NguyenThuyQuynh.Models;

namespace Day3_NguyenThuyQuynh.data
{
    public class SeedData
    {
        public static List<Models.Category> categories = new List<Category> 
        {
            new Category(){Id=1, Name="Category 1", Description="Description 1"},
            new Category(){Id=2, Name="Category 2", Description="Description 2"},
            new Category(){Id=3, Name="Category 3", Description="Description 3"},
        };

    }
}
