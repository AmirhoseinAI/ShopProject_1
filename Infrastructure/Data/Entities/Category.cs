using System.ComponentModel.DataAnnotations;
namespace Infrastructure.Entities
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public int Category_ParentId { get; set; }
        public bool Category_Status { get; set; }
    }
}