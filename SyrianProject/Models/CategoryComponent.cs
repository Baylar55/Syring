namespace SyrianProject.Models
{
    public class CategoryComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string FilePath { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
