using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace MfpStore.App.AppServices
{
    public class MapperService: IMapperService
    {
        public TModel MapTo<TModel>(object model)
        {
            return Mapper.Map<TModel>(model);
        }
    }
}
