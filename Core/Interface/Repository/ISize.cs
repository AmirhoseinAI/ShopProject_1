using System.Collections.Generic;
using Core.Domain;
namespace Core.Interface.Repository
{
    public interface ISize
    {
       bool AddSize(MSize addsize);
       bool DeleteSize(int deletesize_id);
       bool UpdateSize(MSize updatesize);
       List<MSize> ShowAllSizes();
    }
}