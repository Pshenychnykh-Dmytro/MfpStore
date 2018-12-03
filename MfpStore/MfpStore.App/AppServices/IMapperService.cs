using System;
using System.Collections.Generic;
using System.Text;

namespace MfpStore.App.AppServices
{
    public interface IMapperService
    {
        TModel MapTo<TModel>(object model);
    }
}
