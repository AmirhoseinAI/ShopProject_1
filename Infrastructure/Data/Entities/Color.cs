using System.ComponentModel.DataAnnotations;
namespace Infrastructure.Entities
{
    public class Color
    {
        [Key]
        public int Color_Id { get; set; }
        public string Color_Name { get; set; }
    }
}