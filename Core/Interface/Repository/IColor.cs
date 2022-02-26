using System.Collections.Generic;
using Core.Domain;
namespace Core.Interface.Repository
{
    public interface IColor
    {
       bool AddColor(MColor addcolor);
       bool DeleteColor(int deletecolor_id);
       bool UpdateColor(MColor updatecolor);
       List<MColor> ShowAllColors();
    }
}