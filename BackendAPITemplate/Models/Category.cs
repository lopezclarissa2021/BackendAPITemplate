using System.ComponentModel.DataAnnotations;

namespace BackendAPITemplate.Models
{
    public class Category
    {
        [Key]
        public int CatergoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<DynamicContent> PostedDynamicContent { get; set; }
    }
}