namespace Case1ResumeProject.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string ProjectTitle { get; set; }
        public string ImageUrl { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
