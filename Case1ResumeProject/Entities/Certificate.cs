namespace Case1ResumeProject.Entities
{
    public class Certificate
    {
        public int CertificateId { get; set; }
        public string Title { get; set; }
        public string Organization { get; set; }
        public string? Description { get; set; }
        public string Date { get; set; }
        public bool IsActive { get; set; }
    }
}
