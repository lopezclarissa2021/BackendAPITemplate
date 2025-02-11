using BackendAPITemplate.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;
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
        //public string CreatedById { get; set; }
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        //[ForeignKey(nameof(CreatedById))]
        //public virtual BlogUser CreatedBy { get; set; }
        public VisibilityStatus Visibility { get; set; }

    }
}
