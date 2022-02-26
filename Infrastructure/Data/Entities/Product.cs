using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public double Product_Price { get; set; }
        public int Product_Count { get; set; }
        public string Product_Description { get; set; }
        public string Product_MainImage { get; set; }
        public int Category_Id { get; set; }
        public bool Product_Status { get; set; }
        public int Color_Id { get; set; }
        public int Size_Id { get; set; }
        public int Product_discount { get; set; }
        public string Product_Type { get; set; }
    }
}