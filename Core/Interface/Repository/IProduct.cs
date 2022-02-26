using System.Collections.Generic;
using Core.Domain;

namespace Core.Repository
{
    public interface IProduct
    {
        bool AddProduct(MProduct addproduct);
        bool UpdateProduct(MProduct updateproduct);
        bool DeleteProduct(int deleteproduct_id);
        List<MProduct> ShowProductCategory(int category_id);
        MProduct DetailsProduct(int product_id);
        List<MProduct> ShowProductType(string type);
        List<MProduct> ShowActiveStatusProduct();
    }
}