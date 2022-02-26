using System.Collections.Generic;
using AutoMapper;
using Core.Domain;
using Core.Interface.Repository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class RSize : ISize
    {
        private readonly IMapper IMap;
        private readonly ContextDB C;
        public RSize(ContextDB _C , IMapper _IMap)
        {
            C = _C;
            IMap = _IMap;
        }
        public bool AddSize(MSize addsize)
        {
            var m = IMap.Map<Size>(addsize);
            C.Sizes.Add(m);
            C.SaveChanges();
            return true;
        }

        public bool DeleteSize(int deletesize_id)
        {
            throw new System.NotImplementedException();
        }

        public List<MSize> ShowAllSizes()
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateSize(MSize updatesize)
        {
            throw new System.NotImplementedException();
        }
    }
}