using System.Collections.Generic;
using AutoMapper;
using Core.Domain;
using Core.Interface.Repository;
using Infrastructure.Context;
using Infrastructure.Entities;


namespace Infrastructure.Repository
{
    public class RCategory : ICategory
    {
        private readonly IMapper IMap;
        private readonly ContextDB C;
        public RCategory(ContextDB _C , IMapper _IMap)
        {
            C = _C;
            IMap = _IMap; 
        }
        public bool AddCategory(MCategory addCat)
        {
            // var m = IMap.Map<Category>(addCat);
            // C.Categories.Add(m);
            // C.SaveChanges();
            return true;
        }

        public bool DeleteCategory(int deleteCat_id)
        {
            throw new System.NotImplementedException();
        }

        public List<MCategory> ShowActiveCategory()
        {
            throw new System.NotImplementedException();
        }

        public List<MCategory> ShowChildCategory(int showchildCat_id)
        {
            throw new System.NotImplementedException();
        }

        public List<MCategory> ShowDeactiveCategory()
        {
            throw new System.NotImplementedException();
        }

        public MCategory ShowParentCategory(int showparentCat_id)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateCategory(MCategory updateCat)
        {
            throw new System.NotImplementedException();
        }
    }
}