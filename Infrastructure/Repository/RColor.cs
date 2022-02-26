using System.Collections.Generic;
using AutoMapper;
using Core.Domain;
using Core.Interface.Repository;
using Infrastructure.Context;
using Infrastructure.Entities;

namespace Infrastructure.Repository
{
    public class RColor : IColor
    {
        private readonly IMapper IMap;
        private readonly ContextDB C;
        public RColor(ContextDB _C , IMapper _IMap)
        {
            C = _C;
            IMap = _IMap;
        }
        public bool AddColor(MColor addcolor)
        {
            var a = IMap.Map<Color>(addcolor);
            C.Colors.Add(a);
            C.SaveChanges();
            return true;
        }

        public bool DeleteColor(int deletecolor_id)
        {
            throw new System.NotImplementedException();
        }

        public List<MColor> ShowAllColors()
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateColor(MColor updatecolor)
        {
            throw new System.NotImplementedException();
        }
    }
}