using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Context
{
    public class Size
    {
        [Key]
        public int Size_Id { get; set; }
        public string Size_size { get; set; }
    }
}