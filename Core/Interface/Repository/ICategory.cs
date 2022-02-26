using System.Collections.Generic;
using Core.Domain;
namespace Core.Interface.Repository
{
    public interface ICategory
    {
       bool AddCategory(MCategory addCat);
       bool DeleteCategory(int deleteCat_id);
       bool UpdateCategory(MCategory updateCat);
       List<MCategory> ShowChildCategory(int showchildCat_id);
       MCategory ShowParentCategory(int showparentCat_id);
       List<MCategory> ShowActiveCategory();
       List<MCategory> ShowDeactiveCategory();
    }
}