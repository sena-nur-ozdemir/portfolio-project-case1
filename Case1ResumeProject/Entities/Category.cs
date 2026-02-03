namespace Case1ResumeProject.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategorySlug { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }
    }
}
