using System.Collections.Generic;
using Core.Domain;
using Core.Repository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class RProduct : IProduct
    {
        private readonly ContextDB C;
        public RProduct(ContextDB _C)
        {
            C = _C;
        }
        public bool AddProduct(MProduct addproduct)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteProduct(int deleteproduct_id)
        {
            throw new System.NotImplementedException();
        }

        public MProduct DetailsProduct(int product_id)
        {
            throw new System.NotImplementedException();
        }

        public List<MProduct> ShowActiveStatusProduct()
        {
            throw new System.NotImplementedException();
        }

        public List<MProduct> ShowProductCategory(int category_id)
        {
            throw new System.NotImplementedException();
        }

        public List<MProduct> ShowProductType(string type)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateProduct(MProduct updateproduct)
        {
            throw new System.NotImplementedException();
        }
    }
}