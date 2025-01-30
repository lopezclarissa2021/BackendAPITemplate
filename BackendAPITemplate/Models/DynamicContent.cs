using System.Diagnostics.CodeAnalysis;

namespace BackendAPITemplate.Models
{
    public class DynamicContent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public VisibilityStatus Visibility { get; set; }

    }
}
